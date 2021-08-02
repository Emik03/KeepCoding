#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveAllByValue&lt;TKey,TVal&gt;(IDictionary&lt;TKey,TVal&gt;, Func&lt;TVal,bool&gt;) Method
Removes all entries from a dictionary whose values satisfy a specified predicate.
```csharp
public static void RemoveAllByValue<TKey,TVal>(this System.Collections.Generic.IDictionary<TKey,TVal> dict, System.Func<TVal,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_TKey'></a>
`TKey`  
Type of the keys in the dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_TVal'></a>
`TVal`  
Type of the values in the dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions_RemoveAllByValue_tH5dgyxLZERsD_hu71_3Mw.md#KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_TKey 'KeepCoding.UtilityExtensions.RemoveAllByValue&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TVal,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TVal](UtilityExtensions_RemoveAllByValue_tH5dgyxLZERsD_hu71_3Mw.md#KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_TVal 'KeepCoding.UtilityExtensions.RemoveAllByValue&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TVal,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TVal](UtilityExtensions_RemoveAllByValue_tH5dgyxLZERsD_hu71_3Mw.md#KeepCoding_UtilityExtensions_RemoveAllByValue_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_TVal_bool_)_TVal 'KeepCoding.UtilityExtensions.RemoveAllByValue&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;TVal,bool&gt;).TVal')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Specifies a predicate that determines which entries should be removed from the dictionary.
  
