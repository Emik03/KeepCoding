using System;
using System.Collections.Generic;
using UnityEngine;

namespace KeepCoding
{
    extern alias core;

    /// <summary>
    /// Allows access into the game's internal code. Written by Emik.
    /// </summary>
    /// <remarks>
    /// You should avoid calling this class from the Editor as it uses the game assembly as a dependancy.
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
        /// Allows access into Twitch Plays messaging system.
        /// </summary>
        public static class IRCConnection
        {
            /// <value>
            /// Sends a message to the chat.
            /// </value>
            /// <remarks>Arguments: <c>message</c>.</remarks>
            public static Action<string> SendMessage => message => Debug.Log($"Sending message to chat: {message}");

            /// <value>
            /// Sends a message to the chat.
            /// </value>
            /// <remarks>Arguments: <c>message</c> and <c>args</c>.</remarks>
            public static Action<string, object[]> SendMessageFormat => (message, args) => Debug.Log($"Sending message to chat: {message.Form(args)}");
                           
            /// <value>
            /// Whispers a message to a person.
            /// </value>
            /// <remarks>Arguments: <c>userNickName</c>, <c>message</c>, and <c>args</c>.</remarks>
            public static Action<string, string, object[]> SendWhisper => (userNickName, message, args) => Debug.Log($"Whispering message to user {userNickName}: {message.Form(args)}");
        }

        /// <summary>
        /// Allows access relating to how the game is being interacted with.
        /// </summary>
        public static class KTInputManager
        {
            /// <value>
            /// Determines if the current way the game is being controlled is VR-related.
            /// </value>
            public static bool IsCurrentControlTypeVR => CurrentControlType is ControlType.Gaze || CurrentControlType is ControlType.Motion || CurrentControlType is ControlType.ThreeDOF;

            /// <value>
            /// The current way the game is being controlled.
            /// </value>
            public static ControlType CurrentControlType => ControlType.Mouse;
        }

        /// <summary>
        /// Allows access relating to the current mission.
        /// </summary>
        public static class Mission
        {
            /// <value>
            /// Determines whether or not all pacing events are enabled.
            /// </value>
            public static bool IsPacingEvents => false;

            /// <value>
            /// The description as it appears in the bomb binder.
            /// </value>
            public static string Description => "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.";

            /// <value>
            /// The mission name as it appears in the bomb binder.
            /// </value>
            public static string DisplayName => "The First Bomb";

            /// <value>
            /// The ID of the mission.
            /// </value>
            public static string ID => "firsttime";

            /// <value>
            /// Gets the generator setting of the mission.
            /// </value>
            public static GeneratorSetting GeneratorSetting => new GeneratorSetting();
        }

        /// <summary>
        /// Allows access to methods relating mod paths.
        /// </summary>
        public static class ModManager
        {
            /// <value>
            /// Gets all of the disabled mod paths.
            /// </value>
            public static Func<List<string>> GetDisabledModPaths => () => new List<string>();

            /// <value>
            /// Gets all of the mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            public static Func<ModSourceEnum, List<string>> GetAllModPathsFromSource => source => new List<string>();

            /// <value>
            /// Gets all of the enabled mod paths within the <see cref="ModSourceEnum"/> constraint.
            /// </value>
            public static Func<ModSourceEnum, List<string>> GetEnabledModPaths => source => new List<string>();
        }

        /// <summary>
        /// Allows access into the player settings from the game. Do not use this class in the unity editor. Written by Emik.
        /// </summary>
        public static class PlayerSettings
        {
            /// <value>
            /// Determines if vertical tilting is flipped or not.
            /// </value>
            public static bool InvertTiltControls => false;

            /// <value>
            /// Determines if the option to lock the mouse to the window is enabled.
            /// </value>
            public static bool LockMouseToWindow => false;

            /// <value>
            /// Determines if the option to show the leaderboards from the pamphlet.
            /// </value>
            public static bool ShowLeaderBoards => true;

            /// <value>
            /// Determines if the option to show the rotation of the User Interface is enabled.
            /// </value>
            public static bool ShowRotationUI => true;

            /// <value>
            /// Determines if the option to show scanlines is enabled.
            /// </value>
            public static bool ShowScanline => true;

            /// <value>
            /// Determines if the option to skip the title screen is enabled.
            /// </value>
            public static bool SkipTitleScreen => false;

            /// <value>
            /// Determines if the VR or regular controllers vibrate.
            /// </value>
            public static bool RumbleEnabled => false;

            /// <value>
            /// Determines if the touchpad controls are inverted.
            /// </value>
            public static bool TouchpadInvert => false;

            /// <value>
            /// Determines if the option to always use mods is enabled.
            /// </value>
            public static bool UseModsAlways => false;

            /// <value>
            /// Determines if the option to use parallel/simultaneous mod loading is enabled.
            /// </value>
            public static bool UseParallelModLoading => false;

            /// <value>
            /// Determines if VR mode is requested.
            /// </value>
            public static bool VRModeRequested => true;

            /// <value>
            /// The intensity of anti-aliasing currently on the game. Ranges 0 to 8.
            /// </value>
            public static int AntiAliasing => 8;

            /// <value>
            /// The current music volume from the dossier menu. Ranges 0 to 100.
            /// </value>
            public static int MusicVolume => 100;

            /// <value>
            /// The current sound effects volume from the dosssier menu. Ranges 0 to 100.
            /// </value>
            public static int SFXVolume => 100;

            /// <value>
            /// Determines if VSync is on or off.
            /// </value>
            public static int VSync => 1;

            /// <value>
            /// The current language code.
            /// </value>
            public static string LanguageCode => "en";
        }

        /// <value>
        /// Gets the game's internal bomb component, not to be mistaken with <see cref="KMBomb"/>.
        /// </value>
        /// <remarks>
        /// To prevent a reference to the game, the type is boxed in <see cref="object"/>. You can cast it to Bomb or <see cref="MonoBehaviour"/> type to restore its functionality.
        /// </remarks>
        public static Func<GameObject, object> Bomb => gameObject => null;
    }
}
