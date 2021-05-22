using System;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Interface for solvable and needy modded modules. Written by Emik.
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

        /// <value>
        /// Gets the Twitch Plays <see cref="Component"/> attached to this <see cref="GameObject"/>.
        /// </value>
        /// <remarks>
        /// Due to type ambiguity, a non-generic interface is returned.
        /// </remarks>
        public ITP TP { get; }

        /// <summary>
        /// Called when the lights turn on.
        /// </summary>
        public void OnActivate();

        /// <summary>
        /// Called when the timer's seconds-digit changes.
        /// </summary>
        public void OnTimerTick();

        /// <summary>
        /// Called when any module on the current bomb has been solved.
        /// </summary>
        /// <param name="moduleId">The sender's module id, which caused a strike.</param>
        public void OnModuleStrike(string moduleId);

        /// <summary>
        /// Called when any <see cref="KMNeedyModule"/> on the current bomb has been solved.
        /// </summary>
        /// <param name="moduleId">The sender's module id, which was solved.</param>
        public void OnNeedySolved(string moduleId);

        /// <summary>
        /// Called when any <see cref="KMBombModule"/> on the current bomb has been solved.
        /// </summary>
        /// <param name="moduleId">The sender's module id, which was solved.</param>
        public void OnSolvableSolved(string moduleId);
    }
}
