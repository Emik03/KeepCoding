#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveAllByKey&lt;TKey,TVal&gt;(IDictionary&lt;TKey,TVal&gt;, Func&lt;TKey,bool&gt;) Method
Removes all entries from a dictionary whose keys satisfy a specified predicate.
```csharp
public static void RemoveAllByKey<TKey,TVal>(this System.Collections.Generic.IDictionary<TKey,TVal> dict, System.Func<TKey,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_TKey'></a>
`TKey`  
Type of the keys in the dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_TVal'></a>
`TVal`  
Type of the values in the dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions_RemoveAllByKey_DKkTataxWZviL8_NeWUo1w.md#KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_TKey 'KeepCoding.UtilityExtensions.RemoveAllByKey&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TKey,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TVal](UtilityExtensions_RemoveAllByKey_DKkTataxWZviL8_NeWUo1w.md#KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_TVal 'KeepCoding.UtilityExtensions.RemoveAllByKey&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TKey,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](UtilityExtensions_RemoveAllByKey_DKkTataxWZviL8_NeWUo1w.md#KeepCoding_UtilityExtensions_RemoveAllByKey_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TKey_bool_)_TKey 'KeepCoding.UtilityExtensions.RemoveAllByKey&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TKey,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Specifies a predicate that determines which entries should be removed from the dictionary.
  
