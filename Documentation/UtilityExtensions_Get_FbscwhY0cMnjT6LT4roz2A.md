#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Get&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, TValue) Method
Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is  
returned instead.
```csharp
public static TValue Get<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dict, TKey key, TValue defaultVal);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey'></a>
`TKey`  
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_key'></a>
`key` [TKey](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')  
Key to look up.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_defaultVal'></a>
`defaultVal` [TValue](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
Value to return if [key](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_key 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).key') is not contained in the dictionary.
  
#### Returns
[TValue](UtilityExtensions_Get_FbscwhY0cMnjT6LT4roz2A.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
