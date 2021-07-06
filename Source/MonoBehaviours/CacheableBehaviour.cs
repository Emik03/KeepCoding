using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// A <see cref="MonoBehaviour"/> with additional caching capabilities. Written by Emik.
    /// </summary>
    public class CacheableBehaviour : MonoBehaviour
    {
        private readonly Dictionary<Type, Component[]> _components = new Dictionary<Type, Component[]>();

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <remarks>
        /// <see cref="GameObject.GetComponent{T}"/> and <see cref="GameObject.GetComponents{T}()"/> have their own implementations already, so use these functions instead for that purpose; 
        /// <seealso cref="Get{T}(bool)"/>, <seealso cref="GetAll{T}(bool)"/>
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T[] Cache<T>(Func<T[]> func, bool allowNull = false) where T : Component
        {
            if (!_components.ContainsKey(typeof(T)))
                _components.Add(typeof(T), func());

            return allowNull || !_components[typeof(T)].IsNullOrEmpty() ? (T[])_components[typeof(T)] : throw new MissingComponentException($"Tried to get component {typeof(T).Name} from {this}, but was unable to find one.");
        }

        /// <summary>
        /// Similar to <see cref="UnityEngine.Object.FindObjectsOfType{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Find<T>(bool allowNull = false) where T : Component => FindAll<T>(allowNull).FirstOrDefault();

        /// <summary>
        /// Similar to <see cref="UnityEngine.Object.FindObjectsOfType{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] FindAll<T>(bool allowNull = false) where T : Component => Cache(FindObjectsOfType<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="Component.GetComponent{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Get<T>(bool allowNull = false) where T : Component => GetAll<T>(allowNull).FirstOrDefault();

        /// <summary>
        /// Similar to <see cref="GameObject.GetComponents{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <remarks>
        /// Use this in-place of public fields that refer to itself.
        /// </remarks>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] GetAll<T>(bool allowNull = false) where T : Component => Cache(GetComponents<T>, allowNull);
    }
}
