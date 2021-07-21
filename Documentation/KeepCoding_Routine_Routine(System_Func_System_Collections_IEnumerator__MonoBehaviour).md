#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
## Routine.Routine(Func&lt;IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding_Routine_Routine(System_Func_System_Collections_IEnumerator__MonoBehaviour)_enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The enumerator to call when initiated.
  
<a name='KeepCoding_Routine_Routine(System_Func_System_Collections_IEnumerator__MonoBehaviour)_monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
