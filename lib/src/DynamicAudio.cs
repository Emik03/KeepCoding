using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Advanced audio handler. Written by Emik.
    /// </summary>
    public class DynamicAudio : MonoBehaviour
    {
        /// <summary>
        /// Setting this value to true will make the volume relative to <see cref="PlayerSettings.MusicVolume"/>, and <see cref="PlayerSettings.SFXVolume"/> otherwise.
        /// </summary>
        public bool IsMusicLayer;

        /// <value>
        /// The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.
        /// </value>
        public int GameVolume => Application.isEditor ? 100 : IsMusicLayer ? PlayerSettings.MusicVolume : PlayerSettings.SFXVolume;

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

        private Routine<float, float> _fade;

        private void Awake()
        {
            _fade = new Routine<float, float>(SetFade, this);
            AudioSource = gameObject.AddComponent<AudioSource>();
            AudioSource.playOnAwake = false;
            StartCoroutine(UpdateVolume());
        }

        /// <summary>
        /// Plays a sound, with optional parameters.
        /// </summary>
        /// <param name="clip">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(AudioClip clip, bool loop = false, int priority = 0, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
        {
            AudioSource.clip = clip;
            AudioSource.loop = loop;
            AudioSource.priority = priority;
            AudioSource.pitch = pitch;
            AudioSource.time = time;

            Volume = volume;

            AudioSource.PlayDelayed(delay);
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
        /// <exception cref="UnityComponentNotFoundException"></exception>
        /// <param name="sound">The sound clip to play.</param>
        /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
        /// <param name="loop">If the sound should be looped.</param>
        /// <param name="priority">The priority of the sound.</param>
        /// <param name="delay">The amount of delay before the sound starts.</param>
        /// <param name="time">The time in the audio it should start playing at.</param>
        /// <param name="pitch">The pitch of the sound.</param>
        public void Play(string sound, bool loop = false, int priority = 0, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => Play(AudioClips.FirstOrDefault(c => c.name.Call(d => Debug.Log("asdasdasd: " + d)) == sound) ?? throw new UnityComponentNotFoundException($"There is no sound effect named \"{sound}\". List of audio clips from the prefab: {AudioClips.UnwrapToString()}"), loop, priority, delay, pitch, time, volume);

        /// <summary>
        /// Stops playing the clip.
        /// </summary>
        public void Stop() => AudioSource.Stop();

        /// <summary>
        /// Unpauses the paused playback of this <see cref="UnityEngine.AudioSource"/>.
        /// </summary>
        public void Unpause() => AudioSource.UnPause();

        private IEnumerator SetFade(float endVolume, float time)
        {
            float startVolume = AudioSource.volume;
            float t = 0;

            while (t < time)
            {
                t += Time.deltaTime;

                float end = t / time, start = 1 - end;

                Volume = (startVolume * start) + (endVolume * end);

                yield return null;
            }

            AudioSource.volume = 0;
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
