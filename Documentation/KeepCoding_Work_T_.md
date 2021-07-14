#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T> : KeepCoding.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase') &#129106; Work&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T&gt;, bool, uint)](KeepCoding_Work_T__Work(System_Func_T__bool_uint).md 'KeepCoding.Work&lt;T&gt;.Work(System.Func&lt;T&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](KeepCoding_Work_T__Result.md 'KeepCoding.Work&lt;T&gt;.Result') |  |

| Methods | |
| :--- | :--- |
| [Start()](KeepCoding_Work_T__Start().md 'KeepCoding.Work&lt;T&gt;.Start()') | Starts a new thread, and waits until it is finished before halting.<br/> |
