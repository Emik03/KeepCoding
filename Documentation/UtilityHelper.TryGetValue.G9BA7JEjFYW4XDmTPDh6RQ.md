#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(IDictionary&lt;TKey1,Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue) Method
Gets the value associated with the specified combination of keys.
```csharp
public static bool TryGetValue<TKey1,TKey2,TValue>(this System.Collections.Generic.IDictionary<TKey1,System.Collections.Generic.Dictionary<TKey2,TValue>> source, TKey1 key1, TKey2 key2, out TValue value);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey1'></a>
`TKey1`  
Type of the first-level key.
  
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey2'></a>
`TKey2`  
Type of the second-level key.
  
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TValue'></a>
`TValue`  
Type of values in the dictionary.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey1](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey1 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TKey2](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey2 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TValue](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TValue 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Source dictionary to examine.
  
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).key1'></a>
`key1` [TKey1](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey1 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey1')  
The first key to check for.
  
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).key2'></a>
`key2` [TKey2](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TKey2 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey2')  
The second key to check for.
  
<a name='KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).value'></a>
`value` [TValue](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).TValue 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TValue')  
When this method returns, the value associated with the specified keys, if the keys are found; otherwise, the  
default value for the type of the [value](UtilityHelper.TryGetValue.G9BA7JEjFYW4XDmTPDh6RQ.md#KeepCoding.UtilityHelper.TryGetValue.TKey1.TKey2.TValue.(System.Collections.Generic.IDictionary.TKey1.System.Collections.Generic.Dictionary.TKey2.TValue...TKey1.TKey2.TValue).value 'KeepCoding.UtilityHelper.TryGetValue&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).value') parameter. This parameter is passed uninitialized.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the two-level dictionary contains an element with the specified combination of keys; otherwise,  
                `false`.
