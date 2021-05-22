using System.Collections;
using System.Collections.Generic;

namespace KeepCoding
{
    /// <summary>
    /// Interface for Twitch Plays support. Written by Emik.
    /// </summary>
    public interface ITP
    {
        /// <value>
        /// Determines if it should allow for the timer to be skipped when the module it is in, as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb. 
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public bool IsTimeSkippable { get; set; }

        /// <value>
        /// Determines if it should cancel command processing. If this returns true, then stop processing the command, clean up, then do a <c>yield return Cancelled;</c> to acknowledge the cancel.
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public bool IsCancelCommand { get; }

        /// <value>
        /// Determines if it is in Time Mode, where solves change the timer. This is useful for modules that use the timer's value.
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public bool IsTimeMode { get; }

        /// <value>
        /// Determines if Twitch Plays is currently active. This is for modules that need to display different items, or use different rules if Twitch Plays is active.
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public bool IsTP { get; }

        /// <value>
        /// Determines if the timer is counting up instead of down, for special cases, such as controlling how to sort button release times, or whether there is a low timer event or not.
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public bool IsZenMode { get; }

        /// <value>
        /// Declaring this field allows for Twitch Plays to inform the module that the bomb is in Time Mode, where solves change the timer. This is useful for modules that use the timer's value.
        /// </value>
        /// <remarks>
        /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in <see cref="KMBombModule.OnActivate"/> or <see cref="KMNeedyModule.OnActivate"/> or later.
        /// </remarks>
        public List<KMBombModule> AbandonModule { get; set; }

        /// <summary>
        /// Sends a message to the Twitch Plays mod.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void Send(string message);

        /// <summary>
        /// When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.
        /// </summary>
        /// <remarks>
        /// Anything that gets yield returned will be processed by Twitch Plays. This includes other <see cref="IEnumerable"/> methods, <see cref="KMSelectable"/>, an <see cref="System.Array"/> of <see cref="KMSelectable"/>, <see cref="string"/>, <c>true</c>, or <c>null</c>.
        /// </remarks>
        /// <param name="command">The user's command.</param>
        /// <returns>A series of instructions for the Twitch Plays mod to handle as requested by the user.</returns>
        public IEnumerator ProcessTwitchCommand(string command);

        /// <summary>
        /// When the module runs into an exception or the module is forced to be solved, it calls this method.
        /// </summary>
        /// <remarks>
        /// Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.
        /// </remarks>
        /// <returns>A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.</returns>
        public IEnumerator TwitchHandleForcedSolve();
    }
}
