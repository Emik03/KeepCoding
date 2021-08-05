#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Profiler](Profiler.md 'KeepCoding.Profiler')
## Profiler.Profiler(Action&lt;TimeSpan&gt;) Constructor
Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.  
```csharp
public Profiler(System.Action<System.TimeSpan> action);
```
#### Parameters
<a name='KeepCoding.Profiler.Profiler(System.Action.System.TimeSpan.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when disposed.
  
