using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Networking;
using static KMAudio;


namespace KeepCoding.v13
{
    /// <summary>
    /// Base class for regular and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.
    /// </summary>
    public abstract class ModuleScript : MonoBehaviour
    {
        /// <summary>
        /// Called when the lights turn on.
        /// </summary>
        protected virtual void OnActivate() { }

        /// <summary>
        /// Called when the timer's seconds-digit changes.
        /// </summary>
        protected virtual void OnTimerTick() { }

        /// <value>
        /// Determines whether the bomb is currently active, and the timer is ticking.
        /// </value>
        public bool IsActive { get; private set; }

        /// <value>
        /// Determines whether it is running on Unity or in-game.
        /// </value>
        public bool IsEditor => Application.isEditor;

        /// <value>
        /// Determines whether this module is the last instantiated instance.
        /// </value>
        public bool IsLastInstantiated => ModuleId == _moduleIds[Module.ModuleType];

        /// <value>
        /// Determines whether the module has been solved.
        /// </value>
        public bool IsSolved { get; private set; }

        /// <value>
        /// Determines whether the module has been struck. Twitch Plays script will set this to false when a command is interrupted.
        /// </value>
        public bool IsStrike { get; internal set; }

        /// <value>
        /// Determines whether the needy is active.
        /// </value>
        public bool IsNeedyActive { get; private set; }

        /// <value>
        /// The Unique Id for this module of this type.
        /// </value>
        public int ModuleId { get; private set; }

        /// <value>
        /// The amount of time left on the bomb, in seconds, rounded down.
        /// </value>
        public int TimeLeft { get; private set; }

        /// <summary>
        /// The name of the bundle. This is required for the version number.
        /// </summary>
        public string ModBundleName;

        /// <value>
        /// The version number of the entire mod. Requires instance of <see cref="ModBundleName"/>.
        /// </value>
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public string Version { get => (IsEditor ? "Can't get Version Number in Editor" : PathManager.GetModInfo(ModBundleName).Version) ?? throw new OperationCanceledException($"{nameof(ModBundleName)} couldn't be found. Did you spell your Mod name correctly? Refer to this link for more details: https://github.com/Emik03/KeepCoding/wiki/Chapter-2.1:-ModuleScript#version-string"); }

        /// <value>
        /// Contains an instance for every sound played by this module using <see cref="PlaySound(Transform, bool, Sound[])"/> or any of its overloads.
        /// </value>
        public Sound[] Sounds { get; private set; } = new Sound[0];

        /// <summary>
        /// Contains either <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>, and allows for running commands through context.
        /// </summary>
        public ModuleContainer Module { get; private set; }

        /// <summary>
        /// These values are set by the Twitch Plays mod using reflection.
        /// </summary>
        protected bool TimeModeActive, TwitchPlaysActive, TwitchPlaysSkipTimeAllowed, TwitchShouldCancelCommand, ZenModeActive;

        private static readonly Dictionary<string, int> _moduleIds = new Dictionary<string, int>();

        private Action _setActive;

        private Dictionary<Type, Component[]> _components;

        /// <summary>
        /// This initalizes the module. If you have an Awake method, be sure to call <c>base.Awake()</c> as the first statement.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        protected void Awake()
        {
            if (ModBundleName.IsNullOrEmpty())
                throw new FormatException("The public field \"ModBundleName\" is empty! This means that when compiled it won't be able to run! Please set this field to your Mod ID located at Keep Talking ModKit -> Configure Mod. Refer to this link for more details: https://github.com/Emik03/KeepCoding/wiki/Chapter-2.1:-ModuleScript#version-string");

            _setActive = () => IsActive = true;

            _components = new Dictionary<Type, Component[]>() { { typeof(ModuleScript), new[] { this } } };
         
            Module = new ModuleContainer(Get<KMBombModule>(), Get<KMNeedyModule>());

            ModuleId = _moduleIds.SetOrReplace(Module.ModuleType, i => ++i);

            Assign(onActivate: () => { OnActivate(); _setActive(); });

            if (Get<KMBombInfo>(allowNull: true) is KMBombInfo bombInfo)
                StartCoroutine(TimeUpdate(bombInfo));

            if (IsEditor)
                StartCoroutine(CheckForUpdate());

            Log($"Version: [{Version.NullCheck("The version number ended up being null. This is a bug caused by the library, please file a bug report alongside the source code.", true)}]");
        }

