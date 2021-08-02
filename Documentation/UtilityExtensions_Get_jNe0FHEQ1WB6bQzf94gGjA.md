#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(IDictionary&lt;TKey1,Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue) Method
Gets a value from a two-level dictionary by key. If the keys don’t exist in the dictionary, the default value  
is returned instead.
```csharp
public static TValue Get<TKey1,TKey2,TValue>(this System.Collections.Generic.IDictionary<TKey1,System.Collections.Generic.Dictionary<TKey2,TValue>> dict, TKey1 key1, TKey2 key2, TValue defaultVal);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey1'></a>
`TKey1`  
  
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey2'></a>
`TKey2`  
  
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey1](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey1 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TKey2](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey2 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TValue](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_key1'></a>
`key1` [TKey1](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey1 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey1')  
Key to look up in the first level.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_key2'></a>
`key2` [TKey2](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TKey2 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TKey2')  
Key to look up in the second level.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_defaultVal'></a>
`defaultVal` [TValue](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TValue')  
Value to return if key1 or key2 is not contained in the relevant dictionary.
  
#### Returns
[TValue](UtilityExtensions_Get_jNe0FHEQ1WB6bQzf94gGjA.md#KeepCoding_UtilityExtensions_Get_TKey1_TKey2_TValue_(System_Collections_Generic_IDictionary_TKey1_System_Collections_Generic_Dictionary_TKey2_TValue___TKey1_TKey2_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey1,TKey2,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey1,System.Collections.Generic.Dictionary&lt;TKey2,TValue&gt;&gt;, TKey1, TKey2, TValue).TValue')  
