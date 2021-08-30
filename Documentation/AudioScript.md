#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## AudioScript Class
Encapsulates an [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') and scales it with the game's volume using [SFXVolume](Game.PlayerSettings.SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') and [MusicVolume](Game.PlayerSettings.MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume').  
```csharp
public abstract class AudioScript : KeepCoding.CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; AudioScript  

| Fields | |
| :--- | :--- |
| [_audioClips](AudioScript._audioClips.md 'KeepCoding.AudioScript._audioClips') | The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of clips it can play from.<br/> |
| [_audioSource](AudioScript._audioSource.md 'KeepCoding.AudioScript._audioSource') | The audio source field.<br/> |
| [_isSFX](AudioScript._isSFX.md 'KeepCoding.AudioScript._isSFX') | Setting this value to true will make the volume relative to [MusicVolume](Game.PlayerSettings.MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume'), and [SFXVolume](Game.PlayerSettings.SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') otherwise.<br/> |

| Properties | |
| :--- | :--- |
| [AudioClips](AudioScript.AudioClips.md 'KeepCoding.AudioScript.AudioClips') | The audio clips used by the [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource')s.<br/> |
| [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') | The main [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource') property. If the field it is referencing is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') then it adds a component.<br/> |
| [Game](AudioScript.Game.md 'KeepCoding.AudioScript.Game') | The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.<br/> |
| [IsMuted](AudioScript.IsMuted.md 'KeepCoding.AudioScript.IsMuted') | Determines if the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') is muted.<br/> |
| [IsPlaying](AudioScript.IsPlaying.md 'KeepCoding.AudioScript.IsPlaying') | Determines if the audio source is currently playing.<br/> |
| [Relative](AudioScript.Relative.md 'KeepCoding.AudioScript.Relative') | The volume the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') is playing at, determined by [Volume](AudioScript.Volume.md 'KeepCoding.AudioScript.Volume') and [Game](AudioScript.Game.md 'KeepCoding.AudioScript.Game').<br/> |
| [Volume](AudioScript.Volume.md 'KeepCoding.AudioScript.Volume') | The volume of the sound relative to the game.<br/> |

| Methods | |
| :--- | :--- |
| [Fade(float, float)](AudioScript.Fade.WC9X5nEr7j1Gp0ESMFUtgA.md 'KeepCoding.AudioScript.Fade(float, float)') | Fades the audio source to a specific volume from a specified duration of time linearly.<br/> |
| [Pause()](AudioScript.Pause().md 'KeepCoding.AudioScript.Pause()') | Pauses playing the clip.<br/> |
| [Play(AudioClip, bool, byte, float, float, float, float)](AudioScript.Play.truQh4xxa0+U54BHyBx6eg.md 'KeepCoding.AudioScript.Play(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Play(string, bool, byte, float, float, float, float)](AudioScript.Play.G.mi16CZqzruAO0q01QfyA.md 'KeepCoding.AudioScript.Play(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(AudioClip, bool, byte, float, float, float)](AudioScript.PlayStackable.LDgqzdk5VvN.rLhoaKYMaw.md 'KeepCoding.AudioScript.PlayStackable(AudioClip, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(string, bool, byte, float, float, float)](AudioScript.PlayStackable.5wMOmTveFdtv7+F9UuDjPg.md 'KeepCoding.AudioScript.PlayStackable(string, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Stop()](AudioScript.Stop().md 'KeepCoding.AudioScript.Stop()') | Stops playing the clip.<br/> |
| [Unpause()](AudioScript.Unpause().md 'KeepCoding.AudioScript.Unpause()') | Unpauses the paused playback of this [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator AudioSource(AudioScript)](AudioScript.op_Explicit.i.NWagYProERkVCwMRcCuw.md 'KeepCoding.AudioScript.op_Explicit AudioSource(KeepCoding.AudioScript)') | Returns the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |
