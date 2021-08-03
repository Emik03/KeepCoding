#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SelectChain&lt;T&gt;(T, Func&lt;T,T&gt;) Method
Enumerates a chain of objects where each object refers to the next one. The chain starts with the specified  
object and ends when null is encountered.
```csharp
public static System.Collections.Generic.IEnumerable<T> SelectChain<T>(this T obj, System.Func<T,T> next)
    where T : class;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_T'></a>
`T`  
Type of object to enumerate.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_obj'></a>
`obj` [T](UtilityExtensions_SelectChain_diw+qsuSL9tFxsq36fOu8A.md#KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_T 'KeepCoding.UtilityExtensions.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
Initial object.
  
<a name='KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_next'></a>
`next` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_SelectChain_diw+qsuSL9tFxsq36fOu8A.md#KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_T 'KeepCoding.UtilityExtensions.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_SelectChain_diw+qsuSL9tFxsq36fOu8A.md#KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_T 'KeepCoding.UtilityExtensions.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A function that returns the next object given the current one. If null is returned, enumeration will end.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SelectChain_diw+qsuSL9tFxsq36fOu8A.md#KeepCoding_UtilityExtensions_SelectChain_T_(T_System_Func_T_T_)_T 'KeepCoding.UtilityExtensions.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  