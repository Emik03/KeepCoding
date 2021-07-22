#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](KeepCoding_Internal_WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T&gt;)](KeepCoding_Work_T__Work(System_Func_T_).md 'KeepCoding.Work&lt;T&gt;.Work(System.Func&lt;T&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T&gt;, bool, uint)](KeepCoding_Work_T__Work(System_Func_T__bool_uint).md 'KeepCoding.Work&lt;T&gt;.Work(System.Func&lt;T&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](KeepCoding_Work_T__Result.md 'KeepCoding.Work&lt;T&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start()](KeepCoding_Work_T__Start().md 'KeepCoding.Work&lt;T&gt;.Start()') | Starts a new thread, and waits until it is finished before halting.<br/> |
