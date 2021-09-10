using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using KeepCoding.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;
using static System.Delegate;
using static System.Linq.Enumerable;
using static System.Reflection.BindingFlags;
using static System.String;
using static KeepCoding.Game;
using static KeepCoding.Game.KTInputManager;
using static KeepCoding.Game.MasterAudio;
using static KeepCoding.Game.References;
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
    public abstract class ModuleScript : CacheableBehaviour, IDump, ILog
    {
        private bool _hasException;

        private static bool s_hasCheckedVersion;

        [SerializeField]
#pragma warning disable 649, IDE0044 // Add readonly modifier
        private int _ruleSeedId = 1;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        private int _strikes;

        private static Dictionary<string, Dictionary<string, object>[]> s_database = new Dictionary<string, Dictionary<string, object>[]>();

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

        /// <summary>
        /// Determines whether the application is running from inside unity.
        /// </summary>
        public static bool IsEditor => isEditor;

        /// <summary>
        /// Determines whether this module is the last instantiated instance.
        /// </summary>
        public bool IsLastInstantiated => Id == LastId;

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
        /// The version number of the entire mod.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        public string Version => PathManager.GetModInfo(Name).Version.NullOrEmptyCheck("The version number is empty. To fix this, go to Keep Talking ModKit -> Configure Mod, then fill in the version number.");

        /// <summary>
        /// The ignored modules of this module from the Boss Module Manager.
        /// </summary>
        public string[] IgnoredModules => _ignoredModules ??= GetIgnoredModules(Module.Name);
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
        /// Note that this variable is not available on <see cref="Awake"/> or <see cref="OnAwake"/>. A small amount of time is needed for this property to be set.
        /// </remarks>
        public KMBomb Bomb { get; private set; }

        /// <summary>
        /// Contains either <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>, and allows for running commands through context.
        /// </summary>
        public ModuleContainer Module => _module ??= new ModuleContainer(this);
        private ModuleContainer _module;

        /// <summary>
        /// Contains every modded module in <see cref="Bomb"/>, separated by type.
        /// </summary>
        public ModuleContainer[] Modules { get; private set; }

        /// <summary>
        /// The pseudo-random number generator whose number generations are based on the current Rule Seed.
        /// </summary>
        public MonoRandom RuleSeed => _ruleSeed ??= new MonoRandom(GetRuleSeedId());
        private MonoRandom _ruleSeed;

        /// <summary>
        /// Contains an instance for every <see cref="Sound"/> played by this module using <see cref="PlaySound(Transform, bool, Sound[])"/> or any of its overloads.
        /// </summary>
        public Sound[] Sounds { get; private set; } = new Sound[0];

        internal bool IsColorblindSupported => Type.ImplementsMethod(nameof(OnColorblindChanged), DeclaredOnly | Instance | Public);

        internal static bool IsOutdated { get; private set; }

        private string Name => _name ??= Type.NameOfAssembly();
        private string _name;

        private Logger Logger => _logger ??= new Logger(Module.Name, true);
        private Logger _logger;

        private Type Type => _type ??= GetType();
        private Type _type;

        /// <summary>
        /// Assigns events specified into <see cref="Module"/>. Reassigning them will replace their values.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.
        /// </remarks>
        /// <param name="onActivate">Called when the lights turn on.</param>
        /// <param name="onNeedyActivation">Called when the needy activates.</param>
        /// <param name="onNeedyDeactivation">Called when the needy deactivates.</param>
        /// <param name="onPass">Called when the needy is solved.</param>
        /// <param name="onStrike">Called when the needy strikes.</param>
        /// <param name="onTimerExpired">Called when the timer runs out of time.</param>
        public void Assign(Action onActivate = null, Action onNeedyActivation = null, Action onNeedyDeactivation = null, Action onPass = null, Action onStrike = null, Action onTimerExpired = null) => Module.Assign(onActivate.Combine(() =>
        {
            OnActivate();
            IsActive = true;
        }), onNeedyActivation.Combine(() =>
        {
            OnNeedyActivate();
            _isNeedyActive = true;
        }), onNeedyDeactivation.Combine(() =>
        {
            OnNeedyDeactivate();
            _isNeedyActive = false;
        }), onPass, onStrike, onTimerExpired.Combine(() =>
        {
            OnNeedyDeactivate();
            _isNeedyActive = false;
        }));

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
            selectable.Assert("Selectable should not be null when calling this method.").AddInteractionPunch(intensityModifier);

            PlaySound(selectable.transform, sounds);
        }

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

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => Logger.LogMultiple(logs);

        /// <summary>
        /// Called when the module instantiates, well before the lights turn on.
        /// </summary>
        public virtual void OnAwake() { }

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
                AddStrikes(gameObject, -_strikes, false);

            LogMultiple(logs);

            IsSolved = true;
            Module.Solve();
        }

        /// <summary>
        /// Strikes the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Strike(params string[] logs)
        {
            if (_hasException)
                return;

            LogMultiple(logs);

            HasStruck = true;
            _strikes++;

            Module.Strike();
        }

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

        /// <summary>
        /// Gets the rule seed number.
        /// </summary>
        /// <returns>The rule seed number, by default 1.</returns>
        public int GetRuleSeedId()
        {
            int standard = isEditor ? _ruleSeedId : 1;

            var ruleSeedObject = GameObject.Find("RuleSeedModifierProperties");

            if (ruleSeedObject is null)
                return standard;

            IDictionary<string, object> ruleSeedDictionary = ruleSeedObject.GetComponent<IDictionary<string, object>>();

            if (!ruleSeedDictionary.ContainsKey("RuleSeed"))
                return standard;

            if (ruleSeedDictionary.ContainsKey("AddSupportedModule"))
                ruleSeedDictionary["AddSupportedModule"] = Module.Id;

            return (ruleSeedDictionary["RuleSeed"] as int?) ?? standard;
        }

        /// <summary>
        /// Retrieves the ignore list from the Boss Module Manager mod used primarily by boss modules.
        /// </summary>
        /// <param name="moduleName">The name of the module to retrieve from.</param>
        /// <returns>If successful, the boss module's ignore list, otherwise a new empty string array.</returns>
        public string[] GetIgnoredModules(string moduleName)
        {
            if (isEditor)
                return new string[0];

            var managerObject = GameObject.Find("BossModuleManager");

            var logger = new Logger("KMBossModule");

            if (managerObject is null)
            {
                logger.Log("Boss Module Manager is not installed.");
                return new string[0];
            }

            IDictionary<string, object> dictionary = managerObject.GetComponent<IDictionary<string, object>>();

            const string Key = "GetIgnoredModules";

            if (dictionary is null || !dictionary.ContainsKey(Key))
            {
                logger.Log($"Boss Module Manager does not have a list on record for “{Module.Name}”.");
                return new string[0];
            }

            string[] list = ((Func<string, string[]>)dictionary[Key])(moduleName);

            logger.Log($"Boss Module Manager returned list for “{moduleName}”: {(list is null ? Helper.Null : Join(", ", list))}");
            return list ?? new string[0];
        }

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="MissingComponentException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, bool loop, params Sound[] sounds)
        {
            sounds.NullOrEmptyCheck($"{nameof(sounds)} is null or empty.");

            if (Gets<KMAudio>().Length != 1)
                throw Gets<KMAudio>().IsNullOrEmpty() ? (Exception)new MissingComponentException($"A sound cannot be played when there is no {nameof(KMAudio)} component.") : new InvalidOperationException($"There is more than one {nameof(KMAudio)} component. This is considered a mistake because the game will only add the sounds to one of the {nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned.");

            sounds = sounds.Where(s =>
            {
                if (s.Custom is null || IsGroupInfo(Name, s.Custom))
                    s.Reference = s.Method(Get<KMAudio>())(transform, loop);

                else
                    Log($"The sound \"{s.Custom}\" was attempted to be played but there is no corresponding {nameof(AudioClip)} found in the bundle. Check for misspellings, ensure that there is a singular {nameof(KMAudio)} component, and make sure the audio clip being played has a mod.bundle tag.", LogType.Error);

                return s.Reference is { };
            }).ToArray();

            Sounds = Sounds.Concat(sounds).ToArray();

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

        /// <summary>
        /// Sets up base functionality for the module. If you declare this method yourself, make sure to call <c>base.Awake()</c> to ensure that the module initializes correctly, or use <see cref="OnAwake"/> instead.
        /// </summary>
        protected void Awake()
        {
            logMessageReceived += OnException;

            s_database = new Dictionary<string, Dictionary<string, object>[]>();

            Self($"The module \"{Module.Name}\" ({Module.Id}) uses KeepCoding version {PathManager.Version}.");
            Log($"Version: [{Version}]");

            Assign();
            OnAwake();

            StartCoroutine(CheckForUpdates());
            StartCoroutine(WaitForBomb());
        }

        /// <summary>
        /// Removes the module from <see cref="logMessageReceived"/>. If you declare this method, make sure to call <c>base.OnDestroy()</c> to ensure that the module cleans up correctly.
        /// </summary>
        protected void OnDestroy()
        {
            logMessageReceived -= OnException;
            OnDestruct();
        }

        private void HookModules(bool isHookingPass, bool isHookingStrike)
        {
            static bool Run(ModuleContainer module, Action<ModuleContainer> action)
            {
                action(module);
                return false;
            }

            if (!isHookingPass && !isHookingStrike)
                return;

            KMBombModule[] solvables = Bomb.GetComponentsInChildren<KMBombModule>();
            KMNeedyModule[] needies = Bomb.GetComponentsInChildren<KMNeedyModule>();

            Modules = solvables
                .ConvertAll(m => (ModuleContainer)m)
                .Concat(needies.ConvertAll(m => (ModuleContainer)m))
                .ToArray();

            solvables.ForEach(m =>
            {
                if (isHookingPass)
                    m.OnPass += () => Run(m, OnModuleSolved);

                if (isHookingStrike)
                    m.OnStrike += () => Run(m, OnModuleStrike);
            });

            needies.ForEach(m => m.OnStrike += () => Run(m, OnModuleStrike));
        }

        private void HookVanillas(bool isHookingPass, bool isHookingStrike)
        {
            if (!isHookingPass && !isHookingStrike)
                return;

            const BindingFlags Flags = DeclaredOnly | Instance | NonPublic;

            MethodInfo passMethod = typeof(ModuleScript).GetMethod(nameof(VanillaSolve), Flags),
                strikeMethod = typeof(ModuleScript).GetMethod(nameof(VanillaStrike), Flags);

            var passEvent = (PassEvent)CreateDelegate(typeof(PassEvent), this, passMethod);
            var strikeEvent = (StrikeEvent)CreateDelegate(typeof(StrikeEvent), this, strikeMethod);

            foreach (object vanilla in Vanillas(Bomb))
            {
                var bomb = (BombComponent)vanilla;

                if (isHookingPass && !(bomb is NeedyComponent))
                    bomb.OnPass += passEvent;

                if (isHookingStrike)
                    bomb.OnStrike += strikeEvent;
            }
        }

        private void OnException(string condition, string stackTrace, LogType type)
        {
            void ForceSolve()
            {
                StartCoroutine(WaitForSolve());
                Get<KMSelectable>().OnInteract = null;
            }

            if (type != LogType.Exception || stackTrace.Split('\n').All(s => !s.StartsWith(Type.Name)))
                return;

            logMessageReceived -= OnException;
            _hasException = true;

            Log("The module threw an unhandled exception... {0}", condition);

            if (TP?.IsTP ?? false)
                return;

            if (Get<KMSelectable>(allowNull: true))
                Get<KMSelectable>().Assign(onInteract: ForceSolve);
            else
                ForceSolve();
        }

        private void TimerTickInner()
        {
            var timer = (TimerComponent)Timer(gameObject);

            timer.TimerTick += (elapsed, remaining) =>
            {
                TimeLeft = remaining;
                OnTimerTick();
            };
        }

        private bool VanillaSolve(MonoBehaviour c)
        {
            OnModuleSolved(new ModuleContainer(c));
            return false;
        }

        private bool VanillaStrike(MonoBehaviour c)
        {
            OnModuleStrike(new ModuleContainer(c));
            return false;
        }

        private IEnumerator CheckForUpdates()
        {
            if (!IsEditor || s_hasCheckedVersion)
                yield break;

            s_hasCheckedVersion = true;

            using UnityWebRequest latest = PathManager.LatestGitHub;

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

            Bomb = GetParent<KMBomb>();

            const BindingFlags Flags = DeclaredOnly | Instance | Public;

            bool isHookingPass = Type.ImplementsMethod(nameof(OnModuleSolved), Flags),
                isHookingStrike = Type.ImplementsMethod(nameof(OnModuleStrike), Flags),
                isHookingTimer = Type.ImplementsMethod(nameof(OnTimerTick), Flags);

            HookModules(isHookingPass, isHookingStrike);

            if (Reference is Ktane)
            {
                if (isHookingTimer)
                    TimerTickInner();

                HookVanillas(isHookingPass, isHookingStrike);

                yield break;
            }

            if (isHookingTimer)
                StartCoroutine(EditorTimerTick());
        }

        private IEnumerator WaitForSolve()
        {
            yield return new WaitWhile(() => Get<KMBombModule>(allowNull: true)?.OnPass is null && Get<KMNeedyModule>(allowNull: true)?.OnPass is null);

            Solve();

            yield return TP?.ForceSolve();
        }
    }
}
