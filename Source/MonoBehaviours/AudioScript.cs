using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using static UnityEngine.Application;
using static KeepCoding.Game.PlayerSettings;

namespace KeepCoding
{
    /// <summary>
    /// Advanced audio handler. Written by Emik.
    /// </summary>
    public sealed class AudioScript : MonoBehaviour
    {
        /// <summary>
        /// Determines if the <see cref="AudioSource"/> is muted.
        /// </summary>
        public bool IsMuted { get => AudioSource.mute; set => AudioSource.mute = value; }

        /// <value>
        /// Determines if the audio source is currently playing.
        /// </value>
        public bool IsPlaying => _audioSource.isPlaying;

        /// <value>
        /// Determines if the audio volume should update every frame.
        /// </value>
        public bool IsUpdating { get; set; } = true;

        /// <value>
        /// The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.
        /// </value>
        public int GameVolume => isEditor ? 100 : _isMusic ? MusicVolume : SFXVolume;

        /// <summary>
        /// The volume of the sound relative to the game.
        /// </summary>
        public float Volume { get; set; }

        /// <value>
        /// The audio source property. If the field it is referencing is <see langword="null"/> then it adds a component.
        /// </value>
        public AudioSource AudioSource => _audioSource;

        /// <summary>
        /// Setting this value to true will make the volume relative to <see cref="MusicVolume"/>, and <see cref="SFXVolume"/> otherwise.
        /// </summary>
        [SerializeField]
#pragma warning disable IDE0044 // Add readonly modifier
        private bool _isMusic;
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// The <see cref="Array"/> of clips it can play from.
        /// </summary>
        [SerializeField]
#pragma warning disable IDE0044 // Add readonly modifier
        private AudioClip[] _audioClips;
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// The audio source field.
        /// </summary>
        [SerializeField]
        private AudioSource _audioSource;

        private Routine<float, float> _fade;

        /// <summary>
        /// Returns the <see cref="AudioSource"/>.
        /// </summary>
        /// <param name="dynamicAudio">The instance of <see cref="AudioScript"/> to retrieve <see cref="AudioSource"/> from.</param>
        public static explicit operator AudioSource(AudioScript dynamicAudio) => dynamicAudio.AudioSource;

#pragma warning disable IDE0051 // Remove unused private members
        private void Awake()
#pragma warning restore IDE0051 // Remove unused private members
        {
            if (!_audioSource)
                _audioSource = gameObject.AddComponent<AudioSource>();

            _fade = this.ToRoutine((Func<float, float, IEnumerator>)TweenFade);

            AudioSource.playOnAwake = false;
            AudioSource.volume = 0;
        }

#pragma warning disable IDE0051 // Remove unused private members
        private void Update() => AudioSource.volume = Volume * (GameVolume / 100f);
#pragma warning restore IDE0051 // Remove unused private members

        /// <summary>
        /// Fades the audio source to a specific volume from a specified duration of time linearly.
        /// </summary>
        /// <param name="volume">The volume to get to.</param>
        /// <param name="time">The amount of time it takes to get to <paramref name="volume"/>.</param>
        public void Fade(float volume, float time) => _fade.StartOrRestart(volume, time);

        /// <summary>
        /// Pauses playing the clip.
        /// </summary>
        public void Pause() => AudioSource.Pause();

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="clip">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(AudioClip clip, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
        {
            clip.NullCheck("You cannot play an audio clip which is null.");

            Volume = volume;

            AudioSource.clip = clip;
            AudioSource.loop = loop;
            AudioSource.priority = priority;
            AudioSource.pitch = pitch;
            AudioSource.time = time;

            AudioSource.PlayDelayed(delay);
        }

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="MissingComponentException"></exception>
        /// <param name="sound">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(string sound, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => Play(_audioClips.FirstOrDefault(c => c.name == sound) ?? throw new MissingComponentException($"There is no sound effect named \"{sound}\". List of audio clips from the prefab: {_audioClips.UnwrapToString()}"), loop, priority, delay, pitch, time, volume);

        /// <summary>
        /// Stops playing the clip.
        /// </summary>
        public void Stop() => AudioSource.Stop();

        /// <summary>
        /// Unpauses the paused playback of this <see cref="AudioSource"/>.
        /// </summary>
        public void Unpause() => AudioSource.UnPause();

        private IEnumerator TweenFade(float to, float time)
        {
            float from = Volume,
                current = 0;

            while (current < time)
            {
                current += Time.deltaTime;

                float end = current / time,
                    start = 1 - end;

                Volume = (from * start) + (to * end);

                yield return null;
            }

            Volume = to;
        }
    }
}
