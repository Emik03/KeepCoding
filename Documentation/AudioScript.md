#### [KeepCoding](index.md 'index')
### [](.md '')
## AudioScript Class
Advanced audio handler.   
```csharp
public sealed class AudioScript : KeepCoding.CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; AudioScript  

| Fields | |
| :--- | :--- |
| [_audioClips](global__AudioScript__audioClips.md 'global::AudioScript._audioClips') | The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of clips it can play from.<br/> |
| [_audioSource](global__AudioScript__audioSource.md 'global::AudioScript._audioSource') | The audio source field.<br/> |
| [_isSFX](global__AudioScript__isSFX.md 'global::AudioScript._isSFX') | Setting this value to true will make the volume relative to [MusicVolume](KeepCoding_Game_PlayerSettings_MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume'), and [SFXVolume](KeepCoding_Game_PlayerSettings_SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') otherwise.<br/> |

| Properties | |
| :--- | :--- |
| [AudioClips](global__AudioScript_AudioClips.md 'global::AudioScript.AudioClips') |  |
| [AudioSource](global__AudioScript_AudioSource.md 'global::AudioScript.AudioSource') |  |
| [Game](global__AudioScript_Game.md 'global::AudioScript.Game') |  |
| [IsMuted](global__AudioScript_IsMuted.md 'global::AudioScript.IsMuted') |  |
| [IsPlaying](global__AudioScript_IsPlaying.md 'global::AudioScript.IsPlaying') |  |
| [Relative](global__AudioScript_Relative.md 'global::AudioScript.Relative') |  |
| [Volume](global__AudioScript_Volume.md 'global::AudioScript.Volume') |  |

| Methods | |
| :--- | :--- |
| [Fade(float, float)](global__AudioScript_Fade(float_float).md 'global::AudioScript.Fade(float, float)') | Fades the audio source to a specific volume from a specified duration of time linearly.<br/> |
| [Pause()](global__AudioScript_Pause().md 'global::AudioScript.Pause()') | Pauses playing the clip.<br/> |
| [Play(AudioClip, bool, byte, float, float, float, float)](global__AudioScript_Play(AudioClip_bool_byte_float_float_float_float).md 'global::AudioScript.Play(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Play(string, bool, byte, float, float, float, float)](global__AudioScript_Play(string_bool_byte_float_float_float_float).md 'global::AudioScript.Play(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(AudioClip, bool, byte, float, float, float, float)](global__AudioScript_PlayStackable(AudioClip_bool_byte_float_float_float_float).md 'global::AudioScript.PlayStackable(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(string, bool, byte, float, float, float, float)](global__AudioScript_PlayStackable(string_bool_byte_float_float_float_float).md 'global::AudioScript.PlayStackable(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Stop()](global__AudioScript_Stop().md 'global::AudioScript.Stop()') | Stops playing the clip.<br/> |
| [Unpause()](global__AudioScript_Unpause().md 'global::AudioScript.Unpause()') | Unpauses the paused playback of this [AudioSource](global__AudioScript_AudioSource.md 'global::AudioScript.AudioSource').<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator AudioSource(AudioScript)](global__AudioScript_op_ExplicitAudioSource(global__AudioScript).md 'global::AudioScript.op_Explicit AudioSource(global::AudioScript)') | Returns the [AudioSource](global__AudioScript_AudioSource.md 'global::AudioScript.AudioSource').<br/> |
