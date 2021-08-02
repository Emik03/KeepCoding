#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Get&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Nullable&lt;TValue&gt;) Method
Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is  
returned instead.
```csharp
public static System.Nullable<TValue> Get<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dict, TKey key, System.Nullable<TValue> defaultVal=null)
    where TValue : struct;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TKey'></a>
`TKey`  
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_key'></a>
`key` [TKey](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')  
Key to look up.
  
<a name='KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_defaultVal'></a>
`defaultVal` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
Value to return if [key](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_key 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).key') is not contained in the dictionary.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityExtensions_Get_ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding_UtilityExtensions_Get_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Nullable_TValue_)_TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
