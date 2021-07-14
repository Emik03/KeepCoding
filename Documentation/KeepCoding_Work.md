#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work Class
Advanced multi-threading handler.  
```csharp
public sealed class Work : KeepCoding.WorkBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase') &#129106; Work  

| Constructors | |
| :--- | :--- |
| [Work(Action, bool, uint)](KeepCoding_Work_Work(System_Action_bool_uint).md 'KeepCoding.Work.Work(System.Action, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Methods | |
| :--- | :--- |
| [Start()](KeepCoding_Work_Start().md 'KeepCoding.Work.Start()') | Starts a new thread, and waits until it is finished before halting.<br/> |
