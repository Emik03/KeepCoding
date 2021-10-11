using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using KeepCoding.Internal;
using Rewritten;
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
    /// <summary>
    /// Allows access into the game's internal code. 
    /// </summary>
    /// <remarks>
    /// On the Editor, these properties will return default values. Check the XML documentation to see the value it returns.
    /// </remarks>
    public static class Game
    {
        private static readonly UnrecognizedValueException s_badValue = new UnrecognizedValueException($"The value of {nameof(Reference)} ({Reference}) is not a valid library! This normally shouldn't happen, so please leave submit a bug report in the event that you do see this exception message thrown!");

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
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool IsCurrentControlTypeVR => new[] { ControlType.Gaze, ControlType.Motion, ControlType.ThreeDOF }.Contains(CurrentControlType);

            /// <summary>
            /// The current way the game is being controlled.
            /// </summary>
            /// <remarks>
            /// Default: <see cref="ControlType.Mouse"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static ControlType CurrentControlType => Reference switch
            {
                References.None => ControlType.Mouse,
                References.Ktane => CurrentControlTypeInner,
                References.KtaneRewritten => CurrentControlTypeRewrittenInner,
                _ => throw s_badValue
            };

            private static ControlType CurrentControlTypeInner => (ControlType)global::KTInputManager.Instance.CurrentControlType;

            private static ControlType CurrentControlTypeRewrittenInner => (ControlType)RewrittenReferences.CurrentControlType;
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
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            /// <param name="source">The source of the sound, which is typically the assembly name which uses the bundle that contains the sound.</param>
            /// <param name="sound">The name of the sound.</param>
            /// <returns><see langword="true"/> if <paramref name="source"/> with <paramref name="sound"/> has a group info, otherwise <see langword="false"/>.</returns>
            public static bool IsGroupInfo(string source, string sound) => GroupInfo(source, sound) is { };

            /// <summary>
            /// Gets the group info of a given string. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to AudioGroupInfo type to restore its functionality.
            /// </summary>
            /// <remarks>
            /// Default: Returns the <see cref="string"/> argument given boxed as <see cref="object"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            /// <param name="source">The source of the sound, which is typically the assembly name which uses the bundle that contains the sound.</param>
            /// <param name="sound">The name of the sound.</param>
            /// <returns>The <see cref="object"/> which contains the GroupInfo of the desired <paramref name="source"/> and <paramref name="sound"/>, or <see langword="null"/> if no such GroupInfo exists.</returns>
            public static object GroupInfo(string source, string sound) => Reference switch
            {
                References.None => source,
                References.Ktane => GroupInfoInner(source, sound),
                References.KtaneRewritten => GroupInfoRewrittenInner(source, sound),
                _ => throw s_badValue
            };

            private static object GroupInfoInner(string source, string sound) => KTMasterAudio.GetGroupInfo($"{source}_{sound}");

            private static object GroupInfoRewrittenInner(string source, string sonud) => RewrittenReferences.GetGroupInfo(source, sonud);
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
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool IsPacingEvents => Reference switch
            {
                References.None => false,
                References.Ktane => IsPacingEventsInner,
                References.KtaneRewritten => IsPacingEventsRewrittenInner,
                _ => throw s_badValue
            };

            private static bool IsPacingEventsInner { get => KTSceneManager.Instance.GameplayState.Mission.PacingEventsEnabled; set => KTSceneManager.Instance.GameplayState.Mission.PacingEventsEnabled = value; }

            private static bool IsPacingEventsRewrittenInner => RewrittenReferences.IsPacingEventsEnabled;

            /// <summary>
            /// The description as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static string Description => Reference switch
            {
                References.None => "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.",
                References.Ktane => DescriptionInner,
                References.KtaneRewritten => DescriptionRewrittenInner,
                _ => throw s_badValue
            };

            private static string DescriptionInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DescriptionTerm);

            private static string DescriptionRewrittenInner => RewrittenReferences.MissionDescription;

            /// <summary>
            /// The mission name as it appears in the bomb binder.
            /// </summary>
            /// <remarks>
            /// Default: "The First Bomb"
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static string DisplayName => Reference switch
            {
                References.None => "The First Bomb",
                References.Ktane => DisplayNameInner,
                References.KtaneRewritten => DisplayNameRewrittenInner,
                _ => throw s_badValue
            };

            private static string DisplayNameInner => GetLocalizedString(KTSceneManager.Instance.GameplayState.Mission.DisplayNameTerm);

            private static string DisplayNameRewrittenInner => RewrittenReferences.MissionDisplayName;

            /// <summary>
            /// The ID of the mission.
            /// </summary>
            /// <remarks>
            /// Default: "firsttime"
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static string ID => Reference switch
            {
                References.None => "firsttime",
                References.Ktane => IDInner,
                References.KtaneRewritten => IDRewrittenInner,
                _ => throw s_badValue
            };

            private static string IDInner => KTSceneManager.Instance.GameplayState.Mission.ID;

            private static string IDRewrittenInner => RewrittenReferences.MissionID;

            /// <summary>
            /// Gets the generator setting of the mission.
            /// </summary>
            /// <remarks>
            /// New instance of <see cref="GeneratorSetting"/>, default constructor.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static GeneratorSetting GeneratorSetting => Reference switch
            {
                References.None => new GeneratorSetting(),
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

            private static GeneratorSetting GeneratorSettingRewrittenInner
            {
                get
                {
                    KMGeneratorSetting setting = RewrittenReferences.MissionGeneratorSetting;

                    var list = new List<ComponentPool>();

                    foreach (KMComponentPool pool in setting.ComponentPools)
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

#if !LITE
        /// <summary>
        /// Allows access to methods relating mod paths.
        /// </summary>
        public static class ModManager
        {
            /// <summary>
            /// Gets all of the disabled mod paths.
            /// </summary>
            /// <remarks>
            /// Default: New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            /// <returns>A <see cref="List{T}"/> of disabled mod paths.</returns>
            public static List<string> GetDisabledModPaths() => Reference switch
            {
                References.None => new List<string>(),
                References.Ktane => GetDisabledModPathsInner(),
                References.KtaneRewritten => GetDisabledModPathsRewrittenInner(),
                _ => throw s_badValue
            };

            private static List<string> GetDisabledModPathsInner() => KTModManager.Instance.GetDisabledModPaths();

            private static List<string> GetDisabledModPathsRewrittenInner() => RewrittenReferences.GetDisabledModPaths();

            /// <summary>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// Default: New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            /// <param name="source">The <see cref="ModSourceEnum"/> source that the mod needs to come from to be included in the <see cref="List{T}"/>.</param>
            /// <returns>A <see cref="List{T}"/> of all mod paths from a given <see cref="ModSourceEnum"/>.</returns>
            public static List<string> GetAllModPathsFromSource(ModSourceEnum source) => Reference switch
            {
                References.None => new List<string>(),
                References.Ktane => GetAllModPathsFromSourceInner(source),
                References.KtaneRewritten => GetAllModPathsFromSourceRewrittenInner(source),
                _ => throw s_badValue
            };

            private static List<string> GetAllModPathsFromSourceInner(ModSourceEnum source) => KTModManager.Instance.GetAllModPathsFromSource((KTModSourceEnum)source);

            private static List<string> GetAllModPathsFromSourceRewrittenInner(ModSourceEnum source) => RewrittenReferences.GetAllModPathsFromSource((Rewritten.ModSourceEnum)source);

            /// <summary>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </summary>
            /// <remarks>
            /// Default: New instance of <see cref="List{T}"/>, with no elements.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            /// <param name="source">The <see cref="ModSourceEnum"/> source that the mod needs to come from to be included in the <see cref="List{T}"/>.</param>
            /// <returns>A <see cref="List{T}"/> of all enabled mod paths from a given <see cref="ModSourceEnum"/>.</returns>
            public static List<string> GetEnabledModPaths(ModSourceEnum source) => Reference switch
            {
                References.None => new List<string>(),
                References.Ktane => GetEnabledModPathsInner(source),
                References.KtaneRewritten => GetEnabledModPathsRewrittenInner(source),
                _ => throw s_badValue
            };

            private static List<string> GetEnabledModPathsInner(ModSourceEnum source) => KTModManager.Instance.GetEnabledModPaths((KTModSourceEnum)source);

            private static List<string> GetEnabledModPathsRewrittenInner(ModSourceEnum source) => RewrittenReferences.GetEnabledModPaths((Rewritten.ModSourceEnum)source);
        }
#endif

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
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool InvertTiltControls => Reference switch
            {
                References.None => false,
                References.Ktane => InvertTiltControlsInner,
                References.KtaneRewritten => InvertTiltControlsRewrittenInner,
                _ => throw s_badValue
            };

            private static bool InvertTiltControlsInner => KTPlayerSettingsManager.Instance.PlayerSettings.InvertTiltControls;

            private static bool InvertTiltControlsRewrittenInner => RewrittenReferences.InvertTiltControls;

            /// <summary>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool LockMouseToWindow => Reference switch
            {
                References.None => false,
                References.Ktane => LockMouseToWindowInner,
                References.KtaneRewritten => LockMouseToWindowRewrittenInner,
                _ => throw s_badValue
            };

            private static bool LockMouseToWindowInner => KTPlayerSettingsManager.Instance.PlayerSettings.LockMouseToWindow;

            private static bool LockMouseToWindowRewrittenInner => RewrittenReferences.LockMouseToWindow;

            /// <summary>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool ShowLeaderBoards => Reference switch
            {
                References.None => true,
                References.Ktane => ShowLeaderBoardsInner,
                References.KtaneRewritten => ShowLeaderBoardsRewrittenInner,
                _ => throw s_badValue
            };

            private static bool ShowLeaderBoardsInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowLeaderBoards;

            private static bool ShowLeaderBoardsRewrittenInner => RewrittenReferences.ShowLeaderboards;

            /// <summary>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool ShowRotationUI => Reference switch
            {
                References.None => false,
                References.Ktane => ShowRotationUIInner,
                References.KtaneRewritten => ShowRotationUIRewrittenInner,
                _ => throw s_badValue
            };

            private static bool ShowRotationUIInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowRotationUI;

            private static bool ShowRotationUIRewrittenInner => RewrittenReferences.ShowRotationUI;

            /// <summary>
            /// Determines if the option to show scanlines is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool ShowScanline => Reference switch
            {
                References.None => true,
                References.Ktane => ShowScanlineInner,
                References.KtaneRewritten => ShowScanlineRewrittenInner,
                _ => throw s_badValue
            };

            private static bool ShowScanlineInner => KTPlayerSettingsManager.Instance.PlayerSettings.ShowScanline;

            private static bool ShowScanlineRewrittenInner => RewrittenReferences.ShowScanline;

            /// <summary>
            /// Determines if the option to skip the title screen is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool SkipTitleScreen => Reference switch
            {
                References.None => false,
                References.Ktane => SkipTitleScreenInner,
                References.KtaneRewritten => SkipTitleScreenRewrittenInner,
                _ => throw s_badValue
            };

            private static bool SkipTitleScreenInner => KTPlayerSettingsManager.Instance.PlayerSettings.SkipTitleScreen;

            private static bool SkipTitleScreenRewrittenInner => RewrittenReferences.SkipTitleScreen;

            /// <summary>
            /// Determines if the VR or regular controllers vibrate.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool RumbleEnabled => Reference switch
            {
                References.None => true,
                References.Ktane => RumbleEnabledInner,
                References.KtaneRewritten => RumbleEnabledRewrittenInner,
                _ => throw s_badValue
            };

            private static bool RumbleEnabledInner => KTPlayerSettingsManager.Instance.PlayerSettings.RumbleEnabled;

            private static bool RumbleEnabledRewrittenInner => RewrittenReferences.RumbleEnabled;

            /// <summary>
            /// Determines if the touchpad controls are inverted.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool TouchpadInvert => Reference switch
            {
                References.None => false,
                References.Ktane => TouchpadInvertInner,
                References.KtaneRewritten => TouchpadInvertRewrittenInner,
                _ => throw s_badValue
            };

            private static bool TouchpadInvertInner => KTPlayerSettingsManager.Instance.PlayerSettings.TouchpadInvert;

            private static bool TouchpadInvertRewrittenInner => RewrittenReferences.TouchpadInvert;

            /// <summary>
            /// Determines if the option to always use mods is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool UseModsAlways => Reference switch
            {
                References.None => false,
                References.Ktane => UseModsAlwaysInner,
                References.KtaneRewritten => UseModsAlwaysRewrittenInner,
                _ => throw s_badValue
            };

            private static bool UseModsAlwaysInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseModsAlways;

            private static bool UseModsAlwaysRewrittenInner => RewrittenReferences.UseModsAlways;

            /// <summary>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="false"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool UseParallelModLoading => Reference switch
            {
                References.None => false,
                References.Ktane => UseParallelModLoadingInner,
                References.KtaneRewritten => UseParallelModLoadingRewrittenInner,
                _ => throw s_badValue
            };

            private static bool UseParallelModLoadingInner => KTPlayerSettingsManager.Instance.PlayerSettings.UseParallelModLoading;

            private static bool UseParallelModLoadingRewrittenInner => RewrittenReferences.UseParallelModLoading;

            /// <summary>
            /// Determines if VR mode is requested.
            /// </summary>
            /// <remarks>
            /// Default: <see langword="true"/>.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static bool VRModeRequested => Reference switch
            {
                References.None => true,
                References.Ktane => VRModeRequestedInner,
                References.KtaneRewritten => VRModeRequestedRewrittenInner,
                _ => throw s_badValue
            };

            private static bool VRModeRequestedInner => KTPlayerSettingsManager.Instance.PlayerSettings.VRModeRequested;

            private static bool VRModeRequestedRewrittenInner => RewrittenReferences.VRModeRequested;

            /// <summary>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </summary>
            /// <remarks>
            /// Default: 8.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static int AntiAliasing => Reference switch
            {
                References.None => 8,
                References.Ktane => AntiAliasingInner,
                References.KtaneRewritten => AntiAliasingRewrittenInner,
                _ => throw s_badValue
            };

            private static int AntiAliasingInner => KTPlayerSettingsManager.Instance.PlayerSettings.AntiAliasing;

            private static int AntiAliasingRewrittenInner => RewrittenReferences.AntiAliasing;

            /// <summary>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static int MusicVolume => Reference switch
            {
                References.None => 100,
                References.Ktane => MusicVolumeInner,
                References.KtaneRewritten => MusicVolumeRewrittenInner,
                _ => throw s_badValue
            };

            private static int MusicVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.MusicVolume;

            private static int MusicVolumeRewrittenInner => RewrittenReferences.MusicVolume;

            /// <summary>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </summary>
            /// <remarks>
            /// Default: 100.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static int SFXVolume => Reference switch
            {
                References.None => 100,
                References.Ktane => SFXVolumeInner,
                References.KtaneRewritten => SFXVolumeRewrittenInner,
                _ => throw s_badValue
            };

            private static int SFXVolumeInner => KTPlayerSettingsManager.Instance.PlayerSettings.SFXVolume;

            private static int SFXVolumeRewrittenInner => RewrittenReferences.SFXVolume;

            /// <summary>
            /// Determines if VSync is on or off.
            /// </summary>
            /// <remarks>
            /// Default: 1.
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static int VSync => Reference switch
            {
                References.None => 1,
                References.Ktane => VSyncInner,
                References.KtaneRewritten => VSyncRewrittenInner,
                _ => throw s_badValue
            };

            private static int VSyncInner => KTPlayerSettingsManager.Instance.PlayerSettings.VSync;

            private static int VSyncRewrittenInner => RewrittenReferences.VSync;

            /// <summary>
            /// The current language code.
            /// </summary>
            /// <remarks>
            /// Default: "en".
            /// </remarks>
            /// <exception cref="NotSupportedException"></exception>
            /// <exception cref="UnrecognizedValueException"></exception>
            public static string LanguageCode => Reference switch
            {
                References.None => "en",
                References.Ktane => LanguageCodeInner,
                References.KtaneRewritten => LanguageCodeRewrittenInner,
                _ => throw s_badValue
            };

            private static string LanguageCodeInner => KTPlayerSettingsManager.Instance.PlayerSettings.LanguageCode;

            private static string LanguageCodeRewrittenInner => RewrittenReferences.LanguageCode;
        }

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
            KtaneRewritten
        }

        internal static bool IsKtane => Reference is References.Ktane;

        /// <summary>
        /// Adds an amount of strikes on the bomb, and returns the bomb object used, or <see langword="null"/>.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="bomb">The <see cref="KMBomb"/> component which is attached to the inner Bomb component.</param>
        /// <param name="strikeDelta">The amount of strikes to add.</param>
        /// <param name="allowExplosion">Whether it should check whether the bomb should explode from strikes.</param>
        /// <returns>The bomb <see cref="object"/> of the bomb used to assign strikes.</returns>
        [CLSCompliant(false)]
        public static object AddStrikes(KMBomb bomb, int strikeDelta, bool allowExplosion) => Reference switch
        {
            References.None => AddStrikesDefault(bomb, strikeDelta),
            References.Ktane => AddStrikesInner(bomb, strikeDelta, allowExplosion),
            References.KtaneRewritten => AddStrikesRewrittenInner(bomb, strikeDelta, allowExplosion),
            _ => throw s_badValue
        };

        private static object AddStrikesDefault(KMBomb bomb, int strikeDelta)
        {
            Self($"Adding the bomb's strike count with {strikeDelta}.");
            return bomb;
        }

        private static object AddStrikesInner(KMBomb bomb, int strikeDelta, bool allowExplosion)
        {
            var inner = (Bomb)(object)bomb.GetComponent(typeof(Bomb));
            StrikesInner(inner, inner.NumStrikes + strikeDelta, allowExplosion);
            return inner;
        }

        private static object AddStrikesRewrittenInner(KMBomb bomb, int strikeDelta, bool allowExplosion)
        {
            RewrittenReferences.AddStrikes(bomb, strikeDelta, allowExplosion);
            return BombRewrittenInner(bomb);
        }

        /// <summary>
        /// Sets the amount of strikes on the bomb, and returns the bomb object used, or <see langword="null"/>.
        /// </summary>
        /// <remarks>
        /// Default: Internal Logger method call.
        /// </remarks>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="bomb">The <see cref="KMBomb"/> component which is attached to the inner Bomb component.</param>
        /// <param name="newStrikes">The strikes to set.</param>
        /// <param name="allowExplosion">Whether it should check whether the bomb should explode from strikes.</param>
        /// <returns>The bomb <see cref="object"/> of the bomb used to assign strikes.</returns>
        [CLSCompliant(false)]
        public static object SetStrikes(KMBomb bomb, int newStrikes, bool allowExplosion) => Reference switch
        {
            References.None => SetStrikesDefault(bomb, newStrikes),
            References.Ktane => SetStrikesInner(bomb, newStrikes, allowExplosion),
            References.KtaneRewritten => SetStrikesRewrittenInner(bomb, newStrikes, allowExplosion),
            _ => throw s_badValue
        };

        private static object SetStrikesDefault(KMBomb bomb, int newStrikes)
        {
            Self($"Setting the bomb's strike count to {newStrikes}.");
            return bomb;
        }

        private static object SetStrikesInner(KMBomb bomb, int strikeCount, bool allowExplosion) => StrikesInner(BombInner(bomb), strikeCount, allowExplosion);

        private static object SetStrikesRewrittenInner(KMBomb bomb, int strikeCount, bool allowExplosion)
        {
            RewrittenReferences.SetStrikes(bomb, strikeCount, allowExplosion);
            return RewrittenReferences.GetBomb(bomb.gameObject);
        }

        private static object StrikesInner(object bomb, int newStrikes, bool allowExplosion)
        {
            var inner = (Bomb)bomb;
            inner.StrikeIndicator.StrikeCount = inner.NumStrikes = newStrikes;

            if (allowExplosion && inner.NumStrikes >= inner.NumStrikesToLose)
                inner.Detonate();

            return bomb;
        }

        /// <summary>
        /// Gets the game's internal bomb component, not to be mistaken with <see cref="KMBomb"/>. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to Bomb or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: An encapsulated method that takes a <see cref="GameObject"/> and always returns the argument passed in.
        /// </remarks>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="bomb">The <see cref="KMBomb"/> instance that is on the same <see cref="GameObject"/> as the Bomb component.</param>
        /// <returns>The internal Bomb <see cref="Component"/> that the game uses.</returns>
        [CLSCompliant(false)]
        public static object Bomb(KMBomb bomb) => Reference switch
        {
            References.None => bomb,
            References.Ktane => BombInner(bomb),
            References.KtaneRewritten => BombRewrittenInner(bomb),
            _ => throw s_badValue
        };

        private static object BombInner(KMBomb bomb) => bomb.GetComponent(typeof(Bomb));

        private static object BombRewrittenInner(KMBomb bomb) => RewrittenReferences.GetBomb(bomb.gameObject);

        /// <summary>
        /// Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to TimerComponent or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: An encapsulated method that takes a <see cref="GameObject"/> and always returns the argument passed in.
        /// </remarks>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="bomb">The <see cref="KMBomb"/> instance that is on the same <see cref="GameObject"/> as the Bomb component, which is needed to access the Timer component.</param>
        /// <returns>The internal Timer <see cref="Component"/> that the game uses.</returns>
        [CLSCompliant(false)]
        public static object Timer(KMBomb bomb) => Reference switch
        {
            References.None => bomb,
            References.Ktane => TimerInner(bomb),
            References.KtaneRewritten => TimerRewrittenInner(bomb),
            _ => throw s_badValue
        };

        private static object TimerInner(KMBomb bomb) => ((Bomb)BombInner(bomb)).GetTimer();

        private static object TimerRewrittenInner(KMBomb bomb) => RewrittenReferences.GetTimer(bomb.gameObject);

        /// <summary>
        /// Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an <see cref="object"/> <see cref="Array"/>. You can cast it to BombComponent type to restore its functionality.
        /// </summary>
        /// <remarks>
        /// Default: An encapsulated method that takes a <see cref="GameObject"/> and always returns an empty <see cref="object"/> <see cref="Array"/>.
        /// </remarks>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="bomb">The <see cref="KMBomb"/> instance that is the parent <see cref="GameObject"/> to all vanilla modules.</param>
        /// <returns>All vanilla modules on the current <paramref name="bomb"/>.</returns>
        [CLSCompliant(false)]
        public static object[] Vanillas(KMBomb bomb) => Reference switch
        {
            References.None => new object[0],
            References.Ktane => VanillasInner(bomb),
            References.KtaneRewritten => VanillasRewrittenInner(bomb),
            _ => throw s_badValue
        };

        private static object[] VanillasInner(KMBomb bomb) => bomb
            .GetComponentsInChildren(typeof(BombComponent))
            .Where(c => !(c.GetComponent<KMBombModule>() || c.GetComponent<KMNeedyModule>()))
            .Cast<object>()
            .ToArray();

        private static object[] VanillasRewrittenInner(KMBomb bomb) => RewrittenReferences.GetVanillas(bomb);

        /// <summary>
        /// Determines what reference this library should use for the current class. This value can only be modified by the libraries featured in <see cref="References"/>, a <see cref="SecurityException"/> is thrown when this is attempted regardless.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="SecurityException"></exception>
        public static References Reference
        {
            get => s_references;
            set => s_references = new StackFrame(1).GetMethod().ReflectedType.Assembly.FullName is "Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"
                    ? Helper.GetValues<References>().Any(r => r == value)
                    ? value
                    : throw new ArgumentException($"The value \"{value}\" is not valid!")
                    : throw new SecurityException($"The library \"{new StackFrame(1).GetMethod().ReflectedType.NameOfAssembly()}\" does not have permission to edit this value!");
        }

        private static References s_references = isEditor ? References.None : References.Ktane;
    }
}
