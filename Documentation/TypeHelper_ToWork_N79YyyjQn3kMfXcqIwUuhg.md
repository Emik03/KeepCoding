#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T,TResult&gt;(Func&lt;T,TResult&gt;) Method
Converts argument to a new [Work](Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work<T,TResult> ToWork<T,TResult>(this System.Func<T,TResult> func);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_T'></a>
`T`  
  
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TypeHelper_ToWork_N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TypeHelper_ToWork_N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when the thread is active.
  
#### Returns
[KeepCoding.Work&lt;](Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')[T](TypeHelper_ToWork_N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).T')[,](Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')[TResult](TypeHelper_ToWork_N79YyyjQn3kMfXcqIwUuhg.md#KeepCoding_TypeHelper_ToWork_T_TResult_(System_Func_T_TResult_)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;).TResult')[&gt;](Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')  
A new [Work](Work.md 'KeepCoding.Work') consisting of the arguments provided.
