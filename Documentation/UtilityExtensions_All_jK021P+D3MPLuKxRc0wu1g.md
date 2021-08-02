#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.All&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,int,bool&gt;) Method
Determines whether all elements of a sequence satisfy a condition by incorporating the element's index.
```csharp
public static bool All<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,int,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_T'></a>
`T`  
The type of the elements of [source](UtilityExtensions_All_jK021P+D3MPLuKxRc0wu1g.md#KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_source 'KeepCoding.UtilityExtensions.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).source').
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_All_jK021P+D3MPLuKxRc0wu1g.md#KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_T 'KeepCoding.UtilityExtensions.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') that contains the elements to apply the predicate to.
  
<a name='KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityExtensions_All_jK021P+D3MPLuKxRc0wu1g.md#KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_T 'KeepCoding.UtilityExtensions.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
A function to test each element for a condition; the second parameter of the function represents the index of  
the source element.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if every element of the source sequence passes the test in the specified [predicate](UtilityExtensions_All_jK021P+D3MPLuKxRc0wu1g.md#KeepCoding_UtilityExtensions_All_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_bool_)_predicate 'KeepCoding.UtilityExtensions.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).predicate'), or if the sequence is empty; otherwise, false.
