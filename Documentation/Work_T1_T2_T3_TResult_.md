#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T1,T2,T3,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T1,T2,T3,TResult> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding_Work_T1_T2_T3_TResult__T1'></a>
`T1`  
  
<a name='KeepCoding_Work_T1_T2_T3_TResult__T2'></a>
`T2`  
  
<a name='KeepCoding_Work_T1_T2_T3_TResult__T3'></a>
`T3`  
  
<a name='KeepCoding_Work_T1_T2_T3_TResult__TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T1,T2,T3,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T1,T2,T3,TResult&gt;)](Work_T1_T2_T3_TResult___ctor_3+agUKpa+a09XSrT0ROyHw.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.Work(System.Func&lt;T1,T2,T3,TResult&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T1,T2,T3,TResult&gt;, bool, uint)](Work_T1_T2_T3_TResult___ctor_ua8YPCtLekdFGJChxz0avQ.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.Work(System.Func&lt;T1,T2,T3,TResult&gt;, bool, uint)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](Work_T1_T2_T3_TResult__Result.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start(T1, T2, T3)](Work_T1_T2_T3_TResult__Start_8+GLEmXLJUwCvd1y5vVz3A.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.Start(T1, T2, T3)') | Starts a new thread, and waits until it is finished before halting.<br/> |