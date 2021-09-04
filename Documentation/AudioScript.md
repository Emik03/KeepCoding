#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## AudioScript Class
Encapsulates an [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') and scales it with the game's volume using [SFXVolume](Game.PlayerSettings.SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') and [MusicVolume](Game.PlayerSettings.MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume').  
```csharp
public abstract class AudioScript : KeepCoding.CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; AudioScript  

| Properties | |
| :--- | :--- |
| [AudioClips](AudioScript.AudioClips.md 'KeepCoding.AudioScript.AudioClips') | The audio clips used by the [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource')s.<br/> |
| [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') | The main [UnityEngine.AudioSource](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource 'UnityEngine.AudioSource') property. If the field it is referencing is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') then it adds a component.<br/> |
| [Game](AudioScript.Game.md 'KeepCoding.AudioScript.Game') | The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.<br/> |
| [IsMuted](AudioScript.IsMuted.md 'KeepCoding.AudioScript.IsMuted') | Determines if the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') is muted.<br/> |
| [IsPlaying](AudioScript.IsPlaying.md 'KeepCoding.AudioScript.IsPlaying') | Determines if the audio source is currently playing.<br/> |
| [IsSFX](AudioScript.IsSFX.md 'KeepCoding.AudioScript.IsSFX') | Determines if [UnityEngine.AudioSource.volume](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioSource.volume 'UnityEngine.AudioSource.volume') in [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') is scaled using [SFXVolume](Game.PlayerSettings.SFXVolume.md 'KeepCoding.Game.PlayerSettings.SFXVolume') when [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') and [MusicVolume](Game.PlayerSettings.MusicVolume.md 'KeepCoding.Game.PlayerSettings.MusicVolume') when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<br/> |
| [Relative](AudioScript.Relative.md 'KeepCoding.AudioScript.Relative') | The volume the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource') is playing at, determined by [Volume](AudioScript.Volume.md 'KeepCoding.AudioScript.Volume') and [Game](AudioScript.Game.md 'KeepCoding.AudioScript.Game').<br/> |
| [Volume](AudioScript.Volume.md 'KeepCoding.AudioScript.Volume') | The volume of the sound relative to the game.<br/> |

| Methods | |
| :--- | :--- |
| [Awake()](AudioScript.Awake().md 'KeepCoding.AudioScript.Awake()') | Sets up base functionality for the audio. If you declare this method yourself, make sure to call `base.Awake()` to ensure that this component initializes correctly, or use [OnAwake()](AudioScript.OnAwake().md 'KeepCoding.AudioScript.OnAwake()') instead.<br/> |
| [Fade(float, float)](AudioScript.Fade.WC9X5nEr7j1Gp0ESMFUtgA.md 'KeepCoding.AudioScript.Fade(float, float)') | Fades the audio source to a specific volume from a specified duration of time linearly.<br/> |
| [OnAwake()](AudioScript.OnAwake().md 'KeepCoding.AudioScript.OnAwake()') | Called when the module instantiates, well before the lights turn on.<br/> |
| [OnUpdate()](AudioScript.OnUpdate().md 'KeepCoding.AudioScript.OnUpdate()') | Called on every frame. Frame-rate might vary depending on setup, so make sure to use [UnityEngine.Time.deltaTime](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Time.deltaTime 'UnityEngine.Time.deltaTime') or similar for time-sensitive applications.<br/> |
| [Pause()](AudioScript.Pause().md 'KeepCoding.AudioScript.Pause()') | Pauses playing the clip.<br/> |
| [Play(AudioClip, bool, byte, float, float, float, float)](AudioScript.Play.truQh4xxa0+U54BHyBx6eg.md 'KeepCoding.AudioScript.Play(AudioClip, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Play(string, bool, byte, float, float, float, float)](AudioScript.Play.G.mi16CZqzruAO0q01QfyA.md 'KeepCoding.AudioScript.Play(string, bool, byte, float, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(AudioClip, bool, byte, float, float, float)](AudioScript.PlayStackable.LDgqzdk5VvN.rLhoaKYMaw.md 'KeepCoding.AudioScript.PlayStackable(AudioClip, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [PlayStackable(string, bool, byte, float, float, float)](AudioScript.PlayStackable.5wMOmTveFdtv7+F9UuDjPg.md 'KeepCoding.AudioScript.PlayStackable(string, bool, byte, float, float, float)') | Plays a sound, with optional parameters.<br/> |
| [Stop()](AudioScript.Stop().md 'KeepCoding.AudioScript.Stop()') | Stops playing the clip.<br/> |
| [Unpause()](AudioScript.Unpause().md 'KeepCoding.AudioScript.Unpause()') | Unpauses the paused playback of this [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |
| [Update()](AudioScript.Update().md 'KeepCoding.AudioScript.Update()') | Updates the volume of [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource'). If you declare this method yourself, make sure to call `base.Update()` to ensure that this component retains functionality, or use [OnUpdate()](AudioScript.OnUpdate().md 'KeepCoding.AudioScript.OnUpdate()') instead.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator AudioSource(AudioScript)](AudioScript.op_Explicit.i.NWagYProERkVCwMRcCuw.md 'KeepCoding.AudioScript.op_Explicit AudioSource(KeepCoding.AudioScript)') | Returns the [AudioSource](AudioScript.AudioSource.md 'KeepCoding.AudioScript.AudioSource').<br/> |
