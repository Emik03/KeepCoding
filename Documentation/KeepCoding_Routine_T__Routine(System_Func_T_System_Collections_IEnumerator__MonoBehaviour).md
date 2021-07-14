#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;')
## Routine&lt;T&gt;.Routine(Func&lt;T,IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<T,System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding_Routine_T__Routine(System_Func_T_System_Collections_IEnumerator__MonoBehaviour)_enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_Routine_T_.md#KeepCoding_Routine_T__T 'KeepCoding.Routine&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The enumerator to call when initiated.
  
<a name='KeepCoding_Routine_T__Routine(System_Func_T_System_Collections_IEnumerator__MonoBehaviour)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
