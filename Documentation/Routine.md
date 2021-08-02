#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine Class
Advanced coroutine handler.  
```csharp
public sealed class Routine : KeepCoding.Internal.RoutineBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;IEnumerator&gt;, MonoBehaviour)](Routine__ctor_j8YS1Hak+D_A3aO6_qbOpw.md 'KeepCoding.Routine.Routine(System.Func&lt;System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(bool)](Routine_Restart_tiaeD598EAO8ZknAc9cnNw.md 'KeepCoding.Routine.Restart(bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(bool)](Routine_RestartAll_EgyhN4gtgrr4AFSmjKwbAA.md 'KeepCoding.Routine.RestartAll(bool)') | Restarts all coroutines currently running.<br/> |
| [Start(bool, bool)](Routine_Start_8GQCDbxvuHyah+YpGO86oQ.md 'KeepCoding.Routine.Start(bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](Routine_Start_8GQCDbxvuHyah+YpGO86oQ.md#KeepCoding_Routine_Start(bool_bool)_allowMultiple 'KeepCoding.Routine.Start(bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(bool, bool)](Routine_StartOrRestart_PSReSAxApy071UTcysCNOw.md 'KeepCoding.Routine.StartOrRestart(bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
