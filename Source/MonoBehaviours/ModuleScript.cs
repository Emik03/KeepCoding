using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using KeepCoding.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;
using static System.Linq.Enumerable;
using static System.Reflection.BindingFlags;
using static KeepCoding.External;
using static KeepCoding.Game;
using static KeepCoding.Game.KTInputManager;
using static KeepCoding.Game.MasterAudio;
using static KeepCoding.Logger;
using static KMAudio;
using static KMSoundOverride;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes.
    /// </summary>
    [CLSCompliant(false)]
    public abstract class ModuleScript : CacheableBehaviour, IAwake,
#if !LITE
        IDump,
#endif
        ILog
    {
        private bool _hasException;

        private static bool s_hasCheckedVersion;

        [SerializeField]
#pragma warning disable 649, IDE0044 // Add readonly modifier
        private int _editorRuleSeed = 1;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        private int _strikes;

#if !LITE
        private static readonly Dictionary<string, Dictionary<string, object>[]> s_database = new Dictionary<string, Dictionary<string, object>[]>();
#endif

        /// <summary>
        /// Determines whether the module has been struck. <see cref="TPScript{TModule}.OnInteractSequence(KMSelectable[], float, int[])"/> will set this to <see langword="false"/> when a command is interrupted.
        /// </summary>
        public bool HasStruck { get; set; }

        /// <summary>
        /// Determines whether the bomb is currently active, and the timer is ticking.
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// Determines whether the module's colorblind mode is enabled.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        public bool IsColorblind
        {
            get => IsColorblindSupported ? (Colorblind?.IsModuleEnabled ?? false) : throw new MissingMethodException($"Colorblind is not implemented for this module. You need to override {nameof(OnColorblindChanged)} if you want to implement colorblind support.");
            set
            {
                if (IsColorblind != value)
                    OnColorblindChanged(Colorblind.IsModuleEnabled = value);
            }
        }

#if !LITE
        /// <summary>
        /// Determines whether the application is running from inside unity.
        /// </summary>
        public static bool IsEditor => isEditor;

        /// <summary>
        /// Determines whether this module is the last instantiated instance.
        /// </summary>
        public bool IsLastInstantiated => Id == LastId;
#endif

        /// <summary>
        /// Determines whether the needy is active.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        public bool IsNeedyActive => Module.Module is KMNeedyModule ? _isNeedyActive : throw new MissingComponentException($"A {nameof(KMNeedyModule)} must be attached in order to access this property.");
        private bool _isNeedyActive;

        /// <summary>
        /// Determines whether the module has been solved.
        /// </summary>
        public bool IsSolved { get; private set; }

        /// <summary>
        /// Determines whether the game is being played with motion virtual reality. In the Editor, it always returns false.
        /// </summary>
        public static bool IsVR => CurrentControlType is ControlType.Motion;

        /// <summary>
        /// The Unique Id for the module of this type.
        /// </summary>
        public int Id => Logger.Id;
        private int ModuleId => Logger.Id;

        /// <summary>
        /// The last Id instantiation for the module of this type.
        /// </summary>
        public int LastId => s_ids[Module.Name];

        /// <summary>
        /// The amount of time left on the bomb, in seconds, rounded down.
        /// </summary>
        public int TimeLeft { get; private set; }

        /// <summary>
        /// Gets the rule seed number.
        /// </summary>
        /// <returns>The rule seed number, by default 1.</returns>
        public int RuleSeedId => _ruleSeedId ??= GetRuleSeedId(Module, _editorRuleSeed);
        private int? _ruleSeedId;

        /// <summary>
        /// The version number of the entire mod.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        public string Version => PathManager.GetModInfo(Name).Version.NullOrEmptyCheck("The version number is empty. To fix this, go to Keep Talking ModKit -> Configure Mod, then fill in the version number.");

        /// <summary>
        /// The ignored modules of this module from the Boss Module Manager.
        /// </summary>
        public string[] IgnoredModules => _ignoredModules ??= GetIgnoredModules(Module);
        private string[] _ignoredModules;

        /// <summary>
        /// Contains colorblind information. This property will return <see langword="null"/> in the event that <see cref="OnColorblindChanged(bool)"/> isn't implemented.
        /// </summary>
        public ColorblindInfo Colorblind => _colorblind ??= (IsColorblindSupported ? new ColorblindInfo(Module.Id) : null);
        private ColorblindInfo _colorblind;

        /// <summary>
        /// Gets the Twitch Plays <see cref="Component"/> attached to this <see cref="GameObject"/>.
        /// </summary>
        /// <remarks>
        /// Due to type ambiguity, a non-generic interface is returned.
        /// </remarks>
        public ITP TP => _tp ??= GetComponent<ITP>();
        private ITP _tp;

        /// <summary>
        /// The bomb that this module is in.
        /// </summary>
        /// <remarks>
        /// Note that this variable is not available instantly. <see cref="OnActivate"/> is recommended, or a <see cref="Coroutine"/> that waits for this value to be set.
        /// </remarks>
        public KMBomb Bomb => _bomb ??= GetComponentInParent<KMBomb>();
        private KMBomb _bomb;

        /// <summary>
        /// Contains an instance for every <see cref="Sound"/> played by this module using <see cref="PlaySound(Transform, bool, Sound[])"/> or any of its overloads.
        /// </summary>
        public List<Sound> Sounds { get; private set; } = new List<Sound>();

        /// <summary>
        /// Contains either <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>, and allows for running commands through context.
        /// </summary>
        public ModuleContainer Module => _module ??= new ModuleContainer(this);
        private ModuleContainer _module;

        /// <summary>
        /// The pseudo-random number generator whose number generations are based on the current Rule Seed.
        /// </summary>
        public MonoRandom RuleSeed => _ruleSeed ??= new MonoRandom(RuleSeedId);
        private MonoRandom _ruleSeed;

        /// <summary>
        /// Contains every module in the <see cref="KMBomb"/> that this module is in.
        /// </summary>
        /// <remarks>
        /// Note that this variable is not available instantly. <see cref="OnActivate"/> is recommended, or a <see cref="Coroutine"/> that waits for this value to be set. A small amount of time is needed for this property to be set. This collection also includes vanilla modules, including <see cref="ComponentPool.ComponentTypeEnum.Empty"/> components and <see cref="ComponentPool.ComponentTypeEnum.Timer"/>. You can filter the collection with <see cref="ModuleContainer.IsVanilla"/>, <see cref="ModuleContainer.IsModded"/>, <see cref="ModuleContainer.IsSolvable"/>, or <see cref="ModuleContainer.IsNeedy"/>, <see cref="ModuleContainer.IsEmptyOrTimer"/>, or <see cref="ModuleContainer.IsModule"/>.
        /// </remarks>
        public ReadOnlyCollection<ModuleContainer> Modules => _modules ??= ModulesOfBomb(Bomb);
        private ReadOnlyCollection<ModuleContainer> _modules;

        internal bool IsColorblindSupported => _isColorblindSupported ??= Type.ImplementsMethod(nameof(OnColorblindChanged), DeclaredOnly | Instance | Public);
        private bool? _isColorblindSupported;

        internal static bool IsOutdated { get; private set; }

        private string Name => _name ??= Type.NameOfAssembly();
        private string _name;

        private Logger Logger => _logger ??= new Logger(Module.Name, true);
        private Logger _logger;

        private Type Type => _type ??= GetType();
        private Type _type;

        /// <summary>
        /// Appends events to this instance's <see cref="Module"/>, preserving their existing values.
        /// </summary>
        /// <param name="activate">Called when the lights turn on.</param>
        /// <param name="needyActivate">Called when the needy activates.</param>
        /// <param name="needyDeactivate">Called when the needy deactivates.</param>
        /// <param name="needyTimerExpired">Called when the timer runs out of time.</param>
        /// <param name="solve">Called when the needy is solved.</param>
        /// <param name="strike">Called when the needy strikes.</param>
        /// <param name="needyTimerSet">Called when <see cref="KMNeedyModule.GetNeedyTimeRemaining"/> is called.</param>
        /// <param name="ruleGeneration">Called when <see cref="KMBombModule.GetRuleGenerationSeed"/> or <see cref="KMNeedyModule.GetRuleGenerationSeed"/> is called.</param>
        /// <param name="needyTimerGet">Called when <see cref="KMNeedyModule.SetNeedyTimeRemaining(float)"/> is called.</param>
        public void Append(Action activate = null, Action needyActivate = null, Action needyDeactivate = null, Action needyTimerExpired = null, Action solve = null, Action strike = null, Action<float> needyTimerSet = null, Func<int> ruleGeneration = null, Func<float> needyTimerGet = null) =>
            Module.Append(activate, needyActivate, needyDeactivate, needyTimerExpired, solve, strike, needyTimerSet, ruleGeneration, needyTimerGet);

        /// <summary>
        /// Assigns events to this instance's <see cref="Module"/>, replacing their existing values.
        /// </summary>
        /// <param name="activate">Called when the lights turn on.</param>
        /// <param name="needyActivate">Called when the needy activates.</param>
        /// <param name="needyDeactivate">Called when the needy deactivates.</param>
        /// <param name="needyTimerExpired">Called when the timer runs out of time.</param>
        /// <param name="solve">Called when the needy is solved.</param>
        /// <param name="strike">Called when the needy strikes.</param>
        /// <param name="needyTimerSet">Called when <see cref="KMNeedyModule.GetNeedyTimeRemaining"/> is called.</param>
        /// <param name="ruleGeneration">Called when <see cref="KMBombModule.GetRuleGenerationSeed"/> or <see cref="KMNeedyModule.GetRuleGenerationSeed"/> is called.</param>
        /// <param name="needyTimerGet">Called when <see cref="KMNeedyModule.SetNeedyTimeRemaining(float)"/> is called.</param>
        public void Assign(Action activate = null, Action needyActivate = null, Action needyDeactivate = null, Action needyTimerExpired = null, Action solve = null, Action strike = null, Action<float> needyTimerSet = null, Func<int> ruleGeneration = null, Func<float> needyTimerGet = null) => Module.Assign(activate.Combine(() =>
        {
            OnActivate();
            IsActive = true;

            if (IsColorblindSupported && IsColorblind)
                OnColorblindChanged(IsColorblind);
        }), needyActivate.Combine(() =>
        {
            OnNeedyActivate();
            _isNeedyActive = true;
        }), needyDeactivate.Combine(() =>
        {
            OnNeedyDeactivate();
            _isNeedyActive = false;
        }), needyTimerExpired.Combine(() =>
        {
            OnNeedyDeactivate();
            _isNeedyActive = false;
        }), solve, strike, needyTimerSet, ruleGeneration, needyTimerGet);

#if LITE
        /// <summary>
        /// Sets up base functionality for the module. If you declare this method yourself, make sure to call <c>base.Awake()</c> to ensure that the module initializes correctly.
        /// </summary>
#else
        /// <summary>
        /// Sets up base functionality for the module. If you declare this method yourself, make sure to call <c>base.Awake()</c> to ensure that the module initializes correctly, or use <see cref="OnAwake"/> instead.
        /// </summary>
#endif
        public void Awake()
        {
            logMessageReceived += HandleException;
#if !LITE
            s_database.Clear();
#endif
            Self($"The module \"{Module.Name}\" ({Module.Id}) uses KeepCoding version {PathManager.Version}.");
            Log($"Version: [{Version}]");

            Assign();
#if !LITE
            OnAwake();
#endif
            StartCoroutine(CheckForUpdates());
            StartCoroutine(WaitForBomb());
        }

        /// <summary>
        /// Handles typical button <see cref="KMSelectable.OnInteract"/> behaviour.
        /// </summary>
        /// <exception cref="UnassignedReferenceException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="selectable">The selectable, which is used as a source for sound and bomb shake.</param>
        /// <param name="intensityModifier">The intensity of the bomb shaking.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        public void ButtonEffect(KMSelectable selectable, float intensityModifier = 0, params Sound[] sounds)
        {
            selectable.Assert("The selectable should not be null when calling this method.").AddInteractionPunch(intensityModifier);
            PlaySound(selectable.transform, sounds);
        }

#if !LITE
        /// <summary>
        /// Dumps all information that it can find of the type using reflection. This should only be used to debug.
        /// </summary>
        /// <param name="obj">The object to reflect on.</param>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        public void Dump<T>(T obj, bool getVariables = false) => Logger.Dump(obj, getVariables);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs) => Logger.Dump(getVariables, logs);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs) => Logger.Dump(logs);
#endif

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        public void Log<T>(T message, LogType logType = LogType.Log) => Logger.Log(message, logType);

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => Logger.Log(message, args);

#if !LITE
        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => Logger.LogMultiple(logs);

        /// <summary>
        /// Called when the module instantiates, well before the lights turn on.
        /// </summary>
        public virtual void OnAwake() { }
#endif

        /// <summary>
        /// Called when the lights turn on.
        /// </summary>
        public virtual void OnActivate() { }

        /// <summary>
        /// Called when colorblind support needs to be updated for the module.
        /// </summary>
        /// <param name="isEnabled">Whether colorblind support should be enabled.</param>
        public virtual void OnColorblindChanged(bool isEnabled) { }

        /// <summary>
        /// Called when the module destroys itself, after the bomb unloads.
        /// </summary>
        public virtual void OnDestruct() { }

        /// <summary>
        /// Called when an unhandled exception relating to this module has been thrown.
        /// </summary>
        /// <remarks>
        /// Unlike other virtual methods, this one has implementation. You may choose to invoke <c>base.OnException()</c> if you want the module to automatically log and solve.
        /// </remarks>
        /// <param name="message">The message of the exception.</param>
        public virtual void OnException(string message)
        {
            void ForceSolve()
            {
                StartCoroutine(WaitForSolve());
                Get<KMSelectable>().OnInteract = null;
            }

            Log("The module threw an unhandled exception... {0}", message);

            if (TP?.IsTP ?? false)
                return;

            if (Get<KMSelectable>(allowNull: true))
                Get<KMSelectable>().Assign(onInteract: ForceSolve);
            else
                ForceSolve();
        }

        /// <summary>
        /// Called when any module on the current bomb has issued a strike.
        /// </summary>
        /// <param name="module">The sender encapsulated as <see cref="ModuleContainer"/>, which caused a strike.</param>
        public virtual void OnModuleStrike(ModuleContainer module) { }

        /// <summary>
        /// Called when the needy activates.
        /// </summary>
        public virtual void OnNeedyActivate() { }

        /// <summary>
        /// Called when the needy deactivates or runs out of time.
        /// </summary>
        public virtual void OnNeedyDeactivate() { }

        /// <summary>
        /// Called when any <see cref="KMBombModule"/> or BombComponent on the current bomb has been solved.
        /// </summary>
        /// <param name="module">The sender encapsulated as <see cref="ModuleContainer"/>, which was solved.</param>
        public virtual void OnModuleSolved(ModuleContainer module) { }

        /// <summary>
        /// Called when the timer's seconds-digit changes.
        /// </summary>
        public virtual void OnTimerTick() { }

        /// <summary>
        /// Solves the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Solve(params string[] logs)
        {
            if (IsSolved)
                return;

            if (_hasException)
                AddStrikes(Bomb, -_strikes, false);

            logs?.ForEach(s => Log(s));

            IsSolved = true;
            Module.Solve.Get()();
        }

        /// <summary>
        /// Strikes the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Strike(params string[] logs)
        {
            if (_hasException)
                return;

            logs?.ForEach(s => Log(s));

            HasStruck = true;
            _strikes++;

            Module.Strike.Get()();
        }

#if !LITE
        /// <summary>
        /// Sends information to a static variable such that other modules can access it.
        /// </summary>
        /// <remarks>
        /// To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.
        /// </remarks>
        /// <typeparam name="T">The type of the expected input.</typeparam>
        /// <param name="key">The key of the variable, a lot like a variable name.</param>
        /// <param name="value">The value to store in the key.</param>
        public void Write<T>(string key, T value)
        {
            if (!s_database.ContainsKey(Module.Id))
                s_database.Add(Module.Id, new Dictionary<string, object>[] { });

            int index = LastId - Id;

            (index - s_database[Module.Id].Length + 1).For(_ => s_database[Module.Id].Append(new Dictionary<string, object>()));

            if (!s_database[Module.Id][index].ContainsKey(key))
                s_database[Module.Id][index].Add(key, null);

            s_database[Module.Id][index][key] = value;

            if (IsEditor)
                Self($"Added \"{value}\" to {nameof(s_database)}: [{nameof(Module.Id)}, {Module.Id}: [{nameof(index)}, {index}: {value}]]");
        }
#endif

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="MissingComponentException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, bool loop, params Sound[] sounds)
        {
            sounds.NullOrEmptyCheck($"{nameof(sounds)} is null or empty.");

            if (Gets<KMAudio>().Length != 1)
                throw Gets<KMAudio>().Length == 0 ? (Exception)new MissingComponentException($"A sound cannot be played when there is no {nameof(KMAudio)} component.") : new InvalidOperationException($"There is more than one {nameof(KMAudio)} component. This is considered a mistake because the game will only add the sounds to one of the {nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned.");

            sounds = sounds.Where(s =>
            {
                if (s.Custom is null || IsGroupInfo(Name, s.Custom))
                    s.Reference = s.Method(Get<KMAudio>())(transform, loop);

                else
                    Log($"The sound \"{s.Custom}\" was attempted to be played but there is no corresponding {nameof(AudioClip)} found in the bundle. Check for misspellings, ensure that there is a singular {nameof(KMAudio)} component, and make sure the audio clip being played has a mod.bundle tag.", LogType.Error);

                return s.Reference is { };
            }).ToArray();

            Sounds.AddRange(sounds);

            return sounds;
        }

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, params Sound[] sounds) => PlaySound(transform, false, sounds);

        /// <summary>
        /// Plays a sound, the sound source is the game object it is attached to. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(bool loop, params Sound[] sounds) => PlaySound(transform, loop, sounds);

        /// <summary>
        /// Plays a sound, the sound source is the game object it is attached to. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(params Sound[] sounds) => PlaySound(transform, false, sounds);

