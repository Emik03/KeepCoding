﻿using System;
using System.Collections;
using System.Linq;
using KeepCoding.Internal;
using UnityEngine;
using static KeepCoding.Game.PlayerSettings;

namespace KeepCoding
{
    /// <summary>
    /// Encapsulates an <see cref="AudioSource"/> and scales it with the game's volume using <see cref="SFXVolume"/> and <see cref="MusicVolume"/>.
    /// </summary>
    [CLSCompliant(false)]
    public abstract class AudioScript : CacheableBehaviour
#if !LITE
        , IAwake, IUpdate
#endif
    {
        [SerializeField]
        private bool _isSFX;

        [SerializeField]
        private AudioClip[] _audioClips;

        [SerializeField]
        private AudioSource _audioSource;

        private Coroutine _previous;

        /// <summary>
        /// Determines if the <see cref="AudioSource"/> is muted.
        /// </summary>
        public bool IsMuted { get => AudioSource.mute; set => AudioSource.mute = value; }

        /// <summary>
        /// Determines if the audio source is currently playing.
        /// </summary>
        public bool IsPlaying => _audioSource.isPlaying;

        /// <summary>
        /// Determines if <see cref="AudioSource.volume"/> in <see cref="AudioSource"/> is scaled using <see cref="SFXVolume"/> when <see langword="true"/> and <see cref="MusicVolume"/> when <see langword="false"/>.
        /// </summary>
        public bool IsSFX { get => _isSFX; set => _isSFX = value; }

        /// <summary>
        /// The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.
        /// </summary>
        public int Game => _isSFX ? SFXVolume : MusicVolume;

        /// <summary>
        /// The volume the <see cref="AudioSource"/> is playing at, determined by <see cref="Volume"/> and <see cref="Game"/>.
        /// </summary>
        public float Relative => Volume * (Game / 100f);

        /// <summary>
        /// The volume of the sound relative to the game.
        /// </summary>
        public float Volume { get; set; }

        /// <summary>
        /// The audio clips used by the <see cref="UnityEngine.AudioSource"/>s.
        /// </summary>
        public AudioClip[] AudioClips { get => _audioClips; set => _audioClips = value; }

        /// <summary>
        /// The main <see cref="UnityEngine.AudioSource"/> property. If the field it is referencing is <see langword="null"/> then it adds a component.
        /// </summary>
        public AudioSource AudioSource => _audioSource ? _audioSource : _audioSource = gameObject.AddComponent<AudioSource>();

        /// <summary>
        /// Returns the <see cref="AudioSource"/>.
        /// </summary>
        /// <param name="dynamicAudio">The instance of <see cref="AudioScript"/> to retrieve <see cref="AudioSource"/> from.</param>
        public static explicit operator AudioSource(AudioScript dynamicAudio) => dynamicAudio.AudioSource;

#if LITE
        /// <summary>
        /// Sets up base functionality for the audio. If you declare this method yourself, make sure to call <c>base.Awake()</c> to ensure that this component initializes correctly
        /// </summary>
#else
        /// <summary>
        /// Sets up base functionality for the audio. If you declare this method yourself, make sure to call <c>base.Awake()</c> to ensure that this component initializes correctly, or use <see cref="OnAwake"/> instead.
        /// </summary>
#endif
        public void Awake()
        {
            AudioSource.playOnAwake = false;
            AudioSource.volume = 0;
#if !LITE
            OnAwake();
#endif
        }

        /// <summary>
        /// Fades the audio source to a specific volume from a specified duration of time linearly.
        /// </summary>
        /// <param name="volume">The volume to get to.</param>
        /// <param name="time">The amount of time it takes to get to <paramref name="volume"/>.</param>
        public void Fade(float volume, float time)
        {
            if (_previous is { })
                StopCoroutine(_previous);

            _previous = StartCoroutine(TweenFade(volume, time));
        }

#if LITE
        /// <summary>
        /// Updates the volume of <see cref="AudioSource"/>. If you declare this method yourself, make sure to call <c>base.Update()</c> to ensure that this component retains functionality.
        /// </summary>
#else
        /// <summary>
        /// Updates the volume of <see cref="AudioSource"/>. If you declare this method yourself, make sure to call <c>base.Update()</c> to ensure that this component retains functionality, or use <see cref="OnUpdate"/> instead.
        /// </summary>
#endif
        public void Update()
#if LITE
            =>
#else
        {
#endif
            AudioSource.volume = Relative;
#if !LITE
            OnUpdate();
        }
#endif

#if !LITE
        /// <summary>
        /// Called when the module instantiates, well before the lights turn on.
        /// </summary>
        public virtual void OnAwake() { }

        /// <summary>
        /// Called on every frame. Frame-rate might vary depending on setup, so make sure to use <see cref="Time.deltaTime"/> or similar for time-sensitive applications.
        /// </summary>
        public virtual void OnUpdate() { }
#endif

        /// <summary>
        /// Pauses playing the clip.
        /// </summary>
        public void Pause() => AudioSource.Pause();

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <remarks>
        /// The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="clip">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(AudioClip clip, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
        {
            Set(clip, loop, priority, pitch, time, volume);
            AudioSource.PlayDelayed(delay);
        }

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <remarks>
        /// The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="MissingComponentException"></exception>
        /// <param name="name">The name of the sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(string name, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => Play(_audioClips.FirstOrDefault(c => c.name == name) ?? throw new MissingComponentException($"There is no sound effect named \"{name}\". List of audio clips from the prefab: {_audioClips.Stringify()}"), loop, priority, delay, pitch, time, volume);

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <remarks>
        /// Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="clip">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void PlayStackable(AudioClip clip, bool loop = false, byte priority = 128, float pitch = 1, float time = 0, float volume = 1)
        {
            Set(clip, loop, priority, pitch, time, volume);
            AudioSource.PlayOneShot(clip, Relative);
        }

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <remarks>
        /// Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="MissingComponentException"></exception>
        /// <param name="name">The name of the sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void PlayStackable(string name, bool loop = false, byte priority = 128, float pitch = 1, float time = 0, float volume = 1) => PlayStackable(_audioClips.FirstOrDefault(c => c.name == name) ?? throw new MissingComponentException($"There is no sound effect named \"{name}\". List of audio clips from the prefab: {_audioClips.Stringify()}"), loop, priority, pitch, time, volume);

        /// <summary>
        /// Stops playing the clip.
        /// </summary>
        public void Stop() => AudioSource.Stop();

        /// <summary>
        /// Unpauses the paused playback of this <see cref="AudioSource"/>.
        /// </summary>
        public void Unpause() => AudioSource.UnPause();

        private void Set(in AudioClip clip, in bool loop, in byte priority, in float pitch, in float time, in float volume)
        {
            clip.NullCheck("You cannot play an audio clip which is null.");

            Volume = volume;

            AudioSource.clip = clip;
            AudioSource.loop = loop;
            AudioSource.priority = priority;
            AudioSource.pitch = pitch;
            AudioSource.time = time;
        }

        private IEnumerator TweenFade(float to, float time)
        {
            float from = Volume,
                current = 0;

            while (current < time)
            {
                current += Time.deltaTime;

                float end = current / time,
                    start = 1 - end;

                Volume = from * start + to * end;

                yield return null;
            }

            Volume = to;
        }
    }
}
