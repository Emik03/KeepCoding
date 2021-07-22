using System;
using System.Collections.Generic;
using KeepCoding.Internal;
using UnityEngine;
using static KMAudio;
using static KMSoundOverride;

namespace KeepCoding
{
    /// <summary>
    /// Class meant to encapsulate all types of sound effects <see cref="KMAudio"/> uses. Currently used in <see cref="ModuleScript"/>.
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
        /// The in-game sound.
        /// </summary>
        public SoundEffect? Game { get; }

        /// <summary>
        /// The audio reference that is playing the sound.
        /// </summary>
        public KMAudioRef Reference { get; internal set; }

        /// <summary>
        /// Plays when the alarm clock goes off. This sound loops.
        /// </summary>
        public static Sound AlarmClockBeep => new Sound(SoundEffect.AlarmClockBeep);

        /// <summary>
        /// Plays when you hit snooze button on the alarm clock.
        /// </summary>
        public static Sound AlarmClockSnooze => new Sound(SoundEffect.AlarmClockSnooze);

        /// <summary>
        /// Plays when pressing down the button on the Big Button vanilla module.
        /// </summary>
        public static Sound BigButtonPress => new Sound(SoundEffect.BigButtonPress);

        /// <summary>
        /// Plays when releasing the button on the Big Button vanilla module.
        /// </summary>
        public static Sound BigButtonRelease => new Sound(SoundEffect.BigButtonRelease);

        /// <summary>
        /// Plays as the mission binder hits the desk.
        /// </summary>
        public static Sound BinderDrop => new Sound(SoundEffect.BinderDrop);

        /// <summary>
        /// Plays immediately after a bomb is defused. Plays before <see cref="SoundEffect.GameOverFanfare"/>.
        /// </summary>
        public static Sound BombDefused => new Sound(SoundEffect.BombDefused);

        /// <summary>
        /// Plays when the bomb is set down on the desk.
        /// </summary>
        public static Sound BombDrop => new Sound(SoundEffect.BombDrop);

        /// <summary>
        /// Plays when the bomb explodes.
        /// </summary>
        public static Sound BombExplode => new Sound(SoundEffect.BombExplode);

        /// <summary>
        /// Plays when the freeplay briefcase is closed.
        /// </summary>
        public static Sound BriefcaseClose => new Sound(SoundEffect.BriefcaseClose);

        /// <summary>
        /// Plays when the freeplay briefcase is opened.
        /// </summary>
        public static Sound BriefcaseOpen => new Sound(SoundEffect.BriefcaseOpen);

        /// <summary>
        /// Plays when pressing down a button.
        /// </summary>
        public static Sound ButtonPress => new Sound(SoundEffect.ButtonPress);

        /// <summary>
        /// Plays when releasing a button.
        /// </summary>
        public static Sound ButtonRelease => new Sound(SoundEffect.ButtonRelease);

        /// <summary>
        /// Plays when Capacitor Discharge fills up completely.
        /// </summary>
        public static Sound CapacitorPop => new Sound(SoundEffect.CapacitorPop);

        /// <summary>
        /// Plays in the tutorial for completing a step correctly.
        /// </summary>
        public static Sound CorrectChime => new Sound(SoundEffect.CorrectChime);

        /// <summary>
        /// Plays when you change a setting in the menu folder.
        /// </summary>
        public static Sound DossierOptionPressed => new Sound(SoundEffect.DossierOptionPressed);

        /// <summary>
        /// Plays when there is less than a minute left on the bomb, this sound loops.
        /// </summary>
        public static Sound EmergencyAlarm => new Sound(SoundEffect.EmergencyAlarm);

        /// <summary>
        /// Plays when the bomb has at least 2 or more strikes.
        /// </summary>
        public static Sound FastestTimerBeep => new Sound(SoundEffect.FastestTimerBeep);

        /// <summary>
        /// Plays when the bomb has 1 strike.
        /// </summary>
        public static Sound FastTimerBeep => new Sound(SoundEffect.FastTimerBeep);

        /// <summary>
        /// Plays as the freeplay briefcase hits the desk.
        /// </summary>
        public static Sound FreeplayDeviceDrop => new Sound(SoundEffect.FreeplayDeviceDrop);

