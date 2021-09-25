#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Sound](Sound.md 'KeepCoding.Sound')
## Sound.StopSounds&lt;T&gt;(T) Method
Stops all sounds for the entire [Sound](Sound.md 'KeepCoding.Sound')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T StopSounds<T>(T sounds)
    where T : System.Collections.Generic.IEnumerable<KeepCoding.Sound>;
```
#### Type parameters
<a name='KeepCoding.Sound.StopSounds.T.(T).T'></a>
`T`  
The collection of sounds to stop.
  
#### Parameters
<a name='KeepCoding.Sound.StopSounds.T.(T).sounds'></a>
`sounds` [T](Sound.StopSounds.+0gH8uuUhUv4gNw18eveqA.md#KeepCoding.Sound.StopSounds.T.(T).T 'KeepCoding.Sound.StopSounds&lt;T&gt;(T).T')  
The [Sound](Sound.md 'KeepCoding.Sound')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to mute all sounds from, using [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound').
  
#### Returns
[T](Sound.StopSounds.+0gH8uuUhUv4gNw18eveqA.md#KeepCoding.Sound.StopSounds.T.(T).T 'KeepCoding.Sound.StopSounds&lt;T&gt;(T).T')  
