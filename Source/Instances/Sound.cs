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

        /// <value>
        /// An instance of sound where <see cref="Game"/> is defined.
        /// </value>
        /// <param name="sound">The sound to insert.</param>
        public Sound(SoundEffect sound) => Game = sound;

        /// <summary>
        /// An instance of Sound where <see cref="Custom"/> is defined.
        /// </summary>
        /// <param name="sound">The sound to insert.</param>
        public Sound(AudioClip sound) => Custom = sound.NullCheck("The AudioClip provided is null!").name;

        /// <value>
        /// The custom sound, written out by name.
        /// </value>
        public string Custom { get; }

        /// <value>
        /// The in-game sound.
        /// </value>
        public SoundEffect? Game { get; }

        /// <value>
        /// The audio reference that is playing the sound.
        /// </value>
        public KMAudioRef Reference { get; internal set; }

        /// <value>
        /// Plays when the alarm clock goes off. This sound loops.
        /// </value>
        public static Sound AlarmClockBeep => new Sound(SoundEffect.AlarmClockBeep);

        /// <value>
        /// Plays when you hit snooze button on the alarm clock.
        /// </value>
        public static Sound AlarmClockSnooze => new Sound(SoundEffect.AlarmClockSnooze);

        /// <value>
        /// Plays when pressing down the button on the Big Button vanilla module.
        /// </value>
        public static Sound BigButtonPress => new Sound(SoundEffect.BigButtonPress);

        /// <value>
        /// Plays when releasing the button on the Big Button vanilla module.
        /// </value>
        public static Sound BigButtonRelease => new Sound(SoundEffect.BigButtonRelease);

        /// <value>
        /// Plays as the mission binder hits the desk.
        /// </value>
        public static Sound BinderDrop => new Sound(SoundEffect.BinderDrop);

        /// <value>
        /// Plays immediately after a bomb is defused. Plays before <see cref="SoundEffect.GameOverFanfare"/>.
        /// </value>
        public static Sound BombDefused => new Sound(SoundEffect.BombDefused);

        /// <value>
        /// Plays when the bomb is set down on the desk.
        /// </value>
        public static Sound BombDrop => new Sound(SoundEffect.BombDrop);

        /// <value>
        /// Plays when the bomb explodes.
        /// </value>
        public static Sound BombExplode => new Sound(SoundEffect.BombExplode);

        /// <value>
        /// Plays when the freeplay briefcase is closed.
        /// </value>
        public static Sound BriefcaseClose => new Sound(SoundEffect.BriefcaseClose);

        /// <value>
        /// Plays when the freeplay briefcase is opened.
        /// </value>
        public static Sound BriefcaseOpen => new Sound(SoundEffect.BriefcaseOpen);

        /// <value>
        /// Plays when pressing down a button.
        /// </value>
        public static Sound ButtonPress => new Sound(SoundEffect.ButtonPress);

        /// <value>
        /// Plays when releasing a button.
        /// </value>
        public static Sound ButtonRelease => new Sound(SoundEffect.ButtonRelease);

        /// <value>
        /// Plays when Capacitor Discharge fills up completely.
        /// </value>
        public static Sound CapacitorPop => new Sound(SoundEffect.CapacitorPop);

        /// <value>
        /// Plays in the tutorial for completing a step correctly.
        /// </value>
        public static Sound CorrectChime => new Sound(SoundEffect.CorrectChime);

        /// <value>
        /// Plays when you change a setting in the menu folder.
        /// </value>
        public static Sound DossierOptionPressed => new Sound(SoundEffect.DossierOptionPressed);

        /// <value>
        /// Plays when there is less than a minute left on the bomb, this sound loops.
        /// </value>
        public static Sound EmergencyAlarm => new Sound(SoundEffect.EmergencyAlarm);

        /// <value>
        /// Plays when the bomb has at least 2 or more strikes.
        /// </value>
        public static Sound FastestTimerBeep => new Sound(SoundEffect.FastestTimerBeep);

        /// <value>
        /// Plays when the bomb has 1 strike.
        /// </value>
        public static Sound FastTimerBeep => new Sound(SoundEffect.FastTimerBeep);

        /// <value>
        /// Plays as the freeplay briefcase hits the desk.
        /// </value>
        public static Sound FreeplayDeviceDrop => new Sound(SoundEffect.FreeplayDeviceDrop);

        /// <value>
        /// Plays when all bombs are defused. Finishes before the post game screen.
        /// </value>
        public static Sound GameOverFanfare => new Sound(SoundEffect.GameOverFanfare);

        /// <value>
        /// Plays when the lights go out.
        /// </value>
        public static Sound LightBuzz => new Sound(SoundEffect.LightBuzz);

        /// <value>
        /// Plays when the lights start to come back on.
        /// </value>
        public static Sound LightBuzzShort => new Sound(SoundEffect.LightBuzzShort);

        /// <value>
        /// Plays when you start a mission from the mission binder.
        /// </value>
        public static Sound MenuButtonPressed => new Sound(SoundEffect.MenuButtonPressed);

        /// <value>
        /// Plays as the mission folder hits the desk.
        /// </value>
        public static Sound MenuDrop => new Sound(SoundEffect.MenuDrop);

        /// <value>
        /// Plays when a needy gets activated.
        /// </value>
        public static Sound NeedyActivated => new Sound(SoundEffect.NeedyActivated);

        /// <value>
        /// Plays when a needy is running out of time. This sound loops.
        /// </value>
        public static Sound NeedyWarning => new Sound(SoundEffect.NeedyWarning);

        /// <value>
        /// Plays when the bomb has no strikes.
        /// </value>
        public static Sound NormalTimerBeep => new Sound(SoundEffect.NormalTimerBeep);

        /// <value>
        /// Plays when a page is turned in the Missions binder.
        /// </value>
        public static Sound PageTurn => new Sound(SoundEffect.PageTurn);

        /// <value>
        /// Plays as you hover over something interactable.
        /// </value>
        public static Sound SelectionTick => new Sound(SoundEffect.SelectionTick);

        /// <value>
        /// Plays during the post game screen, when either the defused or exploded text is stamped onto the binder.
        /// </value>
        public static Sound Stamp => new Sound(SoundEffect.Stamp);

        /// <value>
        /// Plays when you get a strike.
        /// </value>
        public static Sound Strike => new Sound(SoundEffect.Strike);

        /// <value>
        /// Plays when a switch is toggled.
        /// </value>
        public static Sound Switch => new Sound(SoundEffect.Switch);

        /// <value>
        /// Plays when pressing a button in one of the tutorials.
        /// </value>
        public static Sound TitleMenuPressed => new Sound(SoundEffect.TitleMenuPressed);

        /// <value>
        /// Plays during the post game screen as the mission information gets typed out.
        /// </value>
        public static Sound TypewriterKey => new Sound(SoundEffect.TypewriterKey);

        /// <value>
        /// Plays when switching between sets of wires in Wire Sequence.
        /// </value>
        public static Sound WireSequenceMechanism => new Sound(SoundEffect.WireSequenceMechanism);

        /// <value>
        /// Played when a wire is cut on a module like Complicated Wires.
        /// </value>
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
            Custom is { } ? ((t, b) => KeywordHelper.Catch<NullReferenceException, KMAudioRef>(() => audio.HandlePlaySoundAtTransformWithRef?.Invoke(Custom, t, b), null)) :
            Game is { } ? (Func<Transform, bool, KMAudioRef>)((t, b) => b ? throw new ArgumentException("The game doesn't support looping in-game sounds.") : KeywordHelper.Catch<NullReferenceException, KMAudioRef>(() => audio.HandlePlayGameSoundAtTransformWithRef?.Invoke(Game.Value, t), null)) :
            throw new UnrecognizedValueException($"{this}'s properties {nameof(Custom)} and {nameof(Game)} are both null!");
    }
}
