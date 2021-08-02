#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine&lt;T1,T2&gt; Class
Advanced coroutine handler.   
```csharp
public sealed class Routine<T1,T2> : KeepCoding.Internal.RoutineBase
```
#### Type parameters
<a name='KeepCoding_Routine_T1_T2__T1'></a>
`T1`  
  
<a name='KeepCoding_Routine_T1_T2__T2'></a>
`T2`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine&lt;T1,T2&gt;  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;T1,T2,IEnumerator&gt;, MonoBehaviour)](Routine_T1_T2___ctor_PKOe8_8O9eRmAKfkf4tMzw.md 'KeepCoding.Routine&lt;T1,T2&gt;.Routine(System.Func&lt;T1,T2,System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(T1, T2, bool)](Routine_T1_T2__Restart_tLk7h_weR6Bq_psFM20eCA.md 'KeepCoding.Routine&lt;T1,T2&gt;.Restart(T1, T2, bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(T1, T2, bool)](Routine_T1_T2__RestartAll_Kf5rGRaOsx_Vrl72kjTvRQ.md 'KeepCoding.Routine&lt;T1,T2&gt;.RestartAll(T1, T2, bool)') | Restarts all coroutines currently running.<br/> |
| [Start(T1, T2, bool, bool)](Routine_T1_T2__Start_X6yAvqtEoNCMEJmUxiTeCQ.md 'KeepCoding.Routine&lt;T1,T2&gt;.Start(T1, T2, bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](Routine_T1_T2__Start_X6yAvqtEoNCMEJmUxiTeCQ.md#KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_allowMultiple 'KeepCoding.Routine&lt;T1,T2&gt;.Start(T1, T2, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(T1, T2, bool, bool)](Routine_T1_T2__StartOrRestart_nLOBMokxatNxTCRI1GNF2w.md 'KeepCoding.Routine&lt;T1,T2&gt;.StartOrRestart(T1, T2, bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
