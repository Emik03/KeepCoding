using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security;
using KeepCoding.Internal;
using UnityEngine;
using static KeepCoding.ComponentPool;
using static KeepCoding.Logger;
using static Localization;
using static UnityEngine.Application;
using KTComponentPool = Assets.Scripts.Missions.ComponentPool;
using KTComponentTypeEnum = Assets.Scripts.Missions.ComponentTypeEnum;
using KTGeneratorSetting = Assets.Scripts.Missions.GeneratorSetting;
using KTMasterAudio = DarkTonic.MasterAudio.MasterAudio;
using KTModManager = ModManager;
using KTModSourceEnum = Assets.Scripts.Mods.ModInfo.ModSourceEnum;
using KTPlayerSettingsManager = Assets.Scripts.Settings.PlayerSettingsManager;
using KTSceneManager = SceneManager;

namespace KeepCoding
{
    extern alias core;

    /// <summary>
    /// Allows access into the game's internal code. 
    /// </summary>
    /// <remarks>
    /// On the Editor, these properties will return default values. Check the XML documentation to see the value it returns.
    /// </remarks>
    public static class Game
    {
        private static readonly NotSupportedException s_notDone = new NotSupportedException("The library that is required for this action hasn't been released yet.");

        private static readonly UnrecognizedValueException s_badValue = new UnrecognizedValueException($"The value of {nameof(Reference)} ({Reference}) is not a valid library!");

        /// <summary>
        /// Determines how the game is controlled.
        /// </summary>
        public enum ControlType
        {
            /// <summary>
            /// The game is being controlled with a gamepad controller.
            /// </summary>
            Gamepad,

            /// <summary>
            /// The game is being controlled with a virtual reality headset.
            /// </summary>
            Gaze,

            /// <summary>
            /// The game is being controlled with a mouse.
            /// </summary>
            Mouse,

            /// <summary>
            /// The game is being controlled with virtual reality headset and controller.
            /// </summary>
            Motion,

            /// <summary>
            /// The game is being controlled with touch controls.
            /// </summary>
            Touch,

            /// <summary>
            /// The game is being controlled with three degrees of freedom, part of virtual reality.
            /// </summary>
            ThreeDOF
        }

        /// <summary>
        /// Determines how the mod is stored.
        /// </summary>
        public enum ModSourceEnum
        {
            /// <summary>
            /// The mod is invalid.
            /// </summary>
            Invalid,

            /// <summary>
            /// The mod is stored within the local mods folder.
            /// </summary>
            Local,

            /// <summary>
            /// The mod is stored within the workshop folder.
            /// </summary>
            SteamWorkshop
        }

        /// <summary>
        /// Determines what references are used within this class.
        /// </summary>
        public enum References
        {
            /// <summary>
            /// Implies that no reference should be used, and default values are returned.
            /// </summary>
            None,

            /// <summary>
            /// Implies that the Assembly-CSharp.dll from Keep Talking and Nobody Explodes be used, and its values are returned.
            /// </summary>
            Ktane,

            /// <summary>
            /// Implies that the library from TheDarkSid3r's Keep Talking and Nobody Explodes Rewritten be used, and its values are returned.
            /// </summary>
            /// <remarks>
            /// As of right now, this value is unused as the library is yet to be finished. This value will become usable at a later date.
            /// </remarks>
            KtaneRewritten
        }

        /// <summary>
        /// Allows access relating to how the game is being interacted with.
        /// </summary>
        public static class KTInputManager
        {
            /// <summary>
            /// Determines if the current way the game is being controlled is VR-related.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool IsCurrentControlTypeVR => CurrentControlType.IsAny(ControlType.Gaze, ControlType.Motion, ControlType.ThreeDOF);

            /// <summary>
            /// The current way the game is being controlled.
            /// </summary>
            /// <remarks>
            /// Default: <see cref="ControlType.Mouse"/>.
            /// </remarks>
            public static ControlType CurrentControlType => IsNoneReference ? ControlType.Mouse : Reference switch
            {
                References.Ktane => CurrentControlTypeInner,
                References.KtaneRewritten => CurrentControlTypeRewrittenInner,
                _ => throw s_badValue
            };
            private static ControlType CurrentControlTypeInner => (ControlType)global::KTInputManager.Instance.CurrentControlType;
            private static ControlType CurrentControlTypeRewrittenInner => throw s_notDone;
        }

