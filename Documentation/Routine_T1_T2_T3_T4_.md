#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine&lt;T1,T2,T3,T4&gt; Class
Advanced coroutine handler.   
```csharp
public sealed class Routine<T1,T2,T3,T4> : KeepCoding.Internal.RoutineBase
```
#### Type parameters
<a name='KeepCoding_Routine_T1_T2_T3_T4__T1'></a>
`T1`  
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__T2'></a>
`T2`  
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__T3'></a>
`T3`  
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__T4'></a>
`T4`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine&lt;T1,T2,T3,T4&gt;  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;T1,T2,T3,T4,IEnumerator&gt;, MonoBehaviour)](Routine_T1_T2_T3_T4___ctor_KrHzXo88QLCVCqmqNs9UwQ.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.Routine(System.Func&lt;T1,T2,T3,T4,System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(T1, T2, T3, T4, bool)](Routine_T1_T2_T3_T4__Restart_u7SwdKSqhhGLuyqbp_sO7A.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.Restart(T1, T2, T3, T4, bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(T1, T2, T3, T4, bool)](Routine_T1_T2_T3_T4__RestartAll_Xock+St6PWEgyfDOJ8oAAQ.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.RestartAll(T1, T2, T3, T4, bool)') | Restarts all coroutines currently running.<br/> |
| [Start(T1, T2, T3, T4, bool, bool)](Routine_T1_T2_T3_T4__Start_bLZl9t3VFS8o30l4VzrfEg.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.Start(T1, T2, T3, T4, bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](Routine_T1_T2_T3_T4__Start_bLZl9t3VFS8o30l4VzrfEg.md#KeepCoding_Routine_T1_T2_T3_T4__Start(T1_T2_T3_T4_bool_bool)_allowMultiple 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.Start(T1, T2, T3, T4, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(T1, T2, T3, T4, bool, bool)](Routine_T1_T2_T3_T4__StartOrRestart_381w_Fwb_TYDV3zkIIY8ZQ.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.StartOrRestart(T1, T2, T3, T4, bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
