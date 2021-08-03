#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T1,T2,T3,TResult&gt;](Work.T1.T2.T3.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')
## Work&lt;T1,T2,T3,TResult&gt;.Work(Func&lt;T1,T2,T3,TResult&gt;) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Func<T1,T2,T3,TResult> work);
```
#### Parameters
<a name='KeepCoding.Work.T1.T2.T3.TResult..Work(System.Func.T1.T2.T3.TResult.).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](Work.T1.T2.T3.TResult..md#KeepCoding.Work.T1.T2.T3.TResult..T1 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](Work.T1.T2.T3.TResult..md#KeepCoding.Work.T1.T2.T3.TResult..T2 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](Work.T1.T2.T3.TResult..md#KeepCoding.Work.T1.T2.T3.TResult..T3 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](Work.T1.T2.T3.TResult..md#KeepCoding.Work.T1.T2.T3.TResult..TResult 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The method to call when thread starts.
  
