#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Sound](KeepCoding_Sound.md 'KeepCoding.Sound')
## Sound.Method(KMAudio) Method
Gets the corresponding sound method matching the arguments of this instance of [Sound](KeepCoding_Sound.md 'KeepCoding.Sound').  
```csharp
public System.Func<Transform,bool,KMAudioRef> Method(KMAudio audio);
```
#### Parameters
<a name='KeepCoding_Sound_Method(KMAudio)_audio'></a>
`audio` [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')  
The instance of [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to play from.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudioRef 'KMAudioRef')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
A method that when called, will play the sound and return the [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') instance.
