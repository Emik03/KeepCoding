#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T,TResult&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')
## Work&lt;T,TResult&gt;.Work(Func&lt;T,TResult&gt;, bool, int) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Func<T,TResult> work, bool allowSimultaneousActive, int maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding.Work.T.TResult..Work(System.Func.T.TResult..bool.int).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Work.T.TResult..md#KeepCoding.Work.T.TResult..T 'KeepCoding.Work&lt;T,TResult&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Work.T.TResult..md#KeepCoding.Work.T.TResult..TResult 'KeepCoding.Work&lt;T,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The method to call when thread starts.
  
<a name='KeepCoding.Work.T.TResult..Work(System.Func.T.TResult..bool.int).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding.Work.T.TResult..Work(System.Func.T.TResult..bool.int).maximumThreadsActive'></a>
`maximumThreadsActive` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of threads this class, and all of its overloads can run at once.
  
