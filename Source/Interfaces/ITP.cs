using System.Collections;

namespace KeepCoding
{
    /// <summary>
    /// Interface for Twitch Plays support. Written by Emik.
    /// </summary>
    public interface ITP
    {
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

    /// <summary>
    /// Interface for Twitch Plays support. Written by Emik.
    /// </summary>
    public interface ITP<TModule> : ITP where TModule : ModuleScript
    {
        /// <value>
        /// The instance of the module.
        /// </value>
        public TModule Module { get; }
    }
}
