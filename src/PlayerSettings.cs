using Manager = Assets.Scripts.Settings.PlayerSettingsManager;

namespace KeepCoding.v131
{
    /// <summary>
    /// Allows access into the player settings from the game. Do not use this class in the unity editor.
    /// </summary>
    public static class PlayerSettings
    {
        /// <value>
        /// Determines if vertical tilting is flipped or not.
        /// </value>
        public static bool InvertTiltControls => Manager.Instance.PlayerSettings.InvertTiltControls;

        /// <summary>
        /// Determines if the option to lock the mouse to the window is enabled.
        /// </summary>
        public static bool LockMouseToWindow => Manager.Instance.PlayerSettings.LockMouseToWindow;

        /// <summary>
        /// Determines if the option to show the leaderboards from the pamphlet.
        /// </summary>
        public static bool ShowLeaderBoards => Manager.Instance.PlayerSettings.ShowLeaderBoards;

        /// <summary>
        /// Determines if the option to show the rotation of the User Interface is enabled.
        /// </summary>
        public static bool ShowRotationUI => Manager.Instance.PlayerSettings.ShowRotationUI;

        /// <summary>
        /// Determines if the option to show scanlines is enabled.
        /// </summary>
        public static bool ShowScanline => Manager.Instance.PlayerSettings.ShowScanline;

        /// <summary>
        /// Determines if the option to skip the title screen is enabled.
        /// </summary>
        public static bool SkipTitleScreen => Manager.Instance.PlayerSettings.SkipTitleScreen;

        /// <value>
        /// Determines if the VR or regular controllers vibrate.
        /// </value>
        public static bool RumbleEnabled => Manager.Instance.PlayerSettings.RumbleEnabled;

        /// <value>
        /// Determines if the touchpad controls are inverted.
        /// </value>
        public static bool TouchpadInvert => Manager.Instance.PlayerSettings.TouchpadInvert;

        /// <summary>
        /// Determines if the option to always use mods is enabled.
        /// </summary>
        public static bool UseModsAlways => Manager.Instance.PlayerSettings.UseModsAlways;

        /// <summary>
        /// Determines if the option to use parallel/simultaneous mod loading is enabled.
        /// </summary>
        public static bool UseParallelModLoading => Manager.Instance.PlayerSettings.UseParallelModLoading;

        /// <summary>
        /// Determines if VR mode is requested.
        /// </summary>
        public static bool VRModeRequested => Manager.Instance.PlayerSettings.VRModeRequested;

        /// <summary>
        /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
        /// </summary>
        public static int AntiAliasing => Manager.Instance.PlayerSettings.AntiAliasing;

        /// <value>
        /// The current music volume from the dossier menu. Ranges 0 to 100.
        /// </value>
        public static int MusicVolume => Manager.Instance.PlayerSettings.MusicVolume;

        /// <summary>
        /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
        /// </summary>
        public static int SFXVolume => Manager.Instance.PlayerSettings.SFXVolume;

        /// <summary>
        /// Determines if VSync is on or off.
        /// </summary>
        public static int VSync => Manager.Instance.PlayerSettings.VSync;

        /// <value>
        /// The current language code.
        /// </value>
        public static string LanguageCode => Manager.Instance.PlayerSettings.LanguageCode;
    }
}
