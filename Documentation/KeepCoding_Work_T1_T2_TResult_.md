#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T1,T2,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T1,T2,TResult> : KeepCoding.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T1_T2_TResult__T1'></a>
`T1`  
  
<a name='KeepCoding_Work_T1_T2_TResult__T2'></a>
`T2`  
  
<a name='KeepCoding_Work_T1_T2_TResult__TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase') &#129106; Work&lt;T1,T2,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T1,T2,TResult&gt;, bool, uint)](KeepCoding_Work_T1_T2_TResult__Work(System_Func_T1_T2_TResult__bool_uint).md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Work(System.Func&lt;T1,T2,TResult&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](KeepCoding_Work_T1_T2_TResult__Result.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Result') |  |

| Methods | |
| :--- | :--- |
| [Start(T1, T2)](KeepCoding_Work_T1_T2_TResult__Start(T1_T2).md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Start(T1, T2)') | Starts a new thread, and waits until it is finished before halting.<br/> |