#if !LITE
        /// <summary>
        /// Allows you to read a module's data that uses <see cref="Write{T}(string, T)"/>, even from a different assembly.
        /// </summary>
        /// <remarks>
        /// To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.
        /// </remarks>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <typeparam name="T">The type of the expected output.</typeparam>
        /// <param name="module">The module to look into.</param>
        /// <param name="key">The key of the variable, a lot like a variable name.</param>
        /// <param name="allowDefault">Whether it should throw an exception if no value is found, or provide the default value instead.</param>
        /// <returns>Every instance of the value from the every instance of the module specified.</returns>
        public static T[] Read<T>(string module, string key, bool allowDefault = false) where T : class =>
            !s_database.ContainsKey(module) && !IsEditor ? throw new KeyNotFoundException($"The module {module} does not have an entry.") : s_database[module].ConvertAll(d => !d.ContainsKey(key)
                ? allowDefault || IsEditor ? default(T) : throw new KeyNotFoundException($"The key {key} could not be found in the module {module}.")
                : d[key] is T t
                ? t
                : throw new UnrecognizedTypeException($"The data type {typeof(T).Name} was expected, but received {d[key]?.GetType().Name ?? "null"} from module {module} with key {key}."));
#endif

        /// <summary>
        /// Removes the module from <see cref="logMessageReceived"/>. If you declare this method, make sure to call <c>base.OnDestroy()</c> to ensure that the module cleans up correctly.
        /// </summary>
        protected void OnDestroy()
        {
            logMessageReceived -= HandleException;
            OnDestruct();
        }

        private void HandleException(string condition, string stackTrace, LogType type)
        {
            if (type != LogType.Exception || stackTrace.Split('\n').All(s => !s.StartsWith(Type.Name)))
                return;

            logMessageReceived -= HandleException;
            _hasException = true;

            OnException(condition);
        }

        private void TimerTickInner()
        {
            var timer = (TimerComponent)Timer(Bomb);

            timer.TimerTick += (elapsed, remaining) =>
            {
                TimeLeft = remaining;
                OnTimerTick();
            };
        }

        private void UseBomb()
        {
            const BindingFlags Flags = DeclaredOnly | Instance | Public;

            bool isHookingPass = Type.ImplementsMethod(nameof(OnModuleSolved), Flags),
                isHookingStrike = Type.ImplementsMethod(nameof(OnModuleStrike), Flags),
                isHookingTimer = Type.ImplementsMethod(nameof(OnTimerTick), Flags);

            Modules.ForEach(m =>
            {
                if (isHookingPass && m.IsSolvable)
                    m.Solve.Add(() => OnModuleSolved(m));

                if (isHookingStrike)
                    m.Strike.Add(() => OnModuleStrike(m));
            });

            if (!isHookingTimer)
                return;

            if (IsKtane)
                TimerTickInner();
            else
                StartCoroutine(EditorTimerTick());
        }

        private IEnumerator CheckForUpdates()
        {
            if (!isEditor || s_hasCheckedVersion)
                yield break;

            s_hasCheckedVersion = true;

            UnityWebRequest latest = PathManager.LatestGitHub;

            yield return latest.SendWebRequest();

            if (latest.isNetworkError || latest.isHttpError)
            {
                Self($"The library was unable to get the version number: {latest.error}", LogType.Warning);
                yield break;
            }

            string tagName = JObject.Parse(latest.downloadHandler.text).GetValue("tag_name").ToObject<string>();

            if (tagName.ToVersion() <= PathManager.Version)
                yield break;

            IsOutdated = true;

            Self($"The library is out of date. Latest Version: {tagName}, Local Version: {PathManager.Version}. Please press the update button on any {PathManager.AssemblyName.Name}-based {nameof(GameObject)} or download the latest version here: https://github.com/Emik03/KeepCoding/releases/latest", LogType.Warning);
        }

        private IEnumerator EditorTimerTick()
        {
            if (!GetComponent<KMBombInfo>())
            {
                Self($"Adding a {nameof(KMBombInfo)} component automatically only to capture timer ticks in the Editor.");
                gameObject.AddComponent<KMBombInfo>();
            }

            KMBombInfo bombInfo = Get<KMBombInfo>();

            while (true)
            {
                if (TimeLeft != (int)bombInfo.GetTime())
                {
                    TimeLeft = (int)bombInfo.GetTime();
                    OnTimerTick();
                }

                yield return null;
            }
        }

        private IEnumerator WaitForBomb()
        {
            yield return null;

            UseBomb();
        }

        private IEnumerator WaitForSolve()
        {
            yield return null;

            Solve();

            yield return TP?.ForceSolve();
        }
    }
}
