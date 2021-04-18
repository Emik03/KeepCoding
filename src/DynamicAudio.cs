using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace KeepCoding.v14
{
    /// <summary>
    /// Advanced audio handler. Written by Emik.
    /// </summary>
    public class DynamicAudio : MonoBehaviour
    {
        /// <summary>
        /// Setting this value to true will make the volume relative to <see cref="Game.PlayerSettings.MusicVolume"/>, and <see cref="Game.PlayerSettings.SFXVolume"/> otherwise.
        /// </summary>
        public bool IsMusicLayer;

        /// <value>
        /// The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.
        /// </value>
        public int GameVolume => Application.isEditor ? 100 : IsMusicLayer ? Game.PlayerSettings.MusicVolume : Game.PlayerSettings.SFXVolume;

        /// <summary>
        /// The volume it plays relative to the game sound. Works the same as <see cref="AudioSource.volume"/>, meaning 0 to 1 is the main range.
        /// </summary>
        [Range(0, 1)]
        public float Volume;

        /// <summary>
        /// The <see cref="Array"/> of clips it can play from.
        /// </summary>
        public AudioClip[] AudioClips;

        /// <summary>
        /// The audio source.
        /// </summary>
        public AudioSource AudioSource { get; private set; }

        /// <summary>
        /// Returns <see cref="AudioSource"/>.
        /// </summary>
        /// <param name="dynamicAudio">The instance of <see cref="DynamicAudio"/> to retrieve <see cref="AudioSource"/> from.</param>
        public static explicit operator AudioSource(DynamicAudio dynamicAudio) => dynamicAudio.AudioSource;

        private Routine<float, float> _fade;

        private void Awake()
        {
            var func = (Func<float, float, IEnumerator>)SetFade;

            _fade = func.ToRoutine(this);

            AudioSource = gameObject.AddComponent<AudioSource>();

            AudioSource.playOnAwake = false;

            StartCoroutine(UpdateVolume());
        }

        /// <summary>
        /// Fades the audio source to a specific volume from a specified duration of time linearly.
        /// </summary>
        /// <param name="volume">The volume to get to.</param>
        /// <param name="time">The amount of time it takes to get to <paramref name="volume"/>.</param>
        public void Fade(float volume, float time) => GetRoutineMethod(_fade.Count)(volume, time);

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
        public void Play(AudioClip clip, bool loop = false, int priority = 0, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
        {
            clip.NullCheck("You cannot play an audio clip which is null.");

            AudioSource.clip = clip;
            AudioSource.loop = loop;
            AudioSource.priority = priority;
            AudioSource.pitch = pitch;
            AudioSource.time = time;

            Volume = volume;

            AudioSource.PlayDelayed(delay);
        }

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <param name="sound">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(string sound, bool loop = false, int priority = 0, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => Play(AudioClips.FirstOrDefault(c => c.name == sound) ?? throw new UnityComponentNotFoundException($"There is no sound effect named \"{sound}\". List of audio clips from the prefab: {AudioClips.UnwrapToString()}"), loop, priority, delay, pitch, time, volume);

        /// <summary>
        /// Stops playing the clip.
        /// </summary>
        public void Stop() => AudioSource.Stop();

        /// <summary>
        /// Unpauses the paused playback of this <see cref="UnityEngine.AudioSource"/>.
        /// </summary>
        public void Unpause() => AudioSource.UnPause();

        private IEnumerator SetFade(float to, float time)
        {
            float current = 0, from = AudioSource.volume;

            while (current < time)
            {
                current += Time.deltaTime;

                float end = current / time, start = 1 - end;

                Volume = (from * start) + (to * end);

                yield return null;
            }

            AudioSource.volume = to;
        }

        private IEnumerator UpdateVolume()
        {
            while (true)
            {
                AudioSource.volume = Volume * GameVolume / 100f;
                yield return null;
            }
        }

        private Action<float, float> GetRoutineMethod(int length) => length == 0 ? (i, j) => _fade.Start(i, j, false) : (Action<float, float>)_fade.Restart;
    }
}