        /// <summary>
        /// Allows access relating to the game's main master channel for audio.
        /// </summary>
        public static class MasterAudio
        {
            /// <summary>
            /// Determines whether a given string has a group info.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static Predicate<string> IsGroupInfo => s => IsNoneReference || GroupInfoInner(s) is { };

            /// <summary>
            /// Gets the group info of a given string. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to AudioGroupInfo type to restore its functionality.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="null"/>.
            /// </remarks>
            public static Func<string, object> GroupInfo => IsNoneReference ? s => null : Reference switch
            {
                References.Ktane => GroupInfoInner,
                References.KtaneRewritten => GroupInfoRewrittenInner,
                _ => throw s_badValue
            };
            private static Func<string, object> GroupInfoInner => KTMasterAudio.GetGroupInfo;
            private static Func<string, object> GroupInfoRewrittenInner => throw s_notDone;
        }

        /// <summary>
        /// Allows access relating to the current mission.
        /// </summary>
        public static class Mission
        {
            /// <summary>
            /// Determines whether or not all pacing events are enabled. Default: <see langword="false"/>.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool IsPacingEvents => !IsNoneReference && Reference switch
            {
                References.Ktane => IsPacingEventsInner,
                References.KtaneRewritten => IsPacingEventsRewrittenInner,
                _ => throw s_badValue
            };
            private static bool IsPacingEventsInner => KTSceneManager.Instance.GameplayState.Mission.PacingEventsEnabled;
            private static bool IsPacingEventsRewrittenInner => throw s_notDone;

            /// <summary>
            /// The description as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".
            /// </remarks>
            public static string Description => IsNoneReference
                ? "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help."
                : Reference switch
                {
                    References.Ktane => DescriptionInner,
                    References.KtaneRewritten => DescriptionRewrittenInner,
                    _ => throw s_badValue
                };
            private static string DescriptionInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DescriptionTerm);
            private static string DescriptionRewrittenInner => throw s_notDone;

            /// <summary>
            /// The mission name as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "The First Bomb"
            /// </remarks>
            public static string DisplayName => IsNoneReference ? "The First Bomb" : Reference switch
            {
                References.Ktane => DisplayNameInner,
                References.KtaneRewritten => DisplayNameRewrittenInner,
                _ => throw s_badValue
            };
            private static string DisplayNameInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DisplayNameTerm);
            private static string DisplayNameRewrittenInner => throw s_notDone;

            /// <summary>
            /// The ID of the mission.
            /// </summary>
            /// <remarks>
            /// Default: "firsttime"
            /// </remarks>
            public static string ID => IsNoneReference ? "firsttime" : Reference switch
            {
                References.Ktane => IDInner,
                References.KtaneRewritten => IDRewrittenInner,
                _ => throw s_badValue
            };
            private static string IDInner => KTSceneManager.Instance.GameplayState.Mission.ID;
            private static string IDRewrittenInner => throw s_notDone;

