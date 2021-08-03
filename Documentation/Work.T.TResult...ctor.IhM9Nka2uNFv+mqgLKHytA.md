#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T,TResult&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')
## Work&lt;T,TResult&gt;.Work(Func&lt;T,TResult&gt;) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Func<T,TResult> work);
```
#### Parameters
<a name='KeepCoding.Work.T.TResult..Work(System.Func.T.TResult.).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Work.T.TResult..md#KeepCoding.Work.T.TResult..T 'KeepCoding.Work&lt;T,TResult&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Work.T.TResult..md#KeepCoding.Work.T.TResult..TResult 'KeepCoding.Work&lt;T,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The method to call when thread starts.
  
