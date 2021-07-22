using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using KeepCoding.Internal;
using Newtonsoft.Json.Linq;
using UnityEngine;
using static KeepCoding.Game.KTInputManager;
using static KeepCoding.Game.MasterAudio;
using static KeepCoding.Logger;
using static KMAudio;
using static KMSoundOverride;
using static System.Linq.Enumerable;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes.
    /// </summary>
    public abstract partial class ModuleScript : CacheableBehaviour, IDump, ILog
    {
        /// <summary>
        /// Determines whether the module has been struck. Twitch Plays script will set this to false when a command is interrupted.
        /// </summary>
        public bool HasStruck { get; set; }

        /// <summary>
        /// Determines whether the bomb is currently active, and the timer is ticking.
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// Determines whether the module's colorblind mode is enabled.
        /// </summary>
        public bool IsColorblind
        {
            get => _colorblind.IsEnabled;
            set
            {
                if (_colorblind.IsEnabled != value)
                    OnColorblindChanged(_colorblind.IsEnabled = value);
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
        public bool IsNeedyActive { get; private set; }

        /// <summary>
        /// Determines whether the module has been solved.
        /// </summary>
        public bool IsSolved { get; private set; }

        /// <summary>
        /// Determines whether the game is being played in Virtual Reality. In the Editor, it always returns false.
        /// </summary>
        public static bool IsVR => IsCurrentControlTypeVR;

        /// <summary>
        /// The Unique Id for the module of this type.
        /// </summary>
        public int Id => _logger.Id;

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
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public string Version => IsEditor ? "Can't get Version Number in Editor" : PathManager.GetModInfo(GetType()).Version;

        /// <summary>
        /// Gets the Twitch Plays <see cref="Component"/> attached to this <see cref="GameObject"/>.
        /// </summary>
        /// <remarks>
        /// Due to type ambiguity, a non-generic interface is returned.
        /// </remarks>
        public ITP TP => _tp ??= GetComponents<Component>().FirstOrDefault(c => c is ITP) as ITP;
        private ITP _tp;

        /// <summary>
        /// The bomb that this module is in.
        /// </summary>
        public KMBomb Bomb { get; private set; }

        /// <summary>
        /// Contains either <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>, and allows for running commands through context.
        /// </summary>
        public ModuleContainer Module { get; private set; }

        /// <summary>
        /// Contains an instance for every <see cref="Sound"/> played by this module using <see cref="PlaySound(Transform, bool, Sound[])"/> or any of its overloads.
        /// </summary>
        public Sound[] Sounds { get; private set; } = new Sound[0];

        /// <summary>
        /// Contains every modded module in <see cref="Bomb"/>, separated by type.
        /// </summary>
        public ModuleContainer[] Modules { get; private set; }

        internal bool _isColorblindSupported = true;

        private bool _hasException;

        private static bool s_hasCheckedVersion;

        private int _strikes;

        private static Dictionary<string, Dictionary<string, object>[]> s_database;

        private Action _activate;

        private ColorblindInfo _colorblind;

        private Logger _logger;

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
        public void Assign(Action onActivate = null, Action onNeedyActivation = null, Action onNeedyDeactivation = null, Action onPass = null, Action onStrike = null, Action onTimerExpired = null) => Module.Assign(_activate.Combine(onActivate), onNeedyActivation.Combine(() => IsNeedyActive = true), onNeedyDeactivation.Combine(() => IsNeedyActive = false), onPass, onStrike, onTimerExpired);

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
        public void Dump<T>(T obj, bool getVariables = false) => _logger.Dump(obj, getVariables);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs) => _logger.Dump(getVariables, logs);

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs) => _logger.Dump(logs);

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        public void Log<T>(T message, LogType logType = LogType.Log) => _logger.Log(message, logType);

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => _logger.Log(message, args);

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => _logger.LogMultiple(logs);

        /// <summary>
        /// Solves the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Solve(params string[] logs)
        {
            if (IsSolved)
                return;

            if (_hasException)
                Game.AddStrikes(gameObject, -_strikes);

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
        /// Called when the lights turn on.
        /// </summary>
        public virtual void OnActivate() { }

        /// <summary>
        /// Called when colorblind support needs to be updated for the module. Do not call <c>base.OnColorblindChanged()</c>.
        /// </summary>
        /// <param name="isEnabled">Whether colorblind support should be enabled.</param>
        public virtual void OnColorblindChanged(bool isEnabled) => _isColorblindSupported = false;

        /// <summary>
        /// Called when any module on the current bomb has issued a strike.
        /// </summary>
        /// <remarks>
        /// Vanilla modules are an exception, they will not invoke this method.
        /// </remarks>
        /// <param name="moduleName">The sender's module name, which caused a strike.</param>
        public virtual void OnModuleStrike(string moduleName) { }

        /// <summary>
        /// Called when any <see cref="KMNeedyModule"/> on the current bomb has been solved.
        /// </summary>
        /// <remarks>
        /// Vanilla modules are an exception, they will not invoke this method.
        /// </remarks>
        /// <param name="moduleName">The sender's module name, which was solved.</param>
        public virtual void OnNeedySolved(string moduleName) { }

        /// <summary>
        /// Called when any <see cref="KMBombModule"/> on the current bomb has been solved.
        /// </summary>
        /// <remarks>
        /// Vanilla modules are an exception, they will not invoke this method.
        /// </remarks>
        /// <param name="moduleName">The sender's module name, which was solved.</param>
        public virtual void OnSolvableSolved(string moduleName) { }

        /// <summary>
        /// Called when the timer's seconds-digit changes.
        /// </summary>
        public virtual void OnTimerTick() { }

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

            Range(0, index - s_database[Module.Id].Length + 1).ToArray().ForEach(_ => s_database[Module.Id].Append(new Dictionary<string, object>()));

            if (!s_database[Module.Id][index].ContainsKey(key))
                s_database[Module.Id][index].Add(key, null);

            s_database[Module.Id][index][key] = value;

            if (IsEditor)
                Self($"Added \"{value}\" to {nameof(s_database)}: [{nameof(Module.Id)}, {Module.Id}: [{nameof(index)}, {index}: {value}]]");
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
                throw Gets<KMAudio>().IsNullOrEmpty() ? (Exception)new MissingComponentException($"A sound cannot be played when there is no {nameof(KMAudio)} component!") : new InvalidOperationException($"There is more than one {nameof(KMAudio)} component! This is considered a mistake because the game will only add the sounds to one of the {nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned!");

            sounds = sounds.Where(s =>
            {
                if (s.Custom is null || IsGroupInfo($"{PathManager.GetModInfo(GetType()).Id}_{s.Custom}"))
                    s.Reference = s.Method(Get<KMAudio>())(transform, loop);

                else
                    Log($"The sound \"{s.Custom}\" was attempted to be played but there is no corresponding {nameof(AudioClip)} found in the bundle! Check for misspellings, ensure that there is a singular {nameof(KMAudio)} component, and make sure the audio clip being played has a mod.bundle tag.", LogType.Error);

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
        public static T[] Read<T>(string module, string key, bool allowDefault = false) =>
            !s_database.ContainsKey(module) && !IsEditor ? throw new KeyNotFoundException($"The module {module} does not have an entry!") : s_database[module].ConvertAll(d => !d.ContainsKey(key)
                ? allowDefault || IsEditor ? default(T) : throw new KeyNotFoundException($"The key {key} could not be found in the module {module}!")
                : d[key] is T t
                ? t
                : throw new UnrecognizedTypeException($"The data type {typeof(T).Name} was expected, but received {d[key].GetType()} from module {module} with key {key}!"));

        /// <summary>
        /// Sets up the module. If you declare this method, make sure to call <c>base.Awake()</c> to ensure that the module initializes correctly.
        /// </summary>
        protected void Awake()
        {
            (Module = new ModuleContainer(this)).OnActivate(_activate = () =>
            {
                IsActive = true;
                OnActivate();
            });

            Self($"The module \"{Module.Name}\" ({Module.Id}) uses KeepCoding version {PathManager.Version}.");

            _logger = new Logger(Module.Name, true);

            logMessageReceived += OnException;

            _colorblind = new ColorblindInfo(this);

            s_database = new Dictionary<string, Dictionary<string, object>[]>();

            Log($"Version: [{Version.NullOrEmptyCheck("The version number is empty! To fix this, go to Keep Talking ModKit -> Configure Mod, then fill in the version number.")}]");

            StartCoroutine(CheckForUpdates());
            StartCoroutine(WaitForBomb());
        }

        /// <summary>
        /// Removes the module from <see cref="logMessageReceived"/>. If you declare this method, make sure to call <c>base.OnDestroy()</c> to ensure that the module cleans up correctly.
        /// </summary>
        protected void OnDestroy() => logMessageReceived -= OnException;

        private void HookModules()
        {
            static bool Run(ModuleContainer module, Action<string> action)
            {
                action(module.Name);
                return false;
            }

            KMBombModule[] solvables = Bomb.GetComponentsInChildren<KMBombModule>();
            KMNeedyModule[] needies = Bomb.GetComponentsInChildren<KMNeedyModule>();

            Modules = solvables.ConvertAll(m => new ModuleContainer(m, null)).Concat(needies.ConvertAll(m => new ModuleContainer(null, m))).ToArray();

            Self($"Subscribing current bomb's {Modules.Length} module(s) to {nameof(OnSolvableSolved)}, {nameof(OnNeedySolved)}, and {nameof(OnModuleStrike)}.");

            solvables.ForEach(m =>
            {
                m.OnPass += () => Run(m, OnSolvableSolved);
                m.OnStrike += () => Run(m, OnModuleStrike);
            });

            needies.ForEach(m =>
            {
                m.OnPass += () => Run(m, OnNeedySolved);
                m.OnStrike += () => Run(m, OnModuleStrike);
            });
        }

        private void OnException(string condition, string stackTrace, LogType type)
        {
            void ForceSolve()
            {
                StartCoroutine(WaitForSolve());
                Get<KMSelectable>().OnInteract = null;
            }

            if (type != LogType.Exception || !IsLogFromThis(stackTrace))
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
            var timer = (TimerComponent)Game.Timer(gameObject);

            timer.TimerTick += (elapsed, remaining) =>
            {
                TimeLeft = remaining;
                OnTimerTick();
            };
        }

        private bool IsLogFromThis(in string stackTrace) => stackTrace.Split('\n').Any(s => Regex.IsMatch(s, $@"^{GetType().Name}"));

        private static uint VersionToNumber(in string s) => uint.Parse(s.Replace(".", "").PadRight(9, '0'));

        private static IEnumerator CheckForUpdates()
        {
            if (!IsEditor || s_hasCheckedVersion)
                yield break;

            s_hasCheckedVersion = true;

            var www = new WWW("https://api.github.com/repos/Emik03/KeepCoding/releases/latest");
            yield return www;

            if (www.error is { })
            {
                Self($"The library was unable to get the version number: {www.error}", LogType.Warning);
                yield break;
            }

            string tagName = JObject.Parse(www.text).GetValue("tag_name").ToObject<string>();

            if (tagName.ToVersion() > PathManager.Version)
                Self($"The library is out of date! Latest Version: {tagName}, Local Version: {PathManager.Version}. Please download the latest version here: https://github.com/Emik03/KeepCoding/releases/latest", LogType.Warning);
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
            do
            {
                Bomb = GetComponentInParent<KMBomb>();
                yield return null;
            }
            while (!Bomb);

            Self($"{nameof(KMBomb)} located.");

            HookModules();

            if (IsEditor)
            {
                StartCoroutine(EditorTimerTick());
                yield break;
            }

            TimerTickInner();
        }

        private IEnumerator WaitForSolve()
        {
            yield return new WaitWhile(() => Get<KMBombModule>(allowNull: true)?.OnPass is null && Get<KMNeedyModule>(allowNull: true)?.OnPass is null);

            Solve();

            yield return TP?.ForceSolve();
        }
    }
}
