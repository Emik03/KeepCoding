#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToRoutine&lt;T1,T2&gt;(MonoBehaviour, Func&lt;T1,T2,IEnumerator&gt;) Method
Converts arguments to a new [Routine&lt;T1,T2&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;').  
```csharp
public static KeepCoding.Routine<T1,T2> ToRoutine<T1,T2>(this MonoBehaviour monoBehaviour, System.Func<T1,T2,System.Collections.IEnumerator> func);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T1'></a>
`T1`  
  
<a name='KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T2'></a>
`T2`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The instance of the [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') from.
  
<a name='KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](TypeHelper.ToRoutine.uiMA2Jngo634Nfa1KgQJgQ.md#KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T1 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2&gt;(MonoBehaviour, System.Func&lt;T1,T2,System.Collections.IEnumerator&gt;).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](TypeHelper.ToRoutine.uiMA2Jngo634Nfa1KgQJgQ.md#KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T2 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2&gt;(MonoBehaviour, System.Func&lt;T1,T2,System.Collections.IEnumerator&gt;).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The function to call when the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') is called.
  
#### Returns
[KeepCoding.Routine&lt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')[T1](TypeHelper.ToRoutine.uiMA2Jngo634Nfa1KgQJgQ.md#KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T1 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2&gt;(MonoBehaviour, System.Func&lt;T1,T2,System.Collections.IEnumerator&gt;).T1')[,](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')[T2](TypeHelper.ToRoutine.uiMA2Jngo634Nfa1KgQJgQ.md#KeepCoding.TypeHelper.ToRoutine.T1.T2.(MonoBehaviour.System.Func.T1.T2.System.Collections.IEnumerator.).T2 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2&gt;(MonoBehaviour, System.Func&lt;T1,T2,System.Collections.IEnumerator&gt;).T2')[&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')  
A new [Routine&lt;T1,T2&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;') containing the arguments provided.
