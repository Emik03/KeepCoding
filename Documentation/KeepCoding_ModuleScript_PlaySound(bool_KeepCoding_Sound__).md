#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.PlaySound(bool, Sound[]) Method
Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.  
```csharp
public KeepCoding.Sound[] PlaySound(bool loop, params KeepCoding.Sound[] sounds);
```
#### Parameters
<a name='KeepCoding_ModuleScript_PlaySound(bool_KeepCoding_Sound__)_loop'></a>
`loop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether all sounds listed should loop or not.
  
<a name='KeepCoding_ModuleScript_PlaySound(bool_KeepCoding_Sound__)_sounds'></a>
`sounds` [Sound](KeepCoding_Sound.md 'KeepCoding.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sounds, these can either be [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), [UnityEngine.AudioClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioClip 'UnityEngine.AudioClip'), or [KMSoundOverride.SoundEffect](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect 'KMSoundOverride.SoundEffect').
  
#### Returns
[Sound](KeepCoding_Sound.md 'KeepCoding.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.
#### Exceptions
[UnrecognizedValueException](KeepCoding_UnrecognizedValueException.md 'KeepCoding.UnrecognizedValueException')  
