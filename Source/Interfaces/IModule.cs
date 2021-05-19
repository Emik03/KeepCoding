namespace KeepCoding
{
    /// <summary>
    /// Interface for regular and needy modded modules. Written by Emik.
    /// </summary>
    public interface IModule
    {
        /// <value>
        /// Determines whether this module is the last instantiated instance.
        /// </value>
        public bool IsLastInstantiated { get; }

        /// <value>
        /// The version number of the entire mod.
        /// </value>
        public string Version { get; }

        /// <summary>
        /// Called when the lights turn on.
        /// </summary>
        public void OnActivate();

        /// <summary>
        /// Called when the timer's seconds-digit changes.
        /// </summary>
        public void OnTimerTick();
    }
}
