#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T,TResult&gt;(Func&lt;T,TResult&gt;) Method
Converts argument to a new [Work](Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work<T,TResult> ToWork<T,TResult>(this System.Func<T,TResult> func);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).T'></a>
`T`  
  
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TypeHelper.ToWork.N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TypeHelper.ToWork.N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when the thread is active.
  
#### Returns
[KeepCoding.Work&lt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')[T](TypeHelper.ToWork.N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).T')[,](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')[TResult](TypeHelper.ToWork.N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding.TypeHelper.ToWork.T.TResult.(System.Func.T.TResult.).TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).TResult')[&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')  
A new [Work](Work.md 'KeepCoding.Work') consisting of the arguments provided.
