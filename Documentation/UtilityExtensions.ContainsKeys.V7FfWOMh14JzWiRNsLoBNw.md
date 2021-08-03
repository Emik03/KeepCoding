#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(IDictionary&lt;TKey1,Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2) Method
Determines whether the current two-level dictionary contains the specified combination of keys.
```csharp
public static bool ContainsKeys<TKey1,TKey2,TValue>(this System.Collections.Generic.IDictionary<TKey1,System.Collections.Generic.Dictionary<TKey2,TValue>> source, TKey1 key1, TKey2 key2);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey1'></a>
`TKey1`  
Type of the first-level key.
  
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey2'></a>
`TKey2`  
Type of the second-level key.
  
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TValue'></a>
`TValue`  
Type of values in the dictionary.
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey1](UtilityExtensions.ContainsKeys.V7FfWOMh14JzWiRNsLoBNw.md#KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey1 'KeepCoding.UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2).TKey1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TKey2](UtilityExtensions.ContainsKeys.V7FfWOMh14JzWiRNsLoBNw.md#KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey2 'KeepCoding.UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2).TKey2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TValue](UtilityExtensions.ContainsKeys.V7FfWOMh14JzWiRNsLoBNw.md#KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TValue 'KeepCoding.UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Source dictionary to examine.
  
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).key1'></a>
`key1` [TKey1](UtilityExtensions.ContainsKeys.V7FfWOMh14JzWiRNsLoBNw.md#KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey1 'KeepCoding.UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2).TKey1')  
The first key to check for.
  
<a name='KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).key2'></a>
`key2` [TKey2](UtilityExtensions.ContainsKeys.V7FfWOMh14JzWiRNsLoBNw.md#KeepCoding.UtilityExtensions.ContainsKeys.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2).TKey2 'KeepCoding.UtilityExtensions.ContainsKeys&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2).TKey2')  
The second key to check for.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
