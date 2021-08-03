#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3,T4&gt;](Routine.T1.T2.T3.T4..md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')
## Routine&lt;T1,T2,T3,T4&gt;.Routine(Func&lt;T1,T2,T3,T4,IEnumerator&gt;, MonoBehaviour) Constructor
Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.  
```csharp
public Routine(System.Func<T1,T2,T3,T4,System.Collections.IEnumerator> enumerator, MonoBehaviour monoBehaviour);
```
#### Parameters
<a name='KeepCoding.Routine.T1.T2.T3.T4..Routine(System.Func.T1.T2.T3.T4.System.Collections.IEnumerator..MonoBehaviour).enumerator'></a>
`enumerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T1 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T2 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T3 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T4 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The enumerator to call when initiated.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Routine(System.Func.T1.T2.T3.T4.System.Collections.IEnumerator..MonoBehaviour).monoBehaviour'></a>
`monoBehaviour` [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')  
The MonoBehaviour to reference when calling the method.
  
