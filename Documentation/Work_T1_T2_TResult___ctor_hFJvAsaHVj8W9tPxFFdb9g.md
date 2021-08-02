#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T1,T2,TResult&gt;](Work_T1_T2_TResult_.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')
## Work&lt;T1,T2,TResult&gt;.Work(Func&lt;T1,T2,TResult&gt;) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Func<T1,T2,TResult> work);
```
#### Parameters
<a name='KeepCoding_Work_T1_T2_TResult__Work(System_Func_T1_T2_TResult_)_work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](Work_T1_T2_TResult_.md#KeepCoding_Work_T1_T2_TResult__T1 'KeepCoding.Work&lt;T1,T2,TResult&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](Work_T1_T2_TResult_.md#KeepCoding_Work_T1_T2_TResult__T2 'KeepCoding.Work&lt;T1,T2,TResult&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](Work_T1_T2_TResult_.md#KeepCoding_Work_T1_T2_TResult__TResult 'KeepCoding.Work&lt;T1,T2,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The method to call when thread starts.
  
