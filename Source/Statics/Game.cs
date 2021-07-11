using System;
using System.Collections.Generic;
using UnityEngine;
using static KeepCoding.ComponentPool;
using static Localization;
using static UnityEngine.Application;
using KTInput = KTInputManager;
using KTMasterAudio = DarkTonic.MasterAudio.MasterAudio;
using KTMod = ModManager;
using KTModSourceEnum = Assets.Scripts.Mods.ModInfo.ModSourceEnum;
using KTPlayer = Assets.Scripts.Settings.PlayerSettingsManager;
using KTScene = SceneManager;

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
            public static bool IsCurrentControlTypeVR => CurrentControlType is ControlType.Gaze || CurrentControlType is ControlType.Motion || CurrentControlType is ControlType.ThreeDOF;

            /// <value>
            /// The current way the game is being controlled.
            /// </value>
            /// <remarks>
            /// Default: <see cref="ControlType.Mouse"/>.
            /// </remarks>
            public static ControlType CurrentControlType => isEditor ? ControlType.Mouse : CurrentControlTypeInner;
            private static ControlType CurrentControlTypeInner => (ControlType)KTInput.Instance.CurrentControlType;
        }

        /// <summary>
        /// Allows access relating to the game's main master channel for audio.
        /// </summary>
        public static class MasterAudio
        {
            /// <value>
            /// Determines whether a given string has a group info.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static Predicate<string> IsGroupInfo => s => isEditor || GroupInfoInner(s) is { };

            /// <value>
            /// Gets the group info of a given string. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to AudioGroupInfo type to restore its functionality.
            /// </value>
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
            /// <value>
            /// Determines whether or not all pacing events are enabled. Default: <see langword="false"/>.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool IsPacingEvents => !isEditor && IsPacingEventsInner;
            private static bool IsPacingEventsInner => KTScene.Instance.GameplayState.Mission.PacingEventsEnabled;

            /// <value>
            /// The description as it appears in the bomb binder.
            /// </value>
            /// <remarks>
            /// Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".
            /// </remarks>
            public static string Description => isEditor
                ? "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help."
                : DescriptionInner;
            private static string DescriptionInner => GetLocalizedString(KTScene.Instance.GameplayState.Mission.DescriptionTerm);

            /// <value>
            /// The mission name as it appears in the bomb binder.
            /// </value>
            /// <remarks>
            /// Default: "The First Bomb"
            /// </remarks>
            public static string DisplayName => isEditor ? "The First Bomb" : DisplayNameInner;
            private static string DisplayNameInner => GetLocalizedString(KTScene.Instance.GameplayState.Mission.DisplayNameTerm);

            /// <value>
            /// The ID of the mission.
            /// </value>
            /// <remarks>
            /// Default: "firsttime"
            /// </remarks>
            public static string ID => isEditor ? "firsttime" : IDInner;
            private static string IDInner => KTScene.Instance.GameplayState.Mission.ID;

            /// <value>
            /// Gets the generator setting of the mission.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="GeneratorSetting"/>, default constructor.
            /// </remarks>
            public static GeneratorSetting GeneratorSetting => isEditor ? new GeneratorSetting() : GeneratorSettingInner;
            private static GeneratorSetting GeneratorSettingInner
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
            public static Func<List<string>> GetDisabledModPaths => isEditor ? () => new List<string>() : GetDisabledModPathsInner;
            private static Func<List<string>> GetDisabledModPathsInner => KTMod.Instance.GetDisabledModPaths;

            /// <value>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => isEditor ? source => new List<string>() : GetAllModPathsFromSourceInner;
            private static Func<ModSourceEnum, List<string>> GetAllModPathsFromSourceInner => source => KTMod.Instance.GetAllModPathsFromSource((KTModSourceEnum)source);

            /// <value>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            /// <remarks>
            /// New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => isEditor ? source => new List<string>() : GetEnabledModPathsInner;
            private static Func<ModSourceEnum, List<string>> GetEnabledModPathsInner => source => KTMod.Instance.GetEnabledModPaths((KTModSourceEnum)source);
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
            public static bool InvertTiltControls => !isEditor && InvertTiltControlsInner;
            private static bool InvertTiltControlsInner => KTPlayer.Instance.PlayerSettings.InvertTiltControls;

            /// <value>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool LockMouseToWindow => !isEditor && LockMouseToWindowInner;
            private static bool LockMouseToWindowInner => KTPlayer.Instance.PlayerSettings.LockMouseToWindow;

            /// <value>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowLeaderBoards => isEditor || ShowLeaderBoardsInner;
            private static bool ShowLeaderBoardsInner => KTPlayer.Instance.PlayerSettings.ShowLeaderBoards;

            /// <value>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowRotationUI => isEditor || ShowRotationUIInner;
            private static bool ShowRotationUIInner => KTPlayer.Instance.PlayerSettings.ShowRotationUI;

            /// <value>
            /// Determines if the option to show scanlines is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool ShowScanline => isEditor || ShowScanlineInner;
            private static bool ShowScanlineInner => KTPlayer.Instance.PlayerSettings.ShowScanline;

            /// <value>
            /// Determines if the option to skip the title screen is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool SkipTitleScreen => !isEditor && SkipTitleScreenInner;
            private static bool SkipTitleScreenInner => KTPlayer.Instance.PlayerSettings.SkipTitleScreen;

            /// <value>
            /// Determines if the VR or regular controllers vibrate.
            /// </value>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            public static bool RumbleEnabled => isEditor || RumbleEnabledInner;
            private static bool RumbleEnabledInner => KTPlayer.Instance.PlayerSettings.RumbleEnabled;

            /// <value>
            /// Determines if the touchpad controls are inverted.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool TouchpadInvert => !isEditor && TouchpadInvertInner;
            private static bool TouchpadInvertInner => KTPlayer.Instance.PlayerSettings.TouchpadInvert;

            /// <value>
            /// Determines if the option to always use mods is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseModsAlways => !isEditor && UseModsAlwaysInner;
            private static bool UseModsAlwaysInner => KTPlayer.Instance.PlayerSettings.UseModsAlways;

            /// <value>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </value>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            public static bool UseParallelModLoading => !isEditor && UseParallelModLoadingInner;
            private static bool UseParallelModLoadingInner => KTPlayer.Instance.PlayerSettings.UseParallelModLoading;

            /// <value>
            /// Determines if VR mode is requested.
            /// </value>
            public static bool VRModeRequested => isEditor || VRModeRequestedInner;
            private static bool VRModeRequestedInner => KTPlayer.Instance.PlayerSettings.VRModeRequested;

            /// <value>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </value>
            /// <remarks>
            /// Default: 8.
            /// </remarks>
            public static int AntiAliasing => isEditor ? 8 : AntiAliasingInner;
            private static int AntiAliasingInner => KTPlayer.Instance.PlayerSettings.AntiAliasing;

            /// <value>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </value>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int MusicVolume => isEditor ? 100 : MusicVolumeInner;
            private static int MusicVolumeInner => KTPlayer.Instance.PlayerSettings.MusicVolume;

            /// <value>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </value>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            public static int SFXVolume => isEditor ? 100 : SFXVolumeInner;
            private static int SFXVolumeInner => KTPlayer.Instance.PlayerSettings.SFXVolume;

            /// <value>
            /// Determines if VSync is on or off.
            /// </value>
            /// <remarks>
            /// Default: 1.
            /// </remarks>
            public static int VSync => isEditor ? 1 : VSyncInner;
            private static int VSyncInner => KTPlayer.Instance.PlayerSettings.VSync;

            /// <value>
            /// The current language code.
            /// </value>
            /// <remarks>
            /// Default: "en".
            /// </remarks>
            public static string LanguageCode => isEditor ? "en" : LanguageCodeInner;
            private static string LanguageCodeInner => KTPlayer.Instance.PlayerSettings.LanguageCode;
        }

        /// <value>
        /// Adds an amount of strikes on the bomb.
        /// </value>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        public static Action<GameObject, int> AddStrikes => isEditor
            ? (gameObject, amount) => Logger.Self($"Adding the bomb's strike count with {amount}.")
            : AddStrikesInner;
        private static Action<GameObject, int> AddStrikesInner => (gameObject, amount) =>
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
            : SetStrikesInner;
        private static Action<GameObject, int> SetStrikesInner => (gameObject, amount) =>
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
        public static Func<GameObject, object> Bomb => isEditor ? gameObject => null : BombInner;
        private static Func<GameObject, object> BombInner => gameObject => gameObject.GetComponentInParent(typeof(Bomb));

        /// <value>
        /// Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to TimerComponent or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </value>
        /// <remarks>
        /// Default: <see langword="null"/>.
        /// </remarks>
        public static Func<GameObject, object> Timer => isEditor ? gameObject => null : TimerInner;
        private static Func<GameObject, object> TimerInner => gameObject => ((Bomb)Bomb(gameObject)).GetTimer();

        /// <value>
        /// Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an <see cref="object"/> <see cref="Array"/>. You can cast it to BombComponent type to restore its functionality.
        /// </value>
        /// <remarks>
        /// Default: An empty <see cref="object"/> <see cref="Array"/>.
        /// </remarks>
        public static Func<KMBomb, object[]> Vanillas => isEditor ? gameObject => new object[0] : VanillasInner;
        private static Func<KMBomb, object[]> VanillasInner => bomb => bomb.GetComponentsInChildren(typeof(BombComponent)).ConvertAll(c => (object)c);
    }
}
