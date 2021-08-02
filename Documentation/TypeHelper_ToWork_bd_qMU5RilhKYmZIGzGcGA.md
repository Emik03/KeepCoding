#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T&gt;(Func&lt;T&gt;) Method
Converts argument to a new [Work](Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work<T> ToWork<T>(this System.Func<T> func);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T_(System_Func_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T_(System_Func_T_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](TypeHelper_ToWork_bd_qMU5RilhKYmZIGzGcGA.md#KeepCoding_TypeHelper_ToWork_T_(System_Func_T_)_T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when the thread is active.
  
#### Returns
[KeepCoding.Work&lt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;')[T](TypeHelper_ToWork_bd_qMU5RilhKYmZIGzGcGA.md#KeepCoding_TypeHelper_ToWork_T_(System_Func_T_)_T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;')  
A new [Work](Work.md 'KeepCoding.Work') consisting of the arguments provided.
