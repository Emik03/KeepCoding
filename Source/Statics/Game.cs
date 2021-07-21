using System;
using System.Collections.Generic;
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
            public static bool IsCurrentControlTypeVR => CurrentControlType is ControlType.Gaze || CurrentControlType is ControlType.Motion || CurrentControlType is ControlType.ThreeDOF;

            /// <summary>
            /// The current way the game is being controlled.
            /// </summary>
            /// <remarks>
            /// Default: <see cref="ControlType.Mouse"/>.
            /// </remarks>
            public static ControlType CurrentControlType => isEditor ? ControlType.Mouse : CurrentControlTypeInner;
            private static ControlType CurrentControlTypeInner => (ControlType)global::KTInputManager.Instance.CurrentControlType;
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
            public static Predicate<string> IsGroupInfo => s => isEditor || GroupInfoInner(s) is { };

            /// <summary>
            /// Gets the group info of a given string. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to AudioGroupInfo type to restore its functionality.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="null"/>.
            /// </remarks>
            public static Func<string, object> GroupInfo => isEditor ? s => null : GroupInfoInner;
            private static Func<string, object> GroupInfoInner => KTMasterAudio.GetGroupInfo;
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
            public static bool IsPacingEvents => !isEditor && IsPacingEventsInner;
            private static bool IsPacingEventsInner => KTSceneManager.Instance.GameplayState.Mission.PacingEventsEnabled;

            /// <summary>
            /// The description as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".
            /// </remarks>
            public static string Description => isEditor
                ? "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help."
                : DescriptionInner;
            private static string DescriptionInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DescriptionTerm);

            /// <summary>
            /// The mission name as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "The First Bomb"
            /// </remarks>
            public static string DisplayName => isEditor ? "The First Bomb" : DisplayNameInner;
            private static string DisplayNameInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DisplayNameTerm);

            /// <summary>
            /// The ID of the mission.
            /// </summary>
            /// <remarks>
            /// Default: "firsttime"
            /// </remarks>
            public static string ID => isEditor ? "firsttime" : IDInner;
            private static string IDInner => KTSceneManager.Instance.GameplayState.Mission.ID;

            /// <summary>
            /// Gets the generator setting of the mission.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="GeneratorSetting"/>, default constructor.
            /// </remarks>
            public static GeneratorSetting GeneratorSetting => isEditor ? new GeneratorSetting() : GeneratorSettingInner;
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
            public static Func<List<string>> GetDisabledModPaths => isEditor ? () => new List<string>() : GetDisabledModPathsInner;
            private static Func<List<string>> GetDisabledModPathsInner => KTModManager.Instance.GetDisabledModPaths;

            /// <summary>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => isEditor ? source => new List<string>() : GetAllModPathsFromSourceInner;
            private static Func<ModSourceEnum, List<string>> GetAllModPathsFromSourceInner => source => KTModManager.Instance.GetAllModPathsFromSource((KTModSourceEnum)source);

            /// <summary>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => isEditor ? source => new List<string>() : GetEnabledModPathsInner;
            private static Func<ModSourceEnum, List<string>> GetEnabledModPathsInner => source => KTModManager.Instance.GetEnabledModPaths((KTModSourceEnum)source);
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
            public static bool InvertTiltControls => !isEditor && InvertTiltControlsInner;
            private static bool InvertTiltControlsInner => KTPlayerSettingsManager.Instance.PlayerSettings.InvertTiltControls;

            /// <summary>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool LockMouseToWindow => !isEditor && LockMouseToWindowInner;
            private static bool LockMouseToWindowInner => KTPlayerSettingsManager.Instance.PlayerSettings.LockMouseToWindow;

            /// <summary>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowLeaderBoards => isEditor || ShowLeaderBoardsInner;
            private static bool ShowLeaderBoardsInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowLeaderBoards;

            /// <summary>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowRotationUI => isEditor || ShowRotationUIInner;
            private static bool ShowRotationUIInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowRotationUI;

            /// <summary>
            /// Determines if the option to show scanlines is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowScanline => isEditor || ShowScanlineInner;
            private static bool ShowScanlineInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowScanline;

            /// <summary>
            /// Determines if the option to skip the title screen is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool SkipTitleScreen => !isEditor && SkipTitleScreenInner;
            private static bool SkipTitleScreenInner => KTPlayerSettingsManager.Instance.PlayerSettings.SkipTitleScreen;

            /// <summary>
            /// Determines if the VR or regular controllers vibrate.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool RumbleEnabled => isEditor || RumbleEnabledInner;
            private static bool RumbleEnabledInner => KTPlayerSettingsManager.Instance.PlayerSettings.RumbleEnabled;

            /// <summary>
            /// Determines if the touchpad controls are inverted.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool TouchpadInvert => !isEditor && TouchpadInvertInner;
            private static bool TouchpadInvertInner => KTPlayerSettingsManager.Instance.PlayerSettings.TouchpadInvert;

            /// <summary>
            /// Determines if the option to always use mods is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseModsAlways => !isEditor && UseModsAlwaysInner;
            private static bool UseModsAlwaysInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseModsAlways;

            /// <summary>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseParallelModLoading => !isEditor && UseParallelModLoadingInner;
            private static bool UseParallelModLoadingInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseParallelModLoading;

            /// <summary>
            /// Determines if VR mode is requested.
            /// </summary>
            public static bool VRModeRequested => isEditor || VRModeRequestedInner;
            private static bool VRModeRequestedInner => KTPlayerSettingsManager.Instance.PlayerSettings.VRModeRequested;

            /// <summary>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </summary>
            /// <remarks>
            /// Default: 8.
            /// </remarks>
            public static int AntiAliasing => isEditor ? 8 : AntiAliasingInner;
            private static int AntiAliasingInner => KTPlayerSettingsManager.Instance.PlayerSettings.AntiAliasing;

            /// <summary>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int MusicVolume => isEditor ? 100 : MusicVolumeInner;
            private static int MusicVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.MusicVolume;

            /// <summary>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int SFXVolume => isEditor ? 100 : SFXVolumeInner;
            private static int SFXVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.SFXVolume;

            /// <summary>
            /// Determines if VSync is on or off.
            /// </summary>
            /// <remarks>
            /// Default: 1.
            /// </remarks>
            public static int VSync => isEditor ? 1 : VSyncInner;
            private static int VSyncInner => KTPlayerSettingsManager.Instance.PlayerSettings.VSync;

            /// <summary>
            /// The current language code.
            /// </summary>
            /// <remarks>
            /// Default: "en".
            /// </remarks>
            public static string LanguageCode => isEditor ? "en" : LanguageCodeInner;
            private static string LanguageCodeInner => KTPlayerSettingsManager.Instance.PlayerSettings.LanguageCode;
        }

        /// <summary>
        /// Adds an amount of strikes on the bomb.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int> AddStrikes => isEditor
            ? (gameObject, amount) => Self($"Adding the bomb's strike count with {amount}.")
            : AddStrikesInner;
        private static Action<GameObject, int> AddStrikesInner => (gameObject, amount) =>
        {
            Self($"Adding the bomb's strike count with {amount}.");
            var bomb = (Bomb)Bomb(gameObject);
            bomb.StrikeIndicator.StrikeCount = bomb.NumStrikes += amount;
        };

        /// <summary>
        /// Sets an amount of strikes on the bomb.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int> SetStrikes => isEditor
            ? (gameObject, amount) => Self($"Setting the bomb's strike count to {amount}.")
            : SetStrikesInner;
        private static Action<GameObject, int> SetStrikesInner => (gameObject, amount) =>
        {
            Logger.Self($"Setting the bomb's strike count to {amount}.");
            var bomb = (Bomb)Bomb(gameObject);
            bomb.StrikeIndicator.StrikeCount = bomb.NumStrikes = amount;
        };

        /// <summary>
        /// Gets the game's internal bomb component, not to be mistaken with <see cref="KMBomb"/>. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to Bomb or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Bomb => isEditor ? gameObject => null : BombInner;
        private static Func<GameObject, object> BombInner => gameObject => gameObject.GetComponentInParent(typeof(Bomb));

        /// <summary>
        /// Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to TimerComponent or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Timer => isEditor ? gameObject => null : TimerInner;
        private static Func<GameObject, object> TimerInner => gameObject => ((Bomb)Bomb(gameObject)).GetTimer();

        /// <summary>
        /// Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an <see cref="object"/> <see cref="Array"/>. You can cast it to BombComponent type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: An empty <see cref="object"/> <see cref="Array"/>.
        /// </remarks>
        public static Func<KMBomb, object[]> Vanillas => isEditor ? gameObject => new object[0] : VanillasInner;
        private static Func<KMBomb, object[]> VanillasInner => bomb => bomb.GetComponentsInChildren(typeof(BombComponent)).ConvertAll(c => (object)c);
    }
}
