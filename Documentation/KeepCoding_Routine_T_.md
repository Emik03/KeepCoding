#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine&lt;T&gt; Class
Advanced coroutine handler.   
```csharp
public sealed class Routine<T> : KeepCoding.Internal.RoutineBase
```
#### Type parameters
<a name='KeepCoding_Routine_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](KeepCoding_Internal_RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;T,IEnumerator&gt;, MonoBehaviour)](KeepCoding_Routine_T__Routine(System_Func_T_System_Collections_IEnumerator__MonoBehaviour).md 'KeepCoding.Routine&lt;T&gt;.Routine(System.Func&lt;T,System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(T, bool)](KeepCoding_Routine_T__Restart(T_bool).md 'KeepCoding.Routine&lt;T&gt;.Restart(T, bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(T, bool)](KeepCoding_Routine_T__RestartAll(T_bool).md 'KeepCoding.Routine&lt;T&gt;.RestartAll(T, bool)') | Restarts all coroutines currently running.<br/> |
| [Start(T, bool, bool)](KeepCoding_Routine_T__Start(T_bool_bool).md 'KeepCoding.Routine&lt;T&gt;.Start(T, bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](KeepCoding_Routine_T__Start(T_bool_bool).md#KeepCoding_Routine_T__Start(T_bool_bool)_allowMultiple 'KeepCoding.Routine&lt;T&gt;.Start(T, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(T, bool, bool)](KeepCoding_Routine_T__StartOrRestart(T_bool_bool).md 'KeepCoding.Routine&lt;T&gt;.StartOrRestart(T, bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
