namespace KeepCoding
{
    /// <summary>
    /// Interface for regular and needy modded modules. Written by Emik.
    /// </summary>
    public interface IModule
    {
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
