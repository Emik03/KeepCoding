﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Abstract class for the <see cref="Routine"/> datatype, since the different overloads are similar to each other. Written by Emik.
    /// </summary>
    public abstract class RoutineBase
    {
        internal RoutineBase(MonoBehaviour monoBehaviour)
        {
            Coroutines = new List<Coroutine>();
            MonoBehaviour = monoBehaviour;
        }

        /// <summary>
        /// Stops the first coroutine that was called, and removes it from the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void Stop()
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            MonoBehaviour.StopCoroutine(Coroutines[0]);

            Coroutines = Coroutines.Skip(1).ToList();
        }

        /// <summary>
        /// Stops all instances of the coroutine, and clears the list of coroutines.
        /// </summary>
        /// <exception cref="EmptyIteratorException"></exception>
        public void StopAll()
        {
            if (Coroutines.Count == 0)
                throw new EmptyIteratorException("Coroutines is empty.");

            foreach (var coroutine in Coroutines)
                MonoBehaviour.StopCoroutine(coroutine);

            Coroutines = new List<Coroutine>();
        }

        /// <value>
        /// Determines whether it is currently running any coroutines.
        /// </value>
        public bool IsRunning { get; private protected set; }

        /// <value>
        /// The list of all coroutines currently running.
        /// </value>
        public List<Coroutine> Coroutines { get; set; }

        /// <value>
        /// The MonoBehaviour that is being used to start the coroutines.
        /// </value>
        private protected MonoBehaviour MonoBehaviour { get; set; }
    }
}
