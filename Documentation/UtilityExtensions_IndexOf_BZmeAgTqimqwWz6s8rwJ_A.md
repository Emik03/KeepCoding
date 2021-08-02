#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;) Method
Returns the index of the first element in this [source](UtilityExtensions_IndexOf_BZmeAgTqimqwWz6s8rwJ_A.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_source 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source') satisfying the specified [predicate](UtilityExtensions_IndexOf_BZmeAgTqimqwWz6s8rwJ_A.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_predicate 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).predicate'). If no such elements are found, returns `-1`.
```csharp
public static int IndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_IndexOf_BZmeAgTqimqwWz6s8rwJ_A.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_IndexOf_BZmeAgTqimqwWz6s8rwJ_A.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
