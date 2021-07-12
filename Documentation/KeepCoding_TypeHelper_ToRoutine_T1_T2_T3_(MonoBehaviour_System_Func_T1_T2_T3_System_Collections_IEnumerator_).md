### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, Func&lt;T1,T2,T3,IEnumerator&gt;) Method
Converts arguments to a new [Routine&lt;T1,T2,T3&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;').  
```csharp
public static KeepCoding.Routine<T1,T2,T3> ToRoutine<T1,T2,T3>(this MonoBehaviour monoBehaviour, System.Func<T1,T2,T3,System.Collections.IEnumerator> func);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T1'></a>
`T1`  
  
<a name='KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T2'></a>
`T2`  
  
<a name='KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T3'></a>
`T3`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The instance of the [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') from.
  
<a name='KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T1 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T2 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T3 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The function to call when the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') is called.
  
#### Returns
[KeepCoding.Routine&lt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')[T1](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T1 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T1')[,](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')[T2](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T2 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T2')[,](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')[T3](KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_).md#KeepCoding_TypeHelper_ToRoutine_T1_T2_T3_(MonoBehaviour_System_Func_T1_T2_T3_System_Collections_IEnumerator_)_T3 'KeepCoding.TypeHelper.ToRoutine&lt;T1,T2,T3&gt;(MonoBehaviour, System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;).T3')[&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')  
A new [Routine&lt;T1,T2,T3&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;') containing the arguments provided.
