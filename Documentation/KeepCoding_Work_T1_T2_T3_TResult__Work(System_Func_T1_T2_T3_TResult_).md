#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T1,T2,T3,TResult&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')
## Work&lt;T1,T2,T3,TResult&gt;.Work(Func&lt;T1,T2,T3,TResult&gt;) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Func<T1,T2,T3,TResult> work);
```
#### Parameters
<a name='KeepCoding_Work_T1_T2_T3_TResult__Work(System_Func_T1_T2_T3_TResult_)_work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](KeepCoding_Work_T1_T2_T3_TResult_.md#KeepCoding_Work_T1_T2_T3_TResult__T1 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](KeepCoding_Work_T1_T2_T3_TResult_.md#KeepCoding_Work_T1_T2_T3_TResult__T2 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](KeepCoding_Work_T1_T2_T3_TResult_.md#KeepCoding_Work_T1_T2_T3_TResult__T3 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](KeepCoding_Work_T1_T2_T3_TResult_.md#KeepCoding_Work_T1_T2_T3_TResult__TResult 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The method to call when thread starts.
  
