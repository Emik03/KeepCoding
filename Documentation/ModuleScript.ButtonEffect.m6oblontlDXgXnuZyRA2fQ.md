#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.ButtonEffect(KMSelectable, float, Sound[]) Method
Handles typical button [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract') behaviour.  
```csharp
public void ButtonEffect(KMSelectable selectable, float intensityModifier=0f, params KeepCoding.Sound[] sounds);
```
#### Parameters
<a name='KeepCoding.ModuleScript.ButtonEffect(KMSelectable.float.KeepCoding.Sound..).selectable'></a>
`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
The selectable, which is used as a source for sound and bomb shake.
  
<a name='KeepCoding.ModuleScript.ButtonEffect(KMSelectable.float.KeepCoding.Sound..).intensityModifier'></a>
`intensityModifier` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The intensity of the bomb shaking.
  
<a name='KeepCoding.ModuleScript.ButtonEffect(KMSelectable.float.KeepCoding.Sound..).sounds'></a>
`sounds` [Sound](Sound.md 'KeepCoding.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sounds, these can either be [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), [UnityEngine.AudioClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioClip 'UnityEngine.AudioClip'), or [KMSoundOverride.SoundEffect](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect 'KMSoundOverride.SoundEffect').
  
#### Exceptions
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
