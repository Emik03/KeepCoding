using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Base class for TwitchPlays support for regular and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.
    /// </summary>
    public abstract class TPScript<T> : MonoBehaviour where T : ModuleScript
    {
        /// <summary>
        /// The help message that gets sent when typing <c>!{0} help</c>.
        /// </summary>
        public string TwitchHelpMessage;

        /// <summary>
        /// When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.
        /// </summary>
        /// <remarks>
        /// Anything that gets yield returned will be processed by Twitch Plays. This includes other <see cref="IEnumerable"/> methods, <see cref="KMSelectable"/>, an <see cref="System.Array"/> of <see cref="KMSelectable"/>, <see cref="string"/>, <c>true</c>, or <c>null</c>.
        /// </remarks>
        /// <param name="command">The user's command.</param>
        /// <returns>A series of instructions for the Twitch Plays mod to handle as requested by the user.</returns>
        protected abstract IEnumerator ProcessTwitchCommand(string command);

        /// <summary>
        /// When the module runs into an exception or the module is forced to be solved, it calls this method.
        /// </summary>
        /// <remarks>
        /// Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.
        /// </remarks>
        /// <returns>A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.</returns>
        protected abstract IEnumerator TwitchHandleForcedSolve();

        /// <summary>
        /// These values are set by the Twitch Plays mod using reflection.
        /// </summary>
        protected bool TimeModeActive, TwitchPlaysActive, TwitchPlaysSkipTimeAllowed, TwitchShouldCancelCommand, ZenModeActive;

        /// <summary>
        /// Declaring this field allows for Twitch Plays to inform the module that the bomb is in Time Mode, where solves change the timer. This is useful for modules that use the timer's value. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, therefore the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </summary>
        protected List<KMBombModule> TwitchAbandonModule;

        /// <value>
        /// The instance of the module.
        /// </value>
        protected T Module { get => _module ??= GetComponent<T>() ?? throw new UnityComponentNotFoundException("TPScript cannot find your ModuleScript. Make sure that both script files are in the same game object!"); }
        private T _module;

        /// <summary>
        /// Yield return this to indicate that this command will cause a strike at some later point; all this does is tell Twitch Plays to attribute the strike to the author of this command.
        /// </summary>
        protected const string Strike = "strike";

        /// <summary>
        /// Yield return this to indicate that this command will solve the module at some later point; all this does is tell Twitch Plays to attribute the solve to the author of this command.
        /// </summary>
        protected const string Solve = "solve";

        /// <summary>
        /// Yield return this to indicate that the command couldn't submit an answer and should only be used to prevent users from guessing the answer. This should not be used if an answer could never be submittable for a module.
        /// </summary>
        protected const string UnsubmittablePenalty = "unsubmittablepenalty";

        /// <summary>
        /// Yield return this to indicate that the <c>KMSelectable[]</c> sequence that follows this command should be cancelled if a "!cancel" or "!stop" is issued mid-way through that sequence.
        /// </summary>
        protected const string TryCancelSequence = "trycancelsequence";

        /// <summary>
        /// Yield return this to indicate that you have stopped processing the command in response to the <see cref="TwitchShouldCancelCommand"/> bool being set to true.
        /// </summary>
        protected const string Cancelled = "cancelled";

        /// <summary>
        /// Yield return this to indicate that the issued command is going to cause more than one strike, so should disable the internal strike tracker in order to avoid flooding the chat with "VoteNay Module {id} got a strike! +1 strike to {Nickname}" for as many strikes as will be awarded. This also disables the internal solve tracker as well. This allows for sending additional messages or continue processing commands regardless of the solve/strike state.
        /// </summary>
        protected const string MultipleStrikes = "multiple strikes";

        /// <summary>
        /// Yield return this to indicate that the strike tracker should be enabled. If any strikes were issued during the time it was disabled, they will be awarded and the routine stopped at that point, otherwise, it will just cancel the "VoteNay Module {id} got 0 strikes! +0 strike to {Nickname}" message that would otherwise be posted. Likewise, if the module was solved at the time this command is issued, the processing will be stopped as of that point as well.
        /// </summary>
        protected const string EndMultipleStrikes = "end multiple strikes";

        /// <summary>
        /// Yield return this to indicate automatically solving the module, as if it threw an exception while solving.
        /// </summary>
        protected const string AutoSolve = "autosolve";

        /// <summary>
        /// Yield return this to indicate cancelling a previously issued delayed detonation command on the same module.
        /// </summary>
        protected const string CancelDetonate = "cancel detonate";

        /// <summary>
        /// Yield return this to indicate playing the waiting music if a command will take long to finish.
        /// </summary>
        protected const string WaitingMusic = "waiting music";

        /// <summary>
        /// Yield return this to indicate stopping the waiting music mid-command.
        /// </summary>
        protected const string EndWaitingMusic = "end waiting music";

        /// <summary>
        /// Yield return this to toggle the waiting music on and off mid-command.
        /// </summary>
        protected const string ToggleWaitingMusic = "toggle waiting music";

        /// <summary>
        /// Yield return this to hide the heads-up display and cameras while doing quaternion rotations, if it is expected that the camera/hud will get in the way.
        /// </summary>
        protected const string HideCamera = "hide camera";

        /// <summary>
        /// Presses a sequence of buttons according to <paramref name="indices"/> within <paramref name="selectables"/>, waiting <paramref name="wait"/> seconds in-between each, and interrupting as soon as <see cref="ModuleScript.IsStrike"/> is true.
        /// </summary>
        /// <param name="selectables">The array of selectables to interact with.</param>
        /// <param name="indices">The indices to press within the array.</param>
        /// <param name="wait">The delay between each button press in seconds.</param>
        /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
        protected IEnumerator OnInteractSequence(KMSelectable[] selectables, float wait, params int[] indices)
        {
            Module.IsStrike = false;

            for (int i = 0; i < indices.Length && !Module.IsStrike; i++)
            {
                selectables[indices[i]].OnInteract();
                yield return new WaitForSecondsRealtime(wait);
            }

            Module.IsStrike = false;
        }

        /// <summary>
        /// Determines whether the input string matches the regex of the pattern.
        /// </summary>
        /// <param name="input">The test string.</param>
        /// <param name="pattern">The regular expression.</param>
        /// <param name="lenient">Whether it should add the default <c>^\s* PATTERN \s*$</c> embeded into most regex usages for Twitch Plays.</param>
        /// <param name="options">Any additional options for regular expressions.</param>
        /// <returns>True if <paramref name="input"/> passes the test of the <paramref name="pattern"/>.</returns>
        protected static bool IsMatch(string input, string pattern, bool lenient = true, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.CultureInvariant) => Regex.IsMatch(input, lenient ? @"^\s*" + pattern + @"\s*$" : pattern, options);

        /// <summary>
        /// Works as a ternary operator. Returns <paramref name="then"/> if <paramref name="condition"/> is true, otherwise <paramref name="otherwise"/>.
        /// </summary>
        /// <remarks>
        /// You can yield return this to send error messages or interactions by first checking for the condition.
        /// </remarks>
        /// <param name="condition">The boolean to check.</param>
        /// <param name="then">The output to return if <paramref name="condition"/> is true.</param>
        /// <param name="otherwise">The output to return if <paramref name="condition"/> is false.</param>
        /// <returns><paramref name="then"/> or <paramref name="otherwise"/>, depending on <paramref name="condition"/>.</returns>
        protected static object Evaluate(bool condition, object then, object otherwise = null) => condition ? then : otherwise;

        /// <summary>
        /// Yield return this to allow you to tell the user why they got a strike if it isn't clear.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string StrikeMessage(string message) => AppendIfNotNullOrEmpty("strikemessage", message);

        /// <summary>
        /// Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield. Just know that you won't be able to clean up if you do your cancel this way, and there is a pending !cancel or !stop.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string TryCancel(string message = null) => AppendIfNotNullOrEmpty("trycancel", message);

        /// <summary>
        /// Yield return this to cause Twitch Plays to wait for the given time, and any time during the entire duration, the command may cancel. Like "trycancel", you won't be able to clean up if you cancel this way. Also like "trycancel", <paramref name="message"/> is optional.
        /// </summary>
        /// <param name="time">The amount of time to wait.</param>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string TryWaitCancel(float time, string message = null) => AppendIfNotNullOrEmpty("strikemessage", time, message);

        /// <summary>
        /// Yield return this to send a chat directly to twitch chat.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string SendToChat(string message) => AppendIfNotNullOrEmpty("sendtochat", message);

        /// <summary>
        /// Yield return this to send a message to the chat about why a users' command was invalid.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string SendToChatError(string message) => AppendIfNotNullOrEmpty("sendtochaterror ", message);

        /// <summary>
        /// Yield return this to send a message to chat after <paramref name="time"/> seconds.
        /// </summary>
        /// <param name="time">The amount of time to wait before the message gets sent.</param>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string SendDelayedMessage(float time, string message) => AppendIfNotNullOrEmpty("senddelayedmessage", time, message);

        /// <summary>
        /// Yield return this to explode the bomb instantly. <paramref name="time"/> is specified in number of seconds before the bomb explodes. (Note, sending another detonate command will auto-cancel the previous one on the same module if it hasn't happened already.). <paramref name="message"/> is the message to send to chat upon detonation. Both of the parameters are optional.
        /// </summary>
        /// <param name="time">The amount of time before the bomb blows up.</param>
        /// <param name="message">The message to send.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string Detonate(float? time = null, string message = null) => AppendIfNotNullOrEmpty("detonate", time, message);

        /// <summary>
        /// Yield return this to try advancing the clock to the specified time. You must put the full time you wish to skip to, and this time either needs to be less than the current time, if in normal/time mode, or greater than the current time, if in zen mode. Example, if you wanted to set the clock to 5:24, then you do "skiptime 324" or "skiptime 5:24". You can target partway through the seconds, such as "skiptime 45.28", which would then set the clock to 45.28, provided that time has NOT gone by already. You must also declare the <see cref="TwitchPlaysSkipTimeAllowed"/> bool, and set it to true, for this function to work.
        /// </summary>
        /// <param name="seconds">The time to skip to in seconds.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string SkipTime(string seconds = null) => AppendIfNotNullOrEmpty("skiptime", seconds);

        /// <summary>
        /// Yield return this to award the user that sent the command points directly, this is currently used for mods like Souvenir to give points to users that answered the questions equally.
        /// </summary>
        /// <param name="points">The amount of points to award. Negatives supported.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string AwardPoints(int points) => AppendIfNotNullOrEmpty("awardpoints", points);

        /// <summary>
        /// Yield return this to award the last user that sent the command points when the module is solved. The module must prevent any user from sending commands afterward in order for Twitch Plays to award points to the correct user. This is currently used by the Twin module when extra points must be given but the module is not solved immediately.
        /// </summary>
        /// <param name="points">The amount of points to award. Negatives supported.</param>
        /// <returns>A formatted string for Twitch Plays.</returns>
        protected static string AwardPointsOnSolve(int points) => AppendIfNotNullOrEmpty("awardpointsonsolve", points);

        private static string AppendIfNotNullOrEmpty(string main, params object[] toAppend)
        {
            for (int i = 0; i < toAppend.LengthOrDefault(); i++)
                main += ' ' + toAppend[i].ToString();

            return main;
        }
    }
}
