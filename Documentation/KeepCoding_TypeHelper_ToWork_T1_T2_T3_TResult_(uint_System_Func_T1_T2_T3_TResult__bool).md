### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, Func&lt;T1,T2,T3,TResult&gt;, bool) Method
Converts argument to a new [Work&lt;T1,T2,T3,TResult&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')
```csharp
public static KeepCoding.Work<T1,T2,T3,TResult> ToWork<T1,T2,T3,TResult>(this uint maximumThreadsActive, System.Func<T1,T2,T3,TResult> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T1'></a>
`T1`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T2'></a>
`T2`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T3'></a>
`T3`  
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The action to run when the thread is active.
  
<a name='KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T1](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T1')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T2](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T2')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[T3](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).T3')[,](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')[TResult](KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T1_T2_T3_TResult_(uint_System_Func_T1_T2_T3_TResult__bool)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,TResult&gt;(uint, System.Func&lt;T1,T2,T3,TResult&gt;, bool).TResult')[&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')  
A new [Work&lt;T1,T2,T3,TResult&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;') consisting of the arguments provided.
