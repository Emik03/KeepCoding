using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Application;
using static KeepCoding.ComponentPool;
using static Localization;
using KTInput = KTInputManager;
using KTMod = ModManager;
using KTPlayer = Assets.Scripts.Settings.PlayerSettingsManager;
using KTScene = SceneManager;
using KTModSourceEnum = Assets.Scripts.Mods.ModInfo.ModSourceEnum;

namespace KeepCoding
{
    extern alias core;

    /// <summary>
    /// Allows access into the game's internal code. Written by Emik.
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
            /// <value>
            /// The game is being controlled with a gamepad controller.
            /// </value>
            Gamepad,

            /// <value>
            /// The game is being controlled with a virtual reality headset.
            /// </value>
            Gaze,

            /// <value>
            /// The game is being controlled with a mouse.
            /// </value>
            Mouse,

            /// <value>
            /// The game is being controlled with virtual reality headset and controller.
            /// </value>
            Motion,

            /// <value>
            /// The game is being controlled with touch controls.
            /// </value>
            Touch,

            /// <value>
            /// The game is being controlled with three degrees of freedom, part of virtual reality.
            /// </value>
            ThreeDOF
        }

        /// <summary>
        /// Determines how the mod is stored.
        /// </summary>
        public enum ModSourceEnum
        {
            /// <value>
            /// The mod is invalid.
            /// </value>
            Invalid,

            /// <value>
            /// The mod is stored within the local mods folder.
            /// </value>
            Local,

            /// <value>
            /// The mod is stored within the workshop folder.
            /// </value>
            SteamWorkshop
        }

        /// <summary>
        /// Allows access relating to how the game is being interacted with.
        /// </summary>
        public static class KTInputManager
        {
            /// <value>
            /// Determines if the current way the game is being controlled is VR-related.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool IsCurrentControlTypeVR => !isEditor && IsCurrentControlTypeVRInternal;
            private static bool IsCurrentControlTypeVRInternal => CurrentControlType is ControlType.Gaze || CurrentControlType is ControlType.Motion || CurrentControlType is ControlType.ThreeDOF;

            /// <value>
            /// The current way the game is being controlled.
            /// </value>
            /// <remarks>
            /// Default: <see cref="ControlType.Mouse"/>.
            /// </remarks>
            public static ControlType CurrentControlType => isEditor ? ControlType.Mouse : CurrentControlTypeInternal;
            private static ControlType CurrentControlTypeInternal => (ControlType)KTInput.Instance.CurrentControlType;
        }

        /// <summary>
        /// Allows access relating to the current mission.
        /// </summary>
        public static class Mission
        {
            /// <value>
            /// Determines whether or not all pacing events are enabled. Default: <see langword="false"/>.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool IsPacingEvents => !isEditor && IsPacingEventsInternal;
            private static bool IsPacingEventsInternal => KTScene.Instance.GameplayState.Mission.PacingEventsEnabled;

            /// <value>
            /// The description as it appears in the bomb binder.
            /// </value>
            /// <remarks>
            /// Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".
            /// </remarks>
            public static string Description => isEditor 
                ? "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help." 
                : DescriptionInternal;
            private static string DescriptionInternal => GetLocalizedString(KTScene.Instance.GameplayState.Mission.DescriptionTerm);

            /// <value>
            /// The mission name as it appears in the bomb binder.
            /// </value>
            /// <remarks>
            /// Default: "The First Bomb"
            /// </remarks>
            public static string DisplayName => isEditor ? "The First Bomb" : DisplayNameInternal;
            private static string DisplayNameInternal => GetLocalizedString(KTScene.Instance.GameplayState.Mission.DisplayNameTerm);

            /// <value>
            /// The ID of the mission.
            /// </value>
            /// <remarks>
            /// Default: "firsttime"
            /// </remarks>
            public static string ID => isEditor ? "firsttime" : IDInternal;
            private static string IDInternal => KTScene.Instance.GameplayState.Mission.ID;

            /// <value>
            /// Gets the generator setting of the mission.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="GeneratorSetting"/>, default constructor.
            /// </remarks>
            public static GeneratorSetting GeneratorSetting => isEditor ? new GeneratorSetting() : GeneratorSettingInternal;
            private static GeneratorSetting GeneratorSettingInternal
            {
                get
                {
                    var setting = KTScene.Instance.GameplayState.Mission.GeneratorSetting;

                    var list = new List<ComponentPool>();

                    foreach (var pool in setting.ComponentPools)
                    {
                        var types = new List<ComponentTypeEnum>();

                        foreach (var type in pool.ComponentTypes)
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
            /// <value>
            /// Gets all of the disabled mod paths.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<List<string>> GetDisabledModPaths => isEditor ? () => new List<string>() : GetDisabledModPathsInternal;
            private static Func<List<string>> GetDisabledModPathsInternal => KTMod.Instance.GetDisabledModPaths;

            /// <value>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => isEditor ? source => new List<string>() : GetAllModPathsFromSourceInternal;
            private static Func<ModSourceEnum, List<string>> GetAllModPathsFromSourceInternal => source => KTMod.Instance.GetAllModPathsFromSource((KTModSourceEnum)source);

            /// <value>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => isEditor ? source => new List<string>() : GetEnabledModPathsInternal;
            private static Func<ModSourceEnum, List<string>> GetEnabledModPathsInternal => source => KTMod.Instance.GetEnabledModPaths((KTModSourceEnum)source);
        }

        /// <summary>
        /// Allows access into the player settings from the game. Do not use this class in the unity editor. Written by Emik.
        /// </summary>
        public static class PlayerSettings
        {
            /// <value>
            /// Determines if vertical tilting is flipped or not.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool InvertTiltControls => !isEditor && InvertTiltControlsInternal;
            private static bool InvertTiltControlsInternal => KTPlayer.Instance.PlayerSettings.InvertTiltControls;

            /// <value>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool LockMouseToWindow => !isEditor && LockMouseToWindowInternal;
            private static bool LockMouseToWindowInternal => KTPlayer.Instance.PlayerSettings.LockMouseToWindow;

            /// <value>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowLeaderBoards => isEditor || ShowLeaderBoardsInternal;
            private static bool ShowLeaderBoardsInternal => KTPlayer.Instance.PlayerSettings.ShowLeaderBoards;

            /// <value>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowRotationUI => isEditor || ShowRotationUIInternal;
            private static bool ShowRotationUIInternal => KTPlayer.Instance.PlayerSettings.ShowRotationUI;

            /// <value>
            /// Determines if the option to show scanlines is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowScanline => isEditor || ShowScanlineInternal;
            private static bool ShowScanlineInternal => KTPlayer.Instance.PlayerSettings.ShowScanline;

            /// <value>
            /// Determines if the option to skip the title screen is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool SkipTitleScreen => !isEditor && SkipTitleScreenInternal;
            private static bool SkipTitleScreenInternal => KTPlayer.Instance.PlayerSettings.SkipTitleScreen;

            /// <value>
            /// Determines if the VR or regular controllers vibrate.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool RumbleEnabled => isEditor || RumbleEnabledInternal;
            private static bool RumbleEnabledInternal => KTPlayer.Instance.PlayerSettings.RumbleEnabled;

            /// <value>
            /// Determines if the touchpad controls are inverted.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool TouchpadInvert => !isEditor && TouchpadInvertInternal;
            private static bool TouchpadInvertInternal => KTPlayer.Instance.PlayerSettings.TouchpadInvert;

            /// <value>
            /// Determines if the option to always use mods is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseModsAlways => !isEditor && UseModsAlwaysInternal;
            private static bool UseModsAlwaysInternal => KTPlayer.Instance.PlayerSettings.UseModsAlways;

            /// <value>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseParallelModLoading => !isEditor && UseParallelModLoadingInternal;
            private static bool UseParallelModLoadingInternal => KTPlayer.Instance.PlayerSettings.UseParallelModLoading;

            /// <value>
            /// Determines if VR mode is requested.
            /// </value>
            public static bool VRModeRequested => isEditor || VRModeRequestedInternal;
            private static bool VRModeRequestedInternal => KTPlayer.Instance.PlayerSettings.VRModeRequested;

            /// <value>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </value>
            /// <remarks>
            /// Default: 8.
            /// </remarks>
            public static int AntiAliasing => isEditor ? 8 : AntiAliasingInternal;
            private static int AntiAliasingInternal => KTPlayer.Instance.PlayerSettings.AntiAliasing;

            /// <value>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </value>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int MusicVolume => isEditor ? 100 : MusicVolumeInternal;
            private static int MusicVolumeInternal => KTPlayer.Instance.PlayerSettings.MusicVolume;

            /// <value>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </value>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int SFXVolume => isEditor ? 100 : SFXVolumeInternal;
            private static int SFXVolumeInternal => KTPlayer.Instance.PlayerSettings.SFXVolume;

            /// <value>
            /// Determines if VSync is on or off.
            /// </value>
            /// <remarks>
            /// Default: 1.
            /// </remarks>
            public static int VSync => isEditor ? 1 : VSyncInternal;
            private static int VSyncInternal => KTPlayer.Instance.PlayerSettings.VSync;

            /// <value>
            /// The current language code.
            /// </value>
            /// <remarks>
            /// Default: "en".
            /// </remarks>
            public static string LanguageCode => isEditor ? "en" : LanguageCodeInternal;
            private static string LanguageCodeInternal => KTPlayer.Instance.PlayerSettings.LanguageCode;
        }

        /// <value>
        /// Adds an amount of strikes on the bomb.
        /// </value>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int> AddStrikes => isEditor 
            ? (gameObject, amount) => Logger.Self($"Adding the bomb's strike count with {amount}.")
            : AddStrikesInternal;
        private static Action<GameObject, int> AddStrikesInternal => (gameObject, amount) =>
        {
            Logger.Self($"Adding the bomb's strike count with {amount}.");
            var bomb = (Bomb)Bomb(gameObject);
            bomb.StrikeIndicator.StrikeCount = bomb.NumStrikes += amount;
        };

        /// <value>
        /// Sets an amount of strikes on the bomb.
        /// </value>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int> SetStrikes => isEditor
            ? (gameObject, amount) => Logger.Self($"Setting the bomb's strike count to {amount}.")
            : SetStrikesInternal;
        private static Action<GameObject, int> SetStrikesInternal => (gameObject, amount) =>
        {
            Logger.Self($"Setting the bomb's strike count to {amount}.");
            var bomb = (Bomb)Bomb(gameObject);
            bomb.StrikeIndicator.StrikeCount = bomb.NumStrikes = amount;
        };

        /// <value>
        /// Gets the game's internal bomb component, not to be mistaken with <see cref="KMBomb"/>. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to Bomb or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </value>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Bomb => isEditor ? gameObject => null : BombInternal;
        private static Func<GameObject, object> BombInternal => gameObject => gameObject.GetComponentInParent(typeof(Bomb));

        /// <value>
        /// Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to TimerComponent or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </value>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Timer => isEditor ? gameObject => null : TimerInternal;
        private static Func<GameObject, object> TimerInternal => gameObject => ((Bomb)Bomb(gameObject)).GetTimer();
    }
}
