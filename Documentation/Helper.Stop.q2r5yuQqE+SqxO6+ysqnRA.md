#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Stop(MonoBehaviour, Coroutine[]) Method
Stops the coroutines only if they aren't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static Coroutine[] Stop(this MonoBehaviour monoBehaviour, params Coroutine[] coroutines);
```
#### Parameters
<a name='KeepCoding.Helper.Stop(MonoBehaviour.Coroutine..).monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') instance needed to stop coroutines.
  
<a name='KeepCoding.Helper.Stop(MonoBehaviour.Coroutine..).coroutines'></a>
`coroutines` [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')s to stop.
  
#### Returns
[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')s given.
