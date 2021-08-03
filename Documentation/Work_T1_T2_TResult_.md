#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T1,T2,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T1,T2,TResult> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T1_T2_TResult__T1'></a>
`T1`  
  
<a name='KeepCoding_Work_T1_T2_TResult__T2'></a>
`T2`  
  
<a name='KeepCoding_Work_T1_T2_TResult__TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T1,T2,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T1,T2,TResult&gt;)](Work_T1_T2_TResult___ctor_hFJvAsaHVj8W9tPxFFdb9g.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Work(System.Func&lt;T1,T2,TResult&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T1,T2,TResult&gt;, bool, uint)](Work_T1_T2_TResult___ctor_KOIrEua3SD0eMBxgH1sAGg.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Work(System.Func&lt;T1,T2,TResult&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](Work_T1_T2_TResult__Result.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start(T1, T2)](Work_T1_T2_TResult__Start_BF_ogjrRlqUOI5p_bZv0xg.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;.Start(T1, T2)') | Starts a new thread, and waits until it is finished before halting.<br/> |