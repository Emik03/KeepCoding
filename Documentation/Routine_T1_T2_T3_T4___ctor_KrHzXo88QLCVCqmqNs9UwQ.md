#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3,T4&gt;](Routine_T1_T2_T3_T4_.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')
## Routine&lt;T1,T2,T3,T4&gt;.Routine(Func&lt;T1,T2,T3,T4,IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<T1,T2,T3,T4,System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2_T3_T4__Routine(System_Func_T1_T2_T3_T4_System_Collections_IEnumerator__MonoBehaviour)_enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T1 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T2 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T3 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T4 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The enumerator to call when initiated.
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__Routine(System_Func_T1_T2_T3_T4_System_Collections_IEnumerator__MonoBehaviour)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