        /// <summary>
        /// Plays when all bombs are defused. Finishes before the post game screen.
        /// </summary>
        public static Sound GameOverFanfare => new Sound(SoundEffect.GameOverFanfare);

        /// <summary>
        /// Plays when the lights go out.
        /// </summary>
        public static Sound LightBuzz => new Sound(SoundEffect.LightBuzz);

        /// <summary>
        /// Plays when the lights start to come back on.
        /// </summary>
        public static Sound LightBuzzShort => new Sound(SoundEffect.LightBuzzShort);

        /// <summary>
        /// Plays when you start a mission from the mission binder.
        /// </summary>
        public static Sound MenuButtonPressed => new Sound(SoundEffect.MenuButtonPressed);

        /// <summary>
        /// Plays as the mission folder hits the desk.
        /// </summary>
        public static Sound MenuDrop => new Sound(SoundEffect.MenuDrop);

        /// <summary>
        /// Plays when a needy gets activated.
        /// </summary>
        public static Sound NeedyActivated => new Sound(SoundEffect.NeedyActivated);

        /// <summary>
        /// Plays when a needy is running out of time. This sound loops.
        /// </summary>
        public static Sound NeedyWarning => new Sound(SoundEffect.NeedyWarning);

        /// <summary>
        /// Plays when the bomb has no strikes.
        /// </summary>
        public static Sound NormalTimerBeep => new Sound(SoundEffect.NormalTimerBeep);

        /// <summary>
        /// Plays when a page is turned in the Missions binder.
        /// </summary>
        public static Sound PageTurn => new Sound(SoundEffect.PageTurn);

        /// <summary>
        /// Plays as you hover over something interactable.
        /// </summary>
        public static Sound SelectionTick => new Sound(SoundEffect.SelectionTick);

        /// <summary>
        /// Plays during the post game screen, when either the defused or exploded text is stamped onto the binder.
        /// </summary>
        public static Sound Stamp => new Sound(SoundEffect.Stamp);

        /// <summary>
        /// Plays when you get a strike.
        /// </summary>
        public static Sound Strike => new Sound(SoundEffect.Strike);

        /// <summary>
        /// Plays when a switch is toggled.
        /// </summary>
        public static Sound Switch => new Sound(SoundEffect.Switch);

        /// <summary>
        /// Plays when pressing a button in one of the tutorials.
        /// </summary>
        public static Sound TitleMenuPressed => new Sound(SoundEffect.TitleMenuPressed);

        /// <summary>
        /// Plays during the post game screen as the mission information gets typed out.
        /// </summary>
        public static Sound TypewriterKey => new Sound(SoundEffect.TypewriterKey);

        /// <summary>
        /// Plays when switching between sets of wires in Wire Sequence.
        /// </summary>
        public static Sound WireSequenceMechanism => new Sound(SoundEffect.WireSequenceMechanism);

        /// <summary>
        /// Played when a wire is cut on a module like Complicated Wires.
        /// </summary>
        public static Sound WireSnip => new Sound(SoundEffect.WireSnip);

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
        /// <exception cref="InvalidOperationException"></exception>
        /// <param name="sound">The variable to grab the property from.</param>
        /// <returns><paramref name="sound"/>'s <see cref="Game"/>.</returns>
        public static explicit operator SoundEffect(Sound sound) => sound.Game.Value;

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
            Custom is { } ? ((t, b) => KeyHelper.Catch<NullReferenceException, KMAudioRef>(() => audio.HandlePlaySoundAtTransformWithRef?.Invoke(Custom, t, b), null)) :
            Game is { } ? (Func<Transform, bool, KMAudioRef>)((t, b) => b ? throw new ArgumentException("The game doesn't support looping in-game sounds.") : KeyHelper.Catch<NullReferenceException, KMAudioRef>(() => audio.HandlePlayGameSoundAtTransformWithRef?.Invoke(Game.Value, t), null)) :
            throw new UnrecognizedValueException($"{this}'s properties {nameof(Custom)} and {nameof(Game)} are both null!");
    }
}
