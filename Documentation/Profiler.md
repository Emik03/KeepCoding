#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Profiler Class
Times your code and runs a method after [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.  
```csharp
public sealed class Profiler :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Profiler  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Constructors | |
| :--- | :--- |
| [Profiler()](Profiler.Profiler().md 'KeepCoding.Profiler.Profiler()') | Creates a profiler that will not run any actions.<br/> |
| [Profiler(Action&lt;string&gt;)](Profiler..ctor.o0XCiX2Jqv.1RSp05VjnCg.md 'KeepCoding.Profiler.Profiler(System.Action&lt;string&gt;)') | Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.<br/> |
| [Profiler(Action&lt;string,LogType&gt;, LogType)](Profiler..ctor.bWOZBKilqE7JLX5kkr8EeA.md 'KeepCoding.Profiler.Profiler(System.Action&lt;string,LogType&gt;, LogType)') | Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') and [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.<br/> |
| [Profiler(Action&lt;TimeSpan&gt;)](Profiler..ctor.cAmR.q.EhUFxB5hpwGGLUQ.md 'KeepCoding.Profiler.Profiler(System.Action&lt;System.TimeSpan&gt;)') | Creates a profiler that will run an [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') with a [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') as the resulting parameter when [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') runs.<br/> |

| Properties | |
| :--- | :--- |
| [Elapsed](Profiler.Elapsed.md 'KeepCoding.Profiler.Elapsed') | The current amount of time that has been elapsed since the creation of this [Profiler](Profiler.md 'KeepCoding.Profiler').<br/> |

| Methods | |
| :--- | :--- |
| [Dispose()](Profiler.Dispose().md 'KeepCoding.Profiler.Dispose()') | Stops the timer and runs the action.<br/> |
| [Stop()](Profiler.Stop().md 'KeepCoding.Profiler.Stop()') | Stops the timer and returns the time elapsed.<br/> |
