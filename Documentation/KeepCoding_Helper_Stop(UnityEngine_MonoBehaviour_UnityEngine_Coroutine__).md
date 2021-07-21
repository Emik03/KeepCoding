#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Stop(MonoBehaviour, Coroutine[]) Method
Stops the coroutines only if they aren't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static UnityEngine.Coroutine[] Stop(this UnityEngine.MonoBehaviour monoBehaviour, params UnityEngine.Coroutine[] coroutines);
```
#### Parameters
<a name='KeepCoding_Helper_Stop(UnityEngine_MonoBehaviour_UnityEngine_Coroutine__)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') instance needed to stop coroutines.
  
<a name='KeepCoding_Helper_Stop(UnityEngine_MonoBehaviour_UnityEngine_Coroutine__)_coroutines'></a>
`coroutines` [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')s to stop.
  
#### Returns
[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')s given.
