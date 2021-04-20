using System;
using System.Collections.Generic;
using Player = Assets.Scripts.Settings.PlayerSettingsManager;
using Manager = ModManager;
using Info = Assets.Scripts.Mods.ModInfo;

namespace KeepCoding.v151
{
    extern alias core;

    /// <summary>
    /// Allows access into the game's internal code. Written by Emik.
    /// </summary>
    /// <remarks>
    /// You should avoid calling this class from the Editor as it uses the game assembly as a dependancy. Written by Emik.
    /// </remarks>
    public static class Game
    {
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
        /// Allows access to methods relating mod paths.
        /// </summary>
        public static class ModManager
        {
            /// <value>
            /// Gets all of the disabled mod paths.
            /// </value>
            public static Func<List<string>> GetDisabledModPaths => Manager.Instance.GetDisabledModPaths;

            /// <value>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => source => Manager.Instance.GetAllModPathsFromSource((Info.ModSourceEnum)source);

            /// <value>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => source => Manager.Instance.GetEnabledModPaths((Info.ModSourceEnum)source);
        }

        /// <summary>
        /// Allows access into the player settings from the game. Do not use this class in the unity editor. Written by Emik.
        /// </summary>
        public static class PlayerSettings
        {
            /// <value>
            /// Determines if vertical tilting is flipped or not.
            /// </value>
            public static bool InvertTiltControls => Player.Instance.PlayerSettings.InvertTiltControls;

            /// <summary>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </summary>
            public static bool LockMouseToWindow => Player.Instance.PlayerSettings.LockMouseToWindow;

            /// <summary>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </summary>
            public static bool ShowLeaderBoards => Player.Instance.PlayerSettings.ShowLeaderBoards;

            /// <summary>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </summary>
            public static bool ShowRotationUI => Player.Instance.PlayerSettings.ShowRotationUI;

            /// <summary>
            /// Determines if the option to show scanlines is enabled.
            /// </summary>
            public static bool ShowScanline => Player.Instance.PlayerSettings.ShowScanline;

            /// <summary>
            /// Determines if the option to skip the title screen is enabled.
            /// </summary>
            public static bool SkipTitleScreen => Player.Instance.PlayerSettings.SkipTitleScreen;

            /// <value>
            /// Determines if the VR or regular controllers vibrate.
            /// </value>
            public static bool RumbleEnabled => Player.Instance.PlayerSettings.RumbleEnabled;

            /// <value>
            /// Determines if the touchpad controls are inverted.
            /// </value>
            public static bool TouchpadInvert => Player.Instance.PlayerSettings.TouchpadInvert;

            /// <summary>
            /// Determines if the option to always use mods is enabled.
            /// </summary>
            public static bool UseModsAlways => Player.Instance.PlayerSettings.UseModsAlways;

            /// <summary>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </summary>
            public static bool UseParallelModLoading => Player.Instance.PlayerSettings.UseParallelModLoading;

            /// <summary>
            /// Determines if VR mode is requested.
            /// </summary>
            public static bool VRModeRequested => Player.Instance.PlayerSettings.VRModeRequested;

            /// <summary>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </summary>
            public static int AntiAliasing => Player.Instance.PlayerSettings.AntiAliasing;

            /// <value>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </value>
            public static int MusicVolume => Player.Instance.PlayerSettings.MusicVolume;

            /// <summary>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </summary>
            public static int SFXVolume => Player.Instance.PlayerSettings.SFXVolume;

            /// <summary>
            /// Determines if VSync is on or off.
            /// </summary>
            public static int VSync => Player.Instance.PlayerSettings.VSync;

            /// <value>
            /// The current language code.
            /// </value>
            public static string LanguageCode => Player.Instance.PlayerSettings.LanguageCode;
        }
    }
}