        /// <summary>
        /// Assigns events specified into <see cref="KMBombModule"/> or <see cref="KMNeedyModule"/>. Reassigning them will replace their values.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.
        /// </remarks>
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <param name="onActivate">Called when the bomb has been activated and the timer has started.</param>
        /// <param name="onNeedyActivation">Called when the needy timer activates.</param>
        /// <param name="onNeedyDeactivation">Called when the needy gets solved or the bomb explodes.</param>
        /// <param name="onTimerExpired">Called when the timer of the needy runs out.</param>
        public void Assign(Action onActivate = null, Action onNeedyActivation = null, Action onNeedyDeactivation = null, Action onTimerExpired = null)
        {
            Module.OnActivate(onActivate + _setActive);

            if (Module.Module is KMNeedyModule)
                AssignNeedy(onTimerExpired, onNeedyActivation, onNeedyDeactivation);
        }

        /// <summary>
        /// Handles typical button <see cref="KMSelectable.OnInteract"/> behaviour.
        /// </summary>
        /// <exception cref="UnassignedReferenceException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="selectable">The selectable, which is used as a source for sound and bomb shake.</param>
        /// <param name="intensityModifier">The intensity of the bomb shaking.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="KMSoundOverride.SoundEffect"/>.</param>
        public void ButtonEffect(KMSelectable selectable, float intensityModifier = 0, params Sound[] sounds)
        {
            if (selectable is null)
                throw new UnassignedReferenceException("Selectable should not be null when calling this method.");

            selectable.AddInteractionPunch(intensityModifier);

            PlaySound(selectable.transform, sounds);
        }

        /// <summary>
        /// Dumps all information that it can find of the module using reflection. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        public void Dump(bool getVariables = false)
        {
            int index = 0;

            string Format(string name, object value) => Helper.VariableTemplate.Form(index++, name, value?.GetType().ToString() ?? Helper.Null, string.Join(", ", value.Unwrap(getVariables).Select(o => o.ToString()).ToArray()));

            var type = GetType();
            var values = new List<object>();

            type.GetFields(Helper.Flags).ForEach(f => values.Add(Format(f.Name, f.GetValue(this))));
            type.GetProperties(Helper.Flags).ForEach(p => values.Add(Format(p.Name, p.GetValue(this, null))));

            Debug.LogWarning(Helper.DumpTemplate.Form(Module.ModuleDisplayName, ModuleId, string.Join("", values.Select(o => string.Join("", o.Unwrap(getVariables).Select(o => o.ToString()).ToArray())).ToArray())));
        }

        /// <summary>
        /// Solves the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Solve(params string[] logs)
        {
            if (IsSolved)
                return;

            LogMultiple(logs);

            IsSolved = true;
            Module.HandlePass();
        }

        /// <summary>
        /// Strikes the module, and logs all of the parameters.
        /// </summary>
        /// <param name="logs">All of the entries to log.</param>
        public void Strike(params string[] logs)
        {
            LogMultiple(logs);

            IsStrike = true;
            Module.HandleStrike();
        }

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="KMSoundOverride.SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, bool loop, params Sound[] sounds)
        {
            sounds.NullOrEmptyCheck($"{nameof(sounds)} is null or empty.");

            if (loop && sounds.Any(s => s.Game.HasValue))
                throw new ArgumentException("The game doesn't support looping in-game sounds.");

            sounds.ForEach(s => s.Reference = GetSoundMethod(s)(transform, loop));

            Sounds = Sounds.Concat(sounds).ToArray();

            return sounds;
        }

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <remarks>
        /// <see cref="GameObject.GetComponent{T}"/> and <see cref="GameObject.GetComponents{T}()"/> have their own implementations already, so use these functions instead for that purpose; 
        /// <seealso cref="Get{T}(bool)"/>, <seealso cref="GetAll{T}(bool)"/>
        /// </remarks>
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T[] Cache<T>(Func<T[]> func, bool allowNull = false) where T : Component
        {
            if (!_components.ContainsKey(typeof(T)))
                _components.Add(typeof(T), func());

            return _components.ContainsKey(typeof(T)) ? (T[])_components[typeof(T)] : allowNull ? default(T[]) : throw new UnityComponentNotFoundException($"Tried to get component {typeof(T).Name} from {this}, but was unable to find one.");
        }

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="getVariables">Whether it should search recursively for the elements within the elements.</param>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(bool getVariables, params Expression<Func<object>>[] logs) => Debug.LogWarning(Helper.DumpTemplate.Form(Module.ModuleDisplayName, ModuleId, string.Join("", logs.Select((l, n) => Helper.VariableTemplate.Form(n, Helper.NameOfVariable(l), l.Compile()()?.GetType().ToString() ?? Helper.Null, string.Join(", ", l.Compile()().Unwrap(getVariables).Select(o => o.ToString()).ToArray()))).ToArray())));

