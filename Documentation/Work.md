#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work Class
Advanced multi-threading handler.  
```csharp
public sealed class Work : KeepCoding.Internal.WorkBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work  

| Constructors | |
| :--- | :--- |
| [Work(Action)](Work__ctor_3Ex8PcsQ4pGvalkF8Yab6Q.md 'KeepCoding.Work.Work(System.Action)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Action, bool, uint)](Work__ctor_tnhidf+Y8CDeKLDkdBlyKg.md 'KeepCoding.Work.Work(System.Action, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Methods | |
| :--- | :--- |
| [Start()](Work_Start().md 'KeepCoding.Work.Start()') | Starts a new thread, and waits until it is finished before halting.<br/> |
