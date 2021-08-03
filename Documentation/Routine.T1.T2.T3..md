#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Routine&lt;T1,T2,T3&gt; Class
Advanced coroutine handler.   
```csharp
public sealed class Routine<T1,T2,T3> : KeepCoding.Internal.RoutineBase
```
#### Type parameters
<a name='KeepCoding.Routine.T1.T2.T3..T1'></a>
`T1`  
  
<a name='KeepCoding.Routine.T1.T2.T3..T2'></a>
`T2`  
  
<a name='KeepCoding.Routine.T1.T2.T3..T3'></a>
`T3`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') &#129106; Routine&lt;T1,T2,T3&gt;  

| Constructors | |
| :--- | :--- |
| [Routine(Func&lt;T1,T2,T3,IEnumerator&gt;, MonoBehaviour)](Routine.T1.T2.T3...ctor.T+zWB0IIDKJECAK5L24EHg.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;.Routine(System.Func&lt;T1,T2,T3,System.Collections.IEnumerator&gt;, MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Methods | |
| :--- | :--- |
| [Restart(T1, T2, T3, bool)](Routine.T1.T2.T3..Restart.KuFGFtKSySAUIs4qPvoGtQ.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;.Restart(T1, T2, T3, bool)') | Stops and restarts the first coroutine that was run.<br/> |
| [RestartAll(T1, T2, T3, bool)](Routine.T1.T2.T3..RestartAll.Xj5oIlvMAcGXAjotg9DW5Q.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;.RestartAll(T1, T2, T3, bool)') | Restarts all coroutines currently running.<br/> |
| [Start(T1, T2, T3, bool, bool)](Routine.T1.T2.T3..Start.XDY7uU1hn0pvrY8x.2162g.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;.Start(T1, T2, T3, bool, bool)') | Starts the coroutine. Unless specified by [allowMultiple](Routine.T1.T2.T3..Start.XDY7uU1hn0pvrY8x.2162g.md#KeepCoding.Routine.T1.T2.T3..Start(T1.T2.T3.bool.bool).allowMultiple 'KeepCoding.Routine&lt;T1,T2,T3&gt;.Start(T1, T2, T3, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.<br/> |
| [StartOrRestart(T1, T2, T3, bool, bool)](Routine.T1.T2.T3..StartOrRestart.hex+kTD2hWFqBeOGSt.vfg.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;.StartOrRestart(T1, T2, T3, bool, bool)') | Starts a coroutine if no coroutines are running, otherwise restarts.<br/> |
