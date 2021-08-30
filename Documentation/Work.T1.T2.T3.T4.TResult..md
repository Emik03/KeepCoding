#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T1,T2,T3,T4,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T1,T2,T3,T4,TResult> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..T1'></a>
`T1`  
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..T2'></a>
`T2`  
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..T3'></a>
`T3`  
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..T4'></a>
`T4`  
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T1,T2,T3,T4,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T1,T2,T3,T4,TResult&gt;)](Work.T1.T2.T3.T4.TResult...ctor.tyMNA4wesOIJ8a0x+vcLtQ.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.Work(System.Func&lt;T1,T2,T3,T4,TResult&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T1,T2,T3,T4,TResult&gt;, bool, int)](Work.T1.T2.T3.T4.TResult...ctor.EU1gSiYk.nOoWDQb.cVnnw.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.Work(System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool, int)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](Work.T1.T2.T3.T4.TResult..Result.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start(T1, T2, T3, T4)](Work.T1.T2.T3.T4.TResult..Start.CNMTOC2IGnckpUuUtTkcOQ.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.Start(T1, T2, T3, T4)') | Starts a new thread, and waits until it is finished before halting.<br/> |
