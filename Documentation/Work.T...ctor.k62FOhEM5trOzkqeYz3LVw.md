#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')
## Work&lt;T&gt;.Work(Func&lt;T&gt;, bool, int) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Func<T> work, bool allowSimultaneousActive, int maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding.Work.T..Work(System.Func.T..bool.int).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](Work.T..md#KeepCoding.Work.T..T 'KeepCoding.Work&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The method to call when thread starts.
  
<a name='KeepCoding.Work.T..Work(System.Func.T..bool.int).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding.Work.T..Work(System.Func.T..bool.int).maximumThreadsActive'></a>
`maximumThreadsActive` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of threads this class, and all of its overloads can run at once.
  
