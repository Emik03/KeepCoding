#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;, int) Method
Returns the index of the first element in this [source](UtilityExtensions_IndexOf_DjfYlLJZXonuaqun51+7RA.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_source 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, int).source') satisfying the specified [predicate](UtilityExtensions_IndexOf_DjfYlLJZXonuaqun51+7RA.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_predicate 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, int).predicate'), starting at the specified [startIndex](UtilityExtensions_IndexOf_DjfYlLJZXonuaqun51+7RA.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_startIndex 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, int).startIndex'). If no such elements are found,  
returns `-1`.
```csharp
public static int IndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate, int startIndex);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_IndexOf_DjfYlLJZXonuaqun51+7RA.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_IndexOf_DjfYlLJZXonuaqun51+7RA.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, int).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
