#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(IDictionary&lt;TKey,TVal&gt;, Func&lt;KeyValuePair&lt;TKey,TVal&gt;,bool&gt;) Method
Removes all entries from a dictionary that satisfy a specified predicate.
```csharp
public static void RemoveAll<TKey,TVal>(this System.Collections.Generic.IDictionary<TKey,TVal> dict, System.Func<System.Collections.Generic.KeyValuePair<TKey,TVal>,bool> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TKey'></a>
`TKey`  
Type of the keys in the dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TVal'></a>
`TVal`  
Type of the values in the dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions_RemoveAll_YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TKey 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TVal](UtilityExtensions_RemoveAll_YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TVal 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](UtilityExtensions_RemoveAll_YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TKey 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TVal](UtilityExtensions_RemoveAll_YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding_UtilityExtensions_RemoveAll_TKey_TVal_(System_Collections_Generic_IDictionary_TKey_TVal__System_Func_System_Collections_Generic_KeyValuePair_TKey_TVal__bool_)_TVal 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Specifies a predicate that determines which entries should be removed from the dictionary.
  
