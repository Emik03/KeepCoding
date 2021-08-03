#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(IDictionary&lt;TKey,TVal&gt;, Func&lt;KeyValuePair&lt;TKey,TVal&gt;,bool&gt;) Method
Removes all entries from a dictionary that satisfy a specified predicate.
```csharp
public static void RemoveAll<TKey,TVal>(this System.Collections.Generic.IDictionary<TKey,TVal> dict, System.Func<System.Collections.Generic.KeyValuePair<TKey,TVal>,bool> predicate);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TKey'></a>
`TKey`  
Type of the keys in the dictionary.
  
<a name='KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TVal'></a>
`TVal`  
Type of the values in the dictionary.
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions.RemoveAll.YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TKey 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TVal](UtilityExtensions.RemoveAll.YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TVal 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](UtilityExtensions.RemoveAll.YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TKey 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TVal](UtilityExtensions.RemoveAll.YUOD5I+jkzJ4GMEifw1sXA.md#KeepCoding.UtilityExtensions.RemoveAll.TKey.TVal.(System.Collections.Generic.IDictionary.TKey.TVal..System.Func.System.Collections.Generic.KeyValuePair.TKey.TVal..bool.).TVal 'KeepCoding.UtilityExtensions.RemoveAll&lt;TKey,TVal&gt;(System.Collections.Generic.IDictionary&lt;TKey,TVal&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TVal&gt;,bool&gt;).TVal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Specifies a predicate that determines which entries should be removed from the dictionary.
  
