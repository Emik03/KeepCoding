#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Profiler](Profiler.md 'KeepCoding.Profiler')
## Profiler.Profiler(Action&lt;string,LogType&gt;, LogType) Constructor
Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') and [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.  
```csharp
public Profiler(System.Action<string,LogType> action, LogType type=3);
```
#### Parameters
<a name='KeepCoding.Profiler.Profiler(System.Action.string.LogType..LogType).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to run when disposed.
  
<a name='KeepCoding.Profiler.Profiler(System.Action.string.LogType..LogType).type'></a>
`type` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging to perform.
  