            /// <summary>
            /// Gets the generator setting of the mission.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="GeneratorSetting"/>, default constructor.
            /// </remarks>
            public static GeneratorSetting GeneratorSetting => IsNoneReference ? new GeneratorSetting() : Reference switch
            {
                References.Ktane => GeneratorSettingInner,
                References.KtaneRewritten => GeneratorSettingRewrittenInner,
                _ => throw s_badValue
            };
            private static GeneratorSetting GeneratorSettingInner
            {
                get
                {
                    KTGeneratorSetting setting = KTSceneManager.Instance.GameplayState.Mission.GeneratorSetting;

                    var list = new List<ComponentPool>();

                    foreach (KTComponentPool pool in setting.ComponentPools)
                    {
                        var types = new List<ComponentTypeEnum>();

                        foreach (KTComponentTypeEnum type in pool.ComponentTypes)
                            types.Add((ComponentTypeEnum)type);

                        list.Add(new ComponentPool(
                            pool.Count,
                            (ComponentSource)pool.AllowedSources,
                            (SpecialComponentTypeEnum)pool.SpecialComponentType,
                            pool.ModTypes,
                            types));
                    }

                    return new GeneratorSetting(
                        setting.FrontFaceOnly,
                        setting.OptionalWidgetCount,
                        setting.NumStrikes,
                        setting.TimeBeforeNeedyActivation,
                        setting.TimeLimit,
                        list);
                }
            }
            private static GeneratorSetting GeneratorSettingRewrittenInner => throw s_notDone;
        }

        /// <summary>
        /// Allows access to methods relating mod paths.
        /// </summary>
        public static class ModManager
        {
            /// <summary>
            /// Gets all of the disabled mod paths.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<List<string>> GetDisabledModPaths => IsNoneReference ? () => new List<string>() : Reference switch
            {
                References.Ktane => GetDisabledModPathsInner,
                References.KtaneRewritten => GetDisabledModPathsRewrittenInner,
                _ => throw s_badValue
            };
            private static Func<List<string>> GetDisabledModPathsInner => KTModManager.Instance.GetDisabledModPaths;
            private static Func<List<string>> GetDisabledModPathsRewrittenInner => throw s_notDone;

            /// <summary>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => IsNoneReference ? source => new List<string>() : Reference switch
            {
                References.Ktane => GetAllModPathsFromSourceInner,
                References.KtaneRewritten => GetAllModPathsFromSourceRewrittenInner,
                _ => throw s_badValue
            };
            private static Func<ModSourceEnum, List<string>> GetAllModPathsFromSourceInner => source => KTModManager.Instance.GetAllModPathsFromSource((KTModSourceEnum)source);
            private static Func<ModSourceEnum, List<string>> GetAllModPathsFromSourceRewrittenInner => throw s_notDone;

            /// <summary>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => IsNoneReference ? source => new List<string>() : Reference switch
            {
                References.Ktane => GetEnabledModPathsInner,
                References.KtaneRewritten => GetEnabledModPathsRewrittenInner,
                _ => throw s_badValue
            };
            private static Func<ModSourceEnum, List<string>> GetEnabledModPathsInner => source => KTModManager.Instance.GetEnabledModPaths((KTModSourceEnum)source);
            private static Func<ModSourceEnum, List<string>> GetEnabledModPathsRewrittenInner => throw s_notDone;
        }

        /// <summary>
        /// Allows access into the player settings from the game. Do not use this class in the unity editor. 
        /// </summary>
        public static class PlayerSettings
        {
            /// <summary>
            /// Determines if vertical tilting is flipped or not.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool InvertTiltControls => !IsNoneReference && Reference switch
            {
                References.Ktane => InvertTiltControlsInner,
                References.KtaneRewritten => InvertTiltControlsRewrittenInner,
                _ => throw s_badValue
            };
            private static bool InvertTiltControlsInner => KTPlayerSettingsManager.Instance.PlayerSettings.InvertTiltControls;
            private static bool InvertTiltControlsRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool LockMouseToWindow => !IsNoneReference && Reference switch
            {
                References.Ktane => LockMouseToWindowInner,
                References.KtaneRewritten => LockMouseToWindowRewrittenInner,
                _ => throw s_badValue
            };
            private static bool LockMouseToWindowInner => KTPlayerSettingsManager.Instance.PlayerSettings.LockMouseToWindow;
            private static bool LockMouseToWindowRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowLeaderBoards => IsNoneReference || Reference switch
            {
                References.Ktane => ShowLeaderBoardsInner,
                References.KtaneRewritten => ShowLeaderBoardsRewrittenInner,
                _ => throw s_badValue
            };
            private static bool ShowLeaderBoardsInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowLeaderBoards;
            private static bool ShowLeaderBoardsRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowRotationUI => IsNoneReference || Reference switch
            {
                References.Ktane => ShowRotationUIInner,
                References.KtaneRewritten => ShowRotationUIRewrittenInner,
                _ => throw s_badValue
            };
            private static bool ShowRotationUIInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowRotationUI;
            private static bool ShowRotationUIRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to show scanlines is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowScanline => IsNoneReference || Reference switch
            {
                References.Ktane => ShowScanlineInner,
                References.KtaneRewritten => ShowScanlineRewrittenInner,
                _ => throw s_badValue
            };
            private static bool ShowScanlineInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowScanline;
            private static bool ShowScanlineRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to skip the title screen is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool SkipTitleScreen => !IsNoneReference && Reference switch
            {
                References.Ktane => SkipTitleScreenInner,
                References.KtaneRewritten => SkipTitleScreenRewrittenInner,
                _ => throw s_badValue
            };
            private static bool SkipTitleScreenInner => KTPlayerSettingsManager.Instance.PlayerSettings.SkipTitleScreen;
            private static bool SkipTitleScreenRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the VR or regular controllers vibrate.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool RumbleEnabled => IsNoneReference || Reference switch
            {
                References.Ktane => RumbleEnabledInner,
                References.KtaneRewritten => RumbleEnabledRewrittenInner,
                _ => throw s_badValue
            };
            private static bool RumbleEnabledInner => KTPlayerSettingsManager.Instance.PlayerSettings.RumbleEnabled;
            private static bool RumbleEnabledRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the touchpad controls are inverted.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool TouchpadInvert => !IsNoneReference && Reference switch
            {
                References.Ktane => TouchpadInvertInner,
                References.KtaneRewritten => TouchpadInvertRewrittenInner,
                _ => throw s_badValue
            };
            private static bool TouchpadInvertInner => KTPlayerSettingsManager.Instance.PlayerSettings.TouchpadInvert;
            private static bool TouchpadInvertRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to always use mods is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseModsAlways => !IsNoneReference && Reference switch
            {
                References.Ktane => UseModsAlwaysInner,
                References.KtaneRewritten => UseModsAlwaysRewrittenInner,
                _ => throw s_badValue
            };
            private static bool UseModsAlwaysInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseModsAlways;
            private static bool UseModsAlwaysRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseParallelModLoading => !IsNoneReference && Reference switch
            {
                References.Ktane => UseParallelModLoadingInner,
                References.KtaneRewritten => UseParallelModLoadingRewrittenInner,
                _ => throw s_badValue
            };
            private static bool UseParallelModLoadingInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseParallelModLoading;
            private static bool UseParallelModLoadingRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if VR mode is requested.
            /// </summary>
            public static bool VRModeRequested => IsNoneReference || Reference switch
            {
                References.Ktane => VRModeRequestedInner,
                References.KtaneRewritten => VRModeRequestedRewrittenInner,
                _ => throw s_badValue
            };
            private static bool VRModeRequestedInner => KTPlayerSettingsManager.Instance.PlayerSettings.VRModeRequested;
            private static bool VRModeRequestedRewrittenInner => throw s_notDone;

            /// <summary>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </summary>
            /// <remarks>
            /// Default: 8.
            /// </remarks>
            public static int AntiAliasing => IsNoneReference ? 8 : Reference switch
            {
                References.Ktane => AntiAliasingInner,
                References.KtaneRewritten => AntiAliasingRewrittenInner,
                _ => throw s_badValue
            };
            private static int AntiAliasingInner => KTPlayerSettingsManager.Instance.PlayerSettings.AntiAliasing;
            private static int AntiAliasingRewrittenInner => throw s_notDone;

            /// <summary>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int MusicVolume => IsNoneReference ? 100 : Reference switch
            {
                References.Ktane => MusicVolumeInner,
                References.KtaneRewritten => MusicVolumeRewrittenInner,
                _ => throw s_badValue
            };
            private static int MusicVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.MusicVolume;
            private static int MusicVolumeRewrittenInner => throw s_notDone;

            /// <summary>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int SFXVolume => IsNoneReference ? 100 : Reference switch
            {
                References.Ktane => SFXVolumeInner,
                References.KtaneRewritten => SFXVolumeRewrittenInner,
                _ => throw s_badValue
            };
            private static int SFXVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.SFXVolume;
            private static int SFXVolumeRewrittenInner => throw s_notDone;

            /// <summary>
            /// Determines if VSync is on or off.
            /// </summary>
            /// <remarks>
            /// Default: 1.
            /// </remarks>
            public static int VSync => IsNoneReference ? 1 : Reference switch
            {
                References.Ktane => VSyncInner,
                References.KtaneRewritten => VSyncRewrittenInner,
                _ => throw s_badValue
            };
            private static int VSyncInner => KTPlayerSettingsManager.Instance.PlayerSettings.VSync;
            private static int VSyncRewrittenInner => throw s_notDone;

            /// <summary>
            /// The current language code.
            /// </summary>
            /// <remarks>
            /// Default: "en".
            /// </remarks>
            public static string LanguageCode => IsNoneReference ? "en" : Reference switch
            {
                References.Ktane => LanguageCodeInner,
                References.KtaneRewritten => LanguageCodeRewrittenInner,
                _ => throw s_badValue
            };
            private static string LanguageCodeInner => KTPlayerSettingsManager.Instance.PlayerSettings.LanguageCode;
            private static string LanguageCodeRewrittenInner => throw s_notDone;
        }

        private static bool IsNoneReference => isEditor || Reference is References.None;

        /// <summary>
        /// Adds an amount of strikes on the bomb.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int, bool> AddStrikes => IsNoneReference
            ? (gameObject, amount, checkIfExploded) => Self($"Adding the bomb's strike count with {amount}.")
            : Reference switch
            {
                References.Ktane => AddStrikesInner,
                References.KtaneRewritten => AddStrikesRewrittenInner,
                _ => throw s_badValue
            };
        private static Action<GameObject, int, bool> AddStrikesInner => (gameObject, amount, checkIfExploded) =>
        {
            var bomb = (Bomb)Bomb(gameObject);
            StrikesInner(bomb, bomb.NumStrikes + amount, checkIfExploded);
        };
        private static Action<GameObject, int, bool> AddStrikesRewrittenInner => throw s_notDone;

        /// <summary>
        /// Sets an amount of strikes on the bomb.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int, bool> SetStrikes => IsNoneReference
            ? (gameObject, amount, checkIfExploded) => Self($"Setting the bomb's strike count to {amount}.")
            : Reference switch
            {
                References.Ktane => SetStrikesInner,
                References.KtaneRewritten => SetStrikesRewrittenInner,
                _ => throw s_badValue
            };
        private static Action<GameObject, int, bool> SetStrikesInner => (gameObject, amount, checkIfExploded) =>
        {
            var bomb = (Bomb)Bomb(gameObject);
            StrikesInner(bomb, amount, checkIfExploded);
        };
        private static Action<GameObject, int, bool> SetStrikesRewrittenInner => throw s_notDone;

        private static Action<object, int, bool> StrikesInner => (obj, amount, checkIfExploded) =>
        {
            var bomb = (Bomb)obj;
            bomb.StrikeIndicator.StrikeCount = bomb.NumStrikes = amount;

            if (checkIfExploded && bomb.NumStrikes >= bomb.NumStrikesToLose)
                bomb.Detonate();
        };

        /// <summary>
        /// Gets the game's internal bomb component, not to be mistaken with <see cref="KMBomb"/>. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to Bomb or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Bomb => IsNoneReference ? gameObject => null : Reference switch
        {
            References.Ktane => BombInner,
            References.KtaneRewritten => BombRewrittenInner,
            _ => throw s_badValue
        };
        private static Func<GameObject, object> BombInner => gameObject => gameObject.GetComponentInParent(typeof(Bomb));
        private static Func<GameObject, object> BombRewrittenInner => throw s_notDone;

        /// <summary>
        /// Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to TimerComponent or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Timer => IsNoneReference ? gameObject => null : Reference switch
        {
            References.Ktane => TimerInner,
            References.KtaneRewritten => TimerRewrittenInner,
            _ => throw s_badValue
        };
        private static Func<GameObject, object> TimerInner => gameObject => ((Bomb)Bomb(gameObject)).GetTimer();
        private static Func<GameObject, object> TimerRewrittenInner => throw s_notDone;

        /// <summary>
        /// Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an <see cref="object"/> <see cref="Array"/>. You can cast it to BombComponent type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="object"/> <see cref="Array"/>.
        /// </remarks>
        public static Func<KMBomb, object[]> Vanillas => IsNoneReference ? gameObject => new object[0] : Reference switch
        {
            References.Ktane => VanillasInner,
            References.KtaneRewritten => VanillasRewrittenInner,
            _ => throw s_badValue
        };
        private static Func<KMBomb, object[]> VanillasInner => bomb => bomb.GetComponentsInChildren(typeof(BombComponent))
            .Where(c => !(c.GetComponent<KMBombModule>() || c.GetComponent<KMNeedyModule>()))
            .ToArray()
            .ConvertAll(c => (object)c);
        private static Func<KMBomb, object[]> VanillasRewrittenInner => throw s_notDone;

        /// <summary>
        /// Determines what reference this library should use for the current class. This value can only be modified by the libraries featured in <see cref="References"/>, a <see cref="SecurityException"/> is thrown when this is attempted regardless.
        /// </summary>
        /// <exception cref="SecurityException"></exception>
        public static References Reference
        {
            get => s_references;
            set
            {
                Assembly source = new StackFrame(1).GetMethod().ReflectedType.Assembly;

                string[] trustedSources = new[]
                {
                    Assembly.GetExecutingAssembly().FullName,
                    "Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                };

                s_references = trustedSources.Contains(source.FullName)
                    ? Helper.GetValues<References>().Any(r => r == value)
                    ? value
                    : throw new ArgumentException($"The value \"{value}\" is not valid!")
                    : throw new SecurityException($"The library \"{source.GetName().Name}\" does not have permission to edit this value!");
            }
        }
        private static References s_references;
    }
}
