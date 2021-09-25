#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.StopSounds&lt;T&gt;(T) Method
Stops all sounds for the entire [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T StopSounds<T>(this T audioRefs)
    where T : System.Collections.Generic.IEnumerable<KMAudioRef>;
```
#### Type parameters
<a name='KeepCoding.EventHelper.StopSounds.T.(T).T'></a>
`T`  
The type of iterator containing [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef').
  
#### Parameters
<a name='KeepCoding.EventHelper.StopSounds.T.(T).audioRefs'></a>
`audioRefs` [T](EventHelper.StopSounds.kXwq2kh3sq5cPTMnZgmkPw.md#KeepCoding.EventHelper.StopSounds.T.(T).T 'KeepCoding.EventHelper.StopSounds&lt;T&gt;(T).T')  
The [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to mute all sounds from, using [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound').
  
#### Returns
[T](EventHelper.StopSounds.kXwq2kh3sq5cPTMnZgmkPw.md#KeepCoding.EventHelper.StopSounds.T.(T).T 'KeepCoding.EventHelper.StopSounds&lt;T&gt;(T).T')  
