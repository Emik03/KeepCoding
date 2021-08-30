#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T&gt;(int, Func&lt;T&gt;, bool) Method
Converts argument to a new [Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')
```csharp
public static KeepCoding.Work<T> ToWork<T>(this int maximumThreadsActive, System.Func<T> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).maximumThreadsActive'></a>
`maximumThreadsActive` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](TypeHelper.ToWork.y8B3sAJMw2jTDZoyxJ3JBg.md#KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(int, System.Func&lt;T&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when the thread is active.
  
<a name='KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')[T](TypeHelper.ToWork.y8B3sAJMw2jTDZoyxJ3JBg.md#KeepCoding.TypeHelper.ToWork.T.(int.System.Func.T..bool).T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(int, System.Func&lt;T&gt;, bool).T')[&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')  
A new [Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;') consisting of the arguments provided.
