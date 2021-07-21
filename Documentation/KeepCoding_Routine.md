#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine Class
Advanced coroutine handler.  
```csharp
public sealed class Routine : KeepCoding.RoutineBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') &#129106; Routine  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;IEnumerator&gt;, MonoBehaviour)](KeepCoding_Routine_Routine(System_Func_System_Collections_IEnumerator__MonoBehaviour).md 'KeepCoding.Routine.Routine(System.Func&lt;System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(bool)](KeepCoding_Routine_Restart(bool).md 'KeepCoding.Routine.Restart(bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(bool)](KeepCoding_Routine_RestartAll(bool).md 'KeepCoding.Routine.RestartAll(bool)') | Restarts all coroutines currently running.<br/> |
| [Start(bool, bool)](KeepCoding_Routine_Start(bool_bool).md 'KeepCoding.Routine.Start(bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](KeepCoding_Routine_Start(bool_bool).md#KeepCoding_Routine_Start(bool_bool)_allowMultiple 'KeepCoding.Routine.Start(bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(bool, bool)](KeepCoding_Routine_StartOrRestart(bool_bool).md 'KeepCoding.Routine.StartOrRestart(bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
