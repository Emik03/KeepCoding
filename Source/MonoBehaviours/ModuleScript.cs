using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using static KeepCoding.Game.KTInputManager;
using static KMAudio;
using static KMSoundOverride;
using static UnityEngine.Application;

namespace KeepCoding
{
    /// <summary>
    /// Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.
    /// </summary>
#pragma warning disable IDE1006 // Naming Styles
    public abstract class ModuleScript : MonoBehaviour, IDump, ILog
#pragma warning restore IDE1006 // Naming Styles
    {
        /// <value>
        /// Determines whether the module has been struck. Twitch Plays script will set this to false when a command is interrupted.
        /// </value>
        public bool HasStruck { get; set; }

        /// <value>
        /// Determines whether the bomb is currently active, and the timer is ticking.
        /// </value>
        public bool IsActive { get; private set; }

        /// <value>
        /// Determines whether the application is running from inside unity.
        /// </value>
        public static bool IsEditor => isEditor;

        /// <value>
        /// Determines whether this module is the last instantiated instance.
        /// </value>
        public bool IsLastInstantiated => Id == LastId;

        /// <value>
        /// Determines whether the needy is active.
        /// </value>
        public bool IsNeedyActive { get; private set; }

        /// <value>
        /// Determines whether the module has been solved.
        /// </value>
        public bool IsSolved { get; private set; }

        /// <value>
        /// Determines whether the game is being played in Virtual Reality. In the Editor, it always returns false.
        /// </value>
        public static bool IsVR => IsCurrentControlTypeVR;

        /// <value>
        /// The Unique Id for the module of this type.
        /// </value>
        public int Id => _logger.Id;

        /// <summary>
        /// The last Id instantiation for the module of this type.
        /// </summary>
        public int LastId => Logger.ids[Module.Name];

        /// <value>
        /// The amount of time left on the bomb, in seconds, rounded down.
        /// </value>
        public int TimeLeft { get; private set; }

        /// <value>
        /// The version number of the entire mod.
        /// </value>
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public string Version => IsEditor ? "Can't get Version Number in Editor" : PathManager.GetModInfo(GetType()).Version;

        /// <value>
        /// Gets the Twitch Plays <see cref="Component"/> attached to this <see cref="GameObject"/>.
        /// </value>
        /// <remarks>
        /// Due to type ambiguity, a non-generic interface is returned.
        /// </remarks>
        public ITP TP => _tp ??= GetComponents<Component>().FirstOrDefault(c => c is ITP) as ITP;
        private ITP _tp;

        /// <value>
        /// The bomb that this module is in.
        /// </value>
        public KMBomb Bomb { get; private set; }

        /// <value>
        /// Contains either <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>, and allows for running commands through context.
        /// </value>
        public ModuleContainer Module { get; private set; }

        /// <value>
        /// Contains an instance for every <see cref="Sound"/> played by this module using <see cref="PlaySound(Transform, bool, Sound[])"/> or any of its overloads.
        /// </value>
        public Sound[] Sounds { get; private set; } = new Sound[0];
        
        /// <summary>
        /// Contains every modded module in <see cref="Bomb"/>, separated by type.
        /// </summary>
        public ModuleContainer[] Modules { get; private set; }

        private bool _hasException;

        private int _strikes;

        private static Dictionary<string, Dictionary<string, object>[]> _database;

        private readonly Dictionary<Type, Component[]> _components = new Dictionary<Type, Component[]>();

        private Action _setActive;

        private Logger _logger;

        /// <summary>
        /// This initalizes the module. If you have an Awake method, be sure to call <c>base.Awake()</c> as the first statement.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        protected void Awake()
        {
            (Module = new ModuleContainer(this)).OnActivate(_setActive = () => 
            {
                IsActive = true;
                OnActivate();
            });

            Logger.Self($"The module \"{Module.Name}\" ({Module.Id}) uses KeepCoding version {PathManager.Version}.");

            _logger = new Logger(Module.Name, true);

            Logger.Self($"Subscribing {Module.Name}'s {nameof(OnException)} to {nameof(logMessageReceived)}.");

            logMessageReceived += OnException;

            _database = new Dictionary<string, Dictionary<string, object>[]>();

            Log($"Version: [{Version.NullOrEmptyCheck("The version number is empty! To fix this, go to Keep Talking ModKit -> Configure Mod, then fill in the version number.")}]");
            
            StartCoroutine(EditorCheckLatest());
            StartCoroutine(WaitForBomb());
        }

        /// <summary>
        /// This removed the exception catcher. If you have an OnDestroy method, be sure to call <c>base.OnDestroy()</c> as the first statement.
        /// </summary>
        protected void OnDestroy()
        {
            Logger.Self($"Unsubscribing {Module.Name}'s {nameof(OnException)} to {nameof(logMessageReceived)}.");
            logMessageReceived -= OnException;
        }

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
        public void Assign(Action onActivate = null, Action onNeedyActivation = null, Action onNeedyDeactivation = null, Action onPass = null, Action onStrike = null, Action onTimerExpired = null) => Module.Assign(_setActive.Combine(onActivate), onNeedyActivation.Combine(() => IsNeedyActive = true), onNeedyDeactivation.Combine(() => IsNeedyActive = false), onPass, onStrike, onTimerExpired);

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
            if (!_database.ContainsKey(Module.Id))
                _database.Add(Module.Id, new Dictionary<string, object>[] { });

            int index = LastId - Id;

            Enumerable.Range(0, index - _database[Module.Id].Length + 1).ToArray().ForEach(i => _database[Module.Id].Append(new Dictionary<string, object>()));

            if (!_database[Module.Id][index].ContainsKey(key))
                _database[Module.Id][index].Add(key, null);

            _database[Module.Id][index][key] = value;

            if (IsEditor)
                Logger.Self($"Added \"{value}\" to {nameof(_database)}: [{nameof(Module.Id)}, {Module.Id}: [{nameof(index)}, {index}: {value}]]");
        }

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, bool loop, params Sound[] sounds)
        {
            sounds.NullOrEmptyCheck($"{nameof(sounds)} is null or empty.");

            sounds = sounds.Where(s => (s.Reference = s.Method(Get<KMAudio>())(transform, loop)) is { }).ToArray();

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
        /// Similar to <see cref="Component.GetComponent{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Get<T>(bool allowNull = false) where T : Component => GetAll<T>(allowNull).FirstOrDefault();

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <remarks>
        /// <see cref="GameObject.GetComponent{T}"/> and <see cref="GameObject.GetComponents{T}()"/> have their own implementations already, so use these functions instead for that purpose; 
        /// <seealso cref="Get{T}(bool)"/>, <seealso cref="GetAll{T}(bool)"/>
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T[] Cache<T>(Func<T[]> func, bool allowNull = false) where T : Component
        {
            if (!_components.ContainsKey(typeof(T)))
                _components.Add(typeof(T), func());

            return allowNull || !_components[typeof(T)].IsNullOrEmpty() ? (T[])_components[typeof(T)] : throw new MissingComponentException($"Tried to get component {typeof(T).Name} from {this}, but was unable to find one.");
        }

        /// <summary>
        /// Similar to <see cref="GameObject.GetComponents{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] GetAll<T>(bool allowNull = false) where T : Component => Cache(() => GetComponents<T>(), allowNull);

        /// <summary>
        /// Allows you to read a module's data that uses <see cref="Write{T}(string, T)"/>, even from a different assembly.
        /// </summary>
        /// <remarks>
        /// To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.
        /// </remarks>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="WrongDatatypeException"></exception>
        /// <typeparam name="T">The type of the expected output.</typeparam>
        /// <param name="module">The module to look into.</param>
        /// <param name="key">The key of the variable, a lot like a variable name.</param>
        /// <param name="allowDefault">Whether it should throw an exception if no value is found, or provide the default value instead.</param>
        /// <returns>Every instance of the value from the every instance of the module specified.</returns>
        public static T[] Read<T>(string module, string key, bool allowDefault = false) =>
            !_database.ContainsKey(module) && !IsEditor ? throw new KeyNotFoundException($"The module {module} does not have an entry!") : _database[module].ConvertAll(d => !d.ContainsKey(key)
                ? allowDefault || IsEditor ? default(T) : throw new KeyNotFoundException($"The key {key} could not be found in the module {module}!")
                : d[key] is T t
                ? t
                : throw new WrongDatatypeException($"The data type {typeof(T).Name} was expected, but received {d[key].GetType()} from module {module} with key {key}!"));

        private static IEnumerator EditorCheckLatest()
        {
            if (!IsEditor)
                yield break;

            WWW www = new WWW("https://api.github.com/repos/Emik03/KeepCoding/releases/latest");
            yield return www;

            if (www.error is { })
            {
                Logger.Self($"The library was unable to get the version number: {www.error}");
                yield break;
            }

            string tagName = JObject.Parse(www.text).GetValue("tag_name").ToObject<string>();

            if (tagName.ToVersion() > PathManager.Version)
                Logger.Self($"The library is out of date! Latest Version: {tagName}, Local Version: {PathManager.Version}. Please download the latest version here: https://github.com/Emik03/KeepCoding/releases/latest", LogType.Warning);
        }

        private void HookModules()
        {
            static bool Run(ModuleContainer module, Action<string> action)
            {
                action(module.Name);
                return false;
            }

            var solvables = Bomb.GetComponentsInChildren<KMBombModule>();
            var needies = Bomb.GetComponentsInChildren<KMNeedyModule>();

            Modules = solvables.ConvertAll(m => new ModuleContainer(m, null)).Concat(needies.ConvertAll(m => new ModuleContainer(null, m))).ToArray();

            Logger.Self($"Subscribing current bomb's {Modules.Length} module(s) to {nameof(OnSolvableSolved)}, {nameof(OnNeedySolved)}, and {nameof(OnModuleStrike)}.");

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
            if (type != LogType.Exception || !IsLogFromThis(stackTrace))
                return;

            logMessageReceived -= OnException;
            _hasException = true;

            Log("The module threw an unhandled exception... {0}", condition);

            if (!(bool)(TP?.IsTP)) 
            {
                if (Get<KMSelectable>(allowNull: true))
                    Get<KMSelectable>().Assign(onInteract: () => 
                    {
                        StartCoroutine(WaitForSolve());
                        Get<KMSelectable>().OnInteract = null;
                    });
                else
                    StartCoroutine(WaitForSolve());
            }
        }

        private void TimerTick()
        {
            var timer = (TimerComponent)Game.Timer(gameObject);

            timer.TimerTick += (elapsed, remaining) =>
            {
                TimeLeft = remaining;
                OnTimerTick();
            };
        }

        private bool IsLogFromThis(string stackTrace) => stackTrace.Split('\n').Any(s => Regex.IsMatch(s, @$"^{GetType().Name}"));

        private static uint VersionToNumber(string s) => uint.Parse(s.Replace(".", "").PadRight(9, '0'));

        private IEnumerator EditorTimerTick()
        {
            if (!GetComponent<KMBombInfo>())
            {
                Logger.Self($"Adding a {nameof(KMBombInfo)} component automatically only to capture timer ticks in the Editor.");
                gameObject.AddComponent<KMBombInfo>();
            }

            var bombInfo = Get<KMBombInfo>();

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

            Logger.Self($"{nameof(KMBomb)} located.");

            HookModules();

            if (IsEditor)
            {
                StartCoroutine(EditorTimerTick());
                yield break;
            }

            TimerTick();
        }

        private IEnumerator WaitForSolve()
        {
            yield return new WaitWhile(() => Get<KMBombModule>(allowNull: true)?.OnPass is null && Get<KMNeedyModule>(allowNull: true)?.OnPass is null);

            Solve();

            yield return TP?.TwitchHandleForcedSolve();
        }
    }
}
