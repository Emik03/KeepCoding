#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')
## Routine&lt;T1,T2&gt;.Routine(Func&lt;T1,T2,IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<T1,T2,System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding.Routine.T1.T2..Routine(System.Func.T1.T2.System.Collections.IEnumerator..MonoBehaviour).enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](Routine.T1.T2..md#KeepCoding.Routine.T1.T2..T1 'KeepCoding.Routine&lt;T1,T2&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](Routine.T1.T2..md#KeepCoding.Routine.T1.T2..T2 'KeepCoding.Routine&lt;T1,T2&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The enumerator to call when initiated.
  
<a name='KeepCoding.Routine.T1.T2..Routine(System.Func.T1.T2.System.Collections.IEnumerator..MonoBehaviour).monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
