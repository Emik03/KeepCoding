#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.LastIndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;) Method
Returns the index of the last element in this [source](UtilityExtensions_LastIndexOf_mLulB5y7UPEmjJj5P+e8Aw.md#KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_source 'KeepCoding.UtilityExtensions.LastIndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source') satisfying the specified [predicate](UtilityExtensions_LastIndexOf_mLulB5y7UPEmjJj5P+e8Aw.md#KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_predicate 'KeepCoding.UtilityExtensions.LastIndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).predicate'). If no such elements are found, returns `-1`.
```csharp
public static int LastIndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_LastIndexOf_mLulB5y7UPEmjJj5P+e8Aw.md#KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T 'KeepCoding.UtilityExtensions.LastIndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_LastIndexOf_mLulB5y7UPEmjJj5P+e8Aw.md#KeepCoding_UtilityExtensions_LastIndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool_)_T 'KeepCoding.UtilityExtensions.LastIndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
### Remarks
This method is optimised for the case in which the input sequence is a list or array. In all other cases, the  
collection is evaluated completely before this method returns.