        /// <summary>
        /// Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.
        /// </summary>
        /// <param name="logs">All of the variables to throughly log.</param>
        public void Dump(params Expression<Func<object>>[] logs) => Dump(false, logs);

        /// <summary>
        /// Similar to <see cref="Component.GetComponent{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Get<T>(bool allowNull = false) where T : Component => GetAll<T>(allowNull).FirstOrDefault();

        /// <summary>
        /// Similar to <see cref="Component.GetComponents{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees null, if not it will return the default value. (Likely null)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] GetAll<T>(bool allowNull = false) where T : Component => Cache(() => GetComponents<T>(), allowNull);

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        public void Log(object message, LogType logType = LogType.Log) => GetLogMethod(logType)($"[{Module.ModuleDisplayName} #{ModuleId}] {message.UnwrapToString()}");

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log(object message, params object[] args) => Log(message.UnwrapToString().Form(args));

        /// <summary>
        /// Plays a sound. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="transform">The location or sound source of the sound.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="KMSoundOverride.SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(Transform transform, params Sound[] sounds) => PlaySound(transform, false, sounds);

        /// <summary>
        /// Plays a sound, the sound source is the game object it is attached to. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="loop">Whether all sounds listed should loop or not.</param>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="KMSoundOverride.SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(bool loop, params Sound[] sounds) => PlaySound(transform, loop, sounds);

        /// <summary>
        /// Plays a sound, the sound source is the game object it is attached to. Requires <see cref="KMAudio"/> to be assigned.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        /// <param name="sounds">The sounds, these can either be <see cref="string"/>, <see cref="AudioClip"/>, or <see cref="KMSoundOverride.SoundEffect"/>.</param>
        /// <returns>A <see cref="KMAudioRef"/> for each argument you provide.</returns>
        public Sound[] PlaySound(params Sound[] sounds) => PlaySound(transform, false, sounds);

        private void AssignNeedy(Action onTimerExpired, Action onNeedyActivation, Action onNeedyDeactivation)
        {
            if (onTimerExpired is not null)
                Module.Needy.OnTimerExpired += () => onTimerExpired();

            if (onNeedyActivation is not null)
                Module.Needy.OnNeedyActivation += () =>
                {
                    onNeedyActivation();
                    IsNeedyActive = true;
                };

            if (onNeedyDeactivation is not null)
                Module.Needy.OnNeedyDeactivation += () =>
                {
                    onNeedyDeactivation();
                    IsNeedyActive = false;
                };
        }

        private void CheckForTime(KMBombInfo bombInfo)
        {
            if (TimeLeft != (int)bombInfo.GetTime())
            {
                TimeLeft = (int)bombInfo.GetTime();
                OnTimerTick();
            }
        }

        private IEnumerator CheckForUpdate()
        {
            using var req = UnityWebRequest.Get("https://raw.githubusercontent.com/Emik03/KeepCodingAndNobodyExplodes/main/latest");

            yield return req.SendWebRequest();

            if (req.isNetworkError || req.isHttpError)
            {
                PathManager.Log("The KeepCoding version could not be pulled, presumably because the user is offline.");
                yield break;
            }

            if (req.downloadHandler.text.Trim() != PathManager.GetVersionLibrary(ModBundleName).ProductVersion)
                Log($"The library is out of date! Latest Version: {req.downloadHandler.text.Trim()}, Local Version: {PathManager.GetVersionLibrary(ModBundleName).ProductVersion}. Please download the latest version here https://github.com/Emik03/KeepCoding/releases", LogType.Error);
        }

        private IEnumerator TimeUpdate(KMBombInfo bombInfo)
        {
            while (true)
            {
                CheckForTime(bombInfo);
                yield return null;
            }
        }

        private static Action<object> GetLogMethod(LogType logType) => logType switch
        {
            LogType.Error => Debug.LogError,
            LogType.Assert => o => Debug.LogAssertion(o),
            LogType.Warning => Debug.LogWarning,
            LogType.Log => Debug.Log,
            LogType.Exception => o => Debug.LogException((Exception)o),
            _ => throw new UnrecognizedValueException($"{logType} is not a valid log type."),
        };

        private Func<Transform, bool, KMAudioRef> GetSoundMethod(Sound sound) => (t, b) => 
            sound.Custom is not null ? Get<KMAudio>().HandlePlaySoundAtTransformWithRef(sound.Custom, t, b) : 
            sound.Game is not null ? Get<KMAudio>().HandlePlayGameSoundAtTransformWithRef(sound.Game.Value, t) : 
            throw new UnrecognizedTypeException($"{sound} which is a {sound.GetType()} is not a valid type.");

        private void LogMultiple(params string[] logs) => logs.ForEach(s => Log(s));
    }
}
