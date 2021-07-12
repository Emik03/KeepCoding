### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2&gt;](KeepCoding_Routine_T1_T2_.md 'KeepCoding.Routine&lt;T1,T2&gt;')
## Routine&lt;T1,T2&gt;.Routine(Func&lt;T1,T2,IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<T1,T2,System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2__Routine(System_Func_T1_T2_System_Collections_IEnumerator__MonoBehaviour)_enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](KeepCoding_Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T1 'KeepCoding.Routine&lt;T1,T2&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](KeepCoding_Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T2 'KeepCoding.Routine&lt;T1,T2&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The enumerator to call when initiated.
  
<a name='KeepCoding_Routine_T1_T2__Routine(System_Func_T1_T2_System_Collections_IEnumerator__MonoBehaviour)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
