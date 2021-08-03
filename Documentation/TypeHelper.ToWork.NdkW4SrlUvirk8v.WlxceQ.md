#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T,TResult&gt;(uint, Func&lt;T,TResult&gt;, bool) Method
Converts argument to a new [Work&lt;T,TResult&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')
```csharp
public static KeepCoding.Work<T,TResult> ToWork<T,TResult>(this uint maximumThreadsActive, System.Func<T,TResult> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).T'></a>
`T`  
  
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TypeHelper.ToWork.NdkW4SrlUvirk8v.WlxceQ.md#KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TypeHelper.ToWork.NdkW4SrlUvirk8v.WlxceQ.md#KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when the thread is active.
  
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')[T](TypeHelper.ToWork.NdkW4SrlUvirk8v.WlxceQ.md#KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).T')[,](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')[TResult](TypeHelper.ToWork.NdkW4SrlUvirk8v.WlxceQ.md#KeepCoding.TypeHelper.ToWork.T.TResult.(uint.System.Func.T.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).TResult')[&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')  
A new [Work&lt;T,TResult&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;') consisting of the arguments provided.
