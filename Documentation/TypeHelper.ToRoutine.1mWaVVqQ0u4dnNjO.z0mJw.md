#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToRoutine&lt;T&gt;(MonoBehaviour, Func&lt;T,IEnumerator&gt;) Method
Converts arguments to a new [Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;').  
```csharp
public static KeepCoding.Routine<T> ToRoutine<T>(this MonoBehaviour monoBehaviour, System.Func<T,System.Collections.IEnumerator> func);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToRoutine.T.(MonoBehaviour.System.Func.T.System.Collections.IEnumerator.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToRoutine.T.(MonoBehaviour.System.Func.T.System.Collections.IEnumerator.).monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The instance of the [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') from.
  
<a name='KeepCoding.TypeHelper.ToRoutine.T.(MonoBehaviour.System.Func.T.System.Collections.IEnumerator.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TypeHelper.ToRoutine.1mWaVVqQ0u4dnNjO.z0mJw.md#KeepCoding.TypeHelper.ToRoutine.T.(MonoBehaviour.System.Func.T.System.Collections.IEnumerator.).T 'KeepCoding.TypeHelper.ToRoutine&lt;T&gt;(MonoBehaviour, System.Func&lt;T,System.Collections.IEnumerator&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to call when the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') is called.
  
#### Returns
[KeepCoding.Routine&lt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;')[T](TypeHelper.ToRoutine.1mWaVVqQ0u4dnNjO.z0mJw.md#KeepCoding.TypeHelper.ToRoutine.T.(MonoBehaviour.System.Func.T.System.Collections.IEnumerator.).T 'KeepCoding.TypeHelper.ToRoutine&lt;T&gt;(MonoBehaviour, System.Func&lt;T,System.Collections.IEnumerator&gt;).T')[&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;')  
A new [Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;') containing the arguments provided.
