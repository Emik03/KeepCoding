#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToRoutine(MonoBehaviour, Func&lt;IEnumerator&gt;) Method
Converts arguments to a new [Routine](KeepCoding_Routine.md 'KeepCoding.Routine').  
```csharp
public static KeepCoding.Routine ToRoutine(this MonoBehaviour monoBehaviour, System.Func<System.Collections.IEnumerator> func);
```
#### Parameters
<a name='KeepCoding_TypeHelper_ToRoutine(MonoBehaviour_System_Func_System_Collections_IEnumerator_)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The instance of the [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') from.
  
<a name='KeepCoding_TypeHelper_ToRoutine(MonoBehaviour_System_Func_System_Collections_IEnumerator_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to call when the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') is called.
  
#### Returns
[Routine](KeepCoding_Routine.md 'KeepCoding.Routine')  
A new [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') containing the arguments provided.
