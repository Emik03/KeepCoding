#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.PlaySound(Transform, Sound[]) Method
Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.  
```csharp
public KeepCoding.Sound[] PlaySound(Transform transform, params KeepCoding.Sound[] sounds);
```
#### Parameters
<a name='KeepCoding.ModuleScript.PlaySound(Transform.KeepCoding.Sound..).transform'></a>
`transform` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')  
The location or sound source of the sound.
  
<a name='KeepCoding.ModuleScript.PlaySound(Transform.KeepCoding.Sound..).sounds'></a>
`sounds` [Sound](Sound.md 'KeepCoding.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sounds, these can either be [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), [UnityEngine.AudioClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioClip 'UnityEngine.AudioClip'), or [KMSoundOverride.SoundEffect](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect 'KMSoundOverride.SoundEffect').
  
#### Returns
[Sound](Sound.md 'KeepCoding.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
