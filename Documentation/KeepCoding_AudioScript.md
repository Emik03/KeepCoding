### [KeepCoding](KeepCoding.md 'KeepCoding')
## AudioScript Class
Advanced audio handler. Written by Emik.  
```csharp
public sealed class AudioScript : KeepCoding.CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; AudioScript  

| Fields | |
| :--- | :--- |
| [_audioClips](KeepCoding_AudioScript__audioClips.md 'KeepCoding.AudioScript._audioClips') | The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of clips it can play from.<br/> |
| [_audioSource](KeepCoding_AudioScript__audioSource.md 'KeepCoding.AudioScript._audioSource') | The audio source field.<br/> |
| [_isSFX](KeepCoding_AudioScript__isSFX.md 'KeepCoding.AudioScript._isSFX') | Setting this value to true will make the volume relative to [MusicVolume](KeepCoding_Game_PlayerSettings_MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume'), and [SFXVolume](KeepCoding_Game_PlayerSettings_SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') otherwise.<br/> |

| Properties | |
| :--- | :--- |
| [AudioClips](KeepCoding_AudioScript_AudioClips.md 'KeepCoding.AudioScript.AudioClips') |  |
| [AudioSource](KeepCoding_AudioScript_AudioSource.md 'KeepCoding.AudioScript.AudioSource') |  |
| [Game](KeepCoding_AudioScript_Game.md 'KeepCoding.AudioScript.Game') |  |
| [IsMuted](KeepCoding_AudioScript_IsMuted.md 'KeepCoding.AudioScript.IsMuted') |  |
| [IsPlaying](KeepCoding_AudioScript_IsPlaying.md 'KeepCoding.AudioScript.IsPlaying') |  |
| [Relative](KeepCoding_AudioScript_Relative.md 'KeepCoding.AudioScript.Relative') |  |
| [Volume](KeepCoding_AudioScript_Volume.md 'KeepCoding.AudioScript.Volume') |  |

| Methods | |
| :--- | :--- |
| [Fade(float, float)](KeepCoding_AudioScript_Fade(float_float).md 'KeepCoding.AudioScript.Fade(float, float)') | Fades the audio source to a specific volume from a specified duration of time linearly.<br/> |
| [Pause()](KeepCoding_AudioScript_Pause().md 'KeepCoding.AudioScript.Pause()') | Pauses playing the clip.<br/> |
| [Play(AudioClip, bool, byte, float, float, float, float)](KeepCoding_AudioScript_Play(AudioClip_bool_byte_float_float_float_float).md 'KeepCoding.AudioScript.Play(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Play(string, bool, byte, float, float, float, float)](KeepCoding_AudioScript_Play(string_bool_byte_float_float_float_float).md 'KeepCoding.AudioScript.Play(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(AudioClip, bool, byte, float, float, float, float)](KeepCoding_AudioScript_PlayStackable(AudioClip_bool_byte_float_float_float_float).md 'KeepCoding.AudioScript.PlayStackable(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(string, bool, byte, float, float, float, float)](KeepCoding_AudioScript_PlayStackable(string_bool_byte_float_float_float_float).md 'KeepCoding.AudioScript.PlayStackable(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Stop()](KeepCoding_AudioScript_Stop().md 'KeepCoding.AudioScript.Stop()') | Stops playing the clip.<br/> |
| [Unpause()](KeepCoding_AudioScript_Unpause().md 'KeepCoding.AudioScript.Unpause()') | Unpauses the paused playback of this [AudioSource](KeepCoding_AudioScript_AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator AudioSource(AudioScript)](KeepCoding_AudioScript_op_ExplicitAudioSource(KeepCoding_AudioScript).md 'KeepCoding.AudioScript.op_Explicit AudioSource(KeepCoding.AudioScript)') | Returns the [AudioSource](KeepCoding_AudioScript_AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |
