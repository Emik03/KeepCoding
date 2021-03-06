#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')
## Work&lt;T&gt;.Work(Func&lt;T&gt;) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Func<T> work);
```
#### Parameters
<a name='KeepCoding.Work.T..Work(System.Func.T.).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](Work.T..md#KeepCoding.Work.T..T 'KeepCoding.Work&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The method to call when thread starts.
  
