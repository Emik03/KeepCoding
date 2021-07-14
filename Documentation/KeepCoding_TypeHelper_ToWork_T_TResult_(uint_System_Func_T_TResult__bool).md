#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T,TResult&gt;(uint, Func&lt;T,TResult&gt;, bool) Method
Converts argument to a new [Work&lt;T,TResult&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')
```csharp
public static KeepCoding.Work<T,TResult> ToWork<T,TResult>(this uint maximumThreadsActive, System.Func<T,TResult> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_T'></a>
`T`  
  
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when the thread is active.
  
<a name='KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')[T](KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_T 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).T')[,](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')[TResult](KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool).md#KeepCoding_TypeHelper_ToWork_T_TResult_(uint_System_Func_T_TResult__bool)_TResult 'KeepCoding.TypeHelper.ToWork&lt;T,TResult&gt;(uint, System.Func&lt;T,TResult&gt;, bool).TResult')[&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')  
A new [Work&lt;T,TResult&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;') consisting of the arguments provided.
