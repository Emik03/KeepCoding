### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T,TResult> : KeepCoding.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T_TResult__T'></a>
`T`  
  
<a name='KeepCoding_Work_T_TResult__TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase') &#129106; Work&lt;T,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T,TResult&gt;, bool, uint)](KeepCoding_Work_T_TResult__Work(System_Func_T_TResult__bool_uint).md 'KeepCoding.Work&lt;T,TResult&gt;.Work(System.Func&lt;T,TResult&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](KeepCoding_Work_T_TResult__Result.md 'KeepCoding.Work&lt;T,TResult&gt;.Result') |  |

| Methods | |
| :--- | :--- |
| [Start(T)](KeepCoding_Work_T_TResult__Start(T).md 'KeepCoding.Work&lt;T,TResult&gt;.Start(T)') | Starts a new thread, and waits until it is finished before halting.<br/> |
