#### [KeepCoding](index.md 'index')
### [](.md '')
## AudioScript Class
Encapsulates an [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource') and scales it with the game's volume using [SFXVolume](Game_PlayerSettings_SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') and [MusicVolume](Game_PlayerSettings_MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume').  
```csharp
public sealed class AudioScript : KeepCoding.CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; AudioScript  

| Fields | |
| :--- | :--- |
| [_audioClips](AudioScript__audioClips.md 'global::AudioScript._audioClips') | The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of clips it can play from.<br/> |
| [_audioSource](AudioScript__audioSource.md 'global::AudioScript._audioSource') | The audio source field.<br/> |
| [_isSFX](AudioScript__isSFX.md 'global::AudioScript._isSFX') | Setting this value to true will make the volume relative to [MusicVolume](Game_PlayerSettings_MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume'), and [SFXVolume](Game_PlayerSettings_SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') otherwise.<br/> |

| Properties | |
| :--- | :--- |
| [AudioClips](AudioScript_AudioClips.md 'global::AudioScript.AudioClips') | The audio clips used by the [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource')s.<br/> |
| [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource') | The main [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource') property. If the field it is referencing is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') then it adds a component.<br/> |
| [Game](AudioScript_Game.md 'global::AudioScript.Game') | The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.<br/> |
| [IsMuted](AudioScript_IsMuted.md 'global::AudioScript.IsMuted') | Determines if the [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource') is muted.<br/> |
| [IsPlaying](AudioScript_IsPlaying.md 'global::AudioScript.IsPlaying') | Determines if the audio source is currently playing.<br/> |
| [Relative](AudioScript_Relative.md 'global::AudioScript.Relative') | The volume the [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource') is playing at, determined by [Volume](AudioScript_Volume.md 'global::AudioScript.Volume') and [Game](AudioScript_Game.md 'global::AudioScript.Game').<br/> |
| [Volume](AudioScript_Volume.md 'global::AudioScript.Volume') | The volume of the sound relative to the game.<br/> |

| Methods | |
| :--- | :--- |
| [Fade(float, float)](AudioScript_Fade_hji5BasS2pJ81q8D4I_ZsA.md 'global::AudioScript.Fade(float, float)') | Fades the audio source to a specific volume from a specified duration of time linearly.<br/> |
| [Pause()](AudioScript_Pause().md 'global::AudioScript.Pause()') | Pauses playing the clip.<br/> |
| [Play(AudioClip, bool, byte, float, float, float, float)](AudioScript_Play_mIgb3bFTYWKYguK1jBvZ0A.md 'global::AudioScript.Play(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Play(string, bool, byte, float, float, float, float)](AudioScript_Play_FbLt_JbB7cEZZYdKsbRnrw.md 'global::AudioScript.Play(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(AudioClip, bool, byte, float, float, float)](AudioScript_PlayStackable_QqfX9kWsAdk_9EAYFoXdkw.md 'global::AudioScript.PlayStackable(AudioClip, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(string, bool, byte, float, float, float)](AudioScript_PlayStackable_3WqA1E4LKQLCz_Laqq7Akg.md 'global::AudioScript.PlayStackable(string, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Stop()](AudioScript_Stop().md 'global::AudioScript.Stop()') | Stops playing the clip.<br/> |
| [Unpause()](AudioScript_Unpause().md 'global::AudioScript.Unpause()') | Unpauses the paused playback of this [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource').<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator AudioSource(AudioScript)](AudioScript_op_Explicit_UqoG96nU+YwVbWBlTT0mhw.md 'global::AudioScript.op_Explicit AudioSource(global::AudioScript)') | Returns the [AudioSource](AudioScript_AudioSource.md 'global::AudioScript.AudioSource').<br/> |
