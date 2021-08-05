#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Profiler](Profiler.md 'KeepCoding.Profiler')
## Profiler.Profiler(Action&lt;string&gt;) Constructor
Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.  
```csharp
public Profiler(System.Action<string> action);
```
#### Parameters
<a name='KeepCoding.Profiler.Profiler(System.Action.string.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when disposed.
  
