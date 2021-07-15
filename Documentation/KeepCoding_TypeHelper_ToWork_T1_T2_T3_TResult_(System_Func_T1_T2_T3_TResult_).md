#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(Func&lt;T1,T2,T3,TResult&gt;) Method
Converts argument to a new [Work](KeepCoding_Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work<T1,T2,T3,TResult> ToWork<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult> func);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T1'></a>
`T1`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T2'></a>
`T2`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T3'></a>
`T3`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The action to run when the thread is active.
  
#### Returns
[KeepCoding.Work&lt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T1](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T1')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T2](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T2')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T3](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).T3')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[TResult](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(System_Func_T1_T2_T3_TResult_)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(System.Func&lt;T1,T2,T3,TResult&gt;).TResult')[&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')  
A new [Work](KeepCoding_Work.md 'KeepCoding.Work') consisting of the arguments provided.
