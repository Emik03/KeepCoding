#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine&lt;T&gt; Class
Advanced coroutine handler.   
```csharp
public sealed class Routine<T> : KeepCoding.Internal.RoutineBase
```
#### Type parameters
<a name='KeepCoding.Routine.T..T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;T,IEnumerator&gt;, MonoBehaviour)](Routine.T...ctor.cp.OYxo5+yjbryeOm00n9Q.md 'KeepCoding.Routine&lt;T&gt;.Routine(System.Func&lt;T,System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(T, bool)](Routine.T..Restart.ki6QVlwITXHVkS4zYk1n3Q.md 'KeepCoding.Routine&lt;T&gt;.Restart(T, bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(T, bool)](Routine.T..RestartAll.R0u6VlC.beA2RG.OrtNPsw.md 'KeepCoding.Routine&lt;T&gt;.RestartAll(T, bool)') | Restarts all coroutines currently running.<br/> |
| [Start(T, bool, bool)](Routine.T..Start.5YTEEAMvgsalavt.xnhsvQ.md 'KeepCoding.Routine&lt;T&gt;.Start(T, bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](Routine.T..Start.5YTEEAMvgsalavt.xnhsvQ.md#KeepCoding.Routine.T..Start(T.bool.bool).allowMultiple 'KeepCoding.Routine&lt;T&gt;.Start(T, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(T, bool, bool)](Routine.T..StartOrRestart.R.OclO4N0ECKSyRdfeygaQ.md 'KeepCoding.Routine&lt;T&gt;.StartOrRestart(T, bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
