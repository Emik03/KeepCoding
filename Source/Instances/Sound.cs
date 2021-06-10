using System;
using System.Collections.Generic;
using UnityEngine;
using static KMAudio;
using static KMSoundOverride;

namespace KeepCoding
{
    /// <summary>
    /// Class meant to encapsulate all types of sound effects <see cref="KMAudio"/> uses. Currently used in <see cref="ModuleScript"/>. Written by Emik.
    /// </summary>
    public sealed class Sound : IEquatable<Sound>
    {
        /// <summary>
        /// An instance of Sound where <see cref="Custom"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        public Sound(string sound) => Custom = sound.NullCheck("The string provided is null!");

        /// <summary>
        /// An instance of Sound where <see cref="Custom"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        public Sound(AudioClip sound) => Custom = sound.NullCheck("The AudioClip provided is null!").name;

        /// <summary>
        /// An instance of sound where <see cref="Game"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        public Sound(SoundEffect sound) => Game = sound; 

        /// <summary>
        /// The custom sound, written out by name.
        /// </summary>
        public string Custom { get; }

        /// <summary>
        /// The audio reference that is playing the sound.
        /// </summary>
        public KMAudioRef Reference { get; internal set; }

        /// <summary>
        /// The in-game sound.
        /// </summary>
        public SoundEffect? Game { get; }

        /// <summary>
        /// An instance of Sound where <see cref="Custom"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        /// <returns><see cref="Sound"/> with argument <paramref name="sound"/>.</returns>
        public static implicit operator Sound(string sound) => new Sound(sound);

        /// <summary>
        /// An instance of Sound where <see cref="Custom"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        /// <returns><see cref="Sound"/> with argument <paramref name="sound"/>.</returns>
        public static implicit operator Sound(AudioClip sound) => new Sound(sound);

        /// <summary>
        /// An instance of Sound where <see cref="Game"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        /// <returns><see cref="Sound"/> with argument <paramref name="sound"/>.</returns>
        public static implicit operator Sound(SoundEffect sound) => new Sound(sound);

        /// <summary>
        /// Returns <see cref="Custom"/> for the current variable.
        /// </summary>
        /// <param name="sound">The variable to grab the property from.</param>
        /// <returns><paramref name="sound"/>'s <see cref="Custom"/>.</returns>
        public static explicit operator string(Sound sound) => sound.Custom;

        /// <summary>
        /// Returns <see cref="Game"/> for the current variable.
        /// </summary>
        /// <param name="sound">The variable to grab the property from.</param>
        /// <returns><paramref name="sound"/>'s <see cref="Game"/>.</returns>
        public static explicit operator SoundEffect?(Sound sound) => sound.Game;

        /// <summary>
        /// Returns <see cref="Game"/> for the current variable.
        /// </summary>
        /// <param name="sound">The variable to grab the property from.</param>
        /// <returns><paramref name="sound"/>'s <see cref="Game"/>.</returns>
        public static explicit operator SoundEffect(Sound sound) => sound.Game.Value;

        /// <summary>
        /// Stops the <see cref="Reference"/>'s sound.
        /// </summary>
        public void StopSound() => Reference.StopSound();

        /// <summary>
        /// Determines if both <see cref="Sound"/> variables are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if <see cref="Custom"/>, <see cref="Reference"/>, and <see cref="Game"/> are equal.</returns>
        public override bool Equals(object obj) => Equals(obj as Sound);

        /// <summary>
        /// Determines if both <see cref="Sound"/> variables are equal.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>True if <see cref="Custom"/>, <see cref="Reference"/>, and <see cref="Game"/> are equal.</returns>
        public bool Equals(Sound other) => other is { } && Reference == other.Reference && Game == other.Game && Custom == other.Custom;

        /// <summary>
        /// Gets the current hash code.
        /// </summary>
        /// <returns>The hash code of <see cref="Custom"/>, <see cref="Reference"/>, and <see cref="Game"/>.</returns>
        public override int GetHashCode()
        {
            int hashCode = -675929889;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Custom);
            hashCode = hashCode * -1521134295 + EqualityComparer<KMAudioRef>.Default.GetHashCode(Reference);
            hashCode = hashCode * -1521134295 + Game.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Converts the current sound to a string, returning the current sound.
        /// </summary>
        /// <returns><see cref="Game"/>, or if null, <see cref="Custom"/>.</returns>
        public override string ToString() => Game.ToString() ?? Custom;

        /// <summary>
        /// Gets the corresponding sound method matching the arguments of this instance of <see cref="Sound"/>.
        /// </summary>
        /// <param name="audio">The instance of <see cref="KMAudio"/> to play from.</param>
        /// <returns>A method that when called, will play the sound and return the <see cref="KMAudioRef"/> instance.</returns>
        public Func<Transform, bool, KMAudioRef> Method(KMAudio audio) =>
            Custom is { } ? ((t, b) => audio.HandlePlaySoundAtTransformWithRef?.Invoke(Custom, t, b)) :
            Game is { } ? (Func<Transform, bool, KMAudioRef>)((t, b) => audio.HandlePlayGameSoundAtTransformWithRef?.Invoke(Game.Value, t)) :
            throw new UnrecognizedValueException($"{this}'s properties {nameof(Custom)} and {nameof(Game)} are both null!");
    }
}
