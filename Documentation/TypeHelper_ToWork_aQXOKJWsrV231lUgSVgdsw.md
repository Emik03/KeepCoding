#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T&gt;(uint, Func&lt;T&gt;, bool) Method
Converts argument to a new [Work&lt;T&gt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;')
```csharp
public static KeepCoding.Work<T> ToWork<T>(this uint maximumThreadsActive, System.Func<T> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](TypeHelper_ToWork_aQXOKJWsrV231lUgSVgdsw.md#KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(uint, System.Func&lt;T&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when the thread is active.
  
<a name='KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;')[T](TypeHelper_ToWork_aQXOKJWsrV231lUgSVgdsw.md#KeepCoding_TypeHelper_ToWork_T_(uint_System_Func_T__bool)_T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(uint, System.Func&lt;T&gt;, bool).T')[&gt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;')  
A new [Work&lt;T&gt;](Work_T_.md 'KeepCoding.Work&lt;T&gt;') consisting of the arguments provided.
