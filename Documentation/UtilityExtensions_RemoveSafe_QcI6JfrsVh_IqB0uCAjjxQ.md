#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(IDictionary&lt;K1,Dictionary&lt;K2,V&gt;&gt;, K1, K2) Method
Removes an element from a two-level Dictionary<,>. If this leaves the inner dictionary empty, the key is  
removed from the outer Dictionary.
```csharp
public static bool RemoveSafe<K1,K2,V>(this System.Collections.Generic.IDictionary<K1,System.Collections.Generic.Dictionary<K2,V>> dic, K1 key1, K2 key2);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K1'></a>
`K1`  
Type of the key of the outer Dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K2'></a>
`K2`  
Type of the key of the inner Dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_V'></a>
`V`  
Type of the values in the inner Dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K1](UtilityExtensions_RemoveSafe_QcI6JfrsVh_IqB0uCAjjxQ.md#KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K1 'KeepCoding.UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[K2](UtilityExtensions_RemoveSafe_QcI6JfrsVh_IqB0uCAjjxQ.md#KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K2 'KeepCoding.UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[V](UtilityExtensions_RemoveSafe_QcI6JfrsVh_IqB0uCAjjxQ.md#KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_V 'KeepCoding.UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_key1'></a>
`key1` [K1](UtilityExtensions_RemoveSafe_QcI6JfrsVh_IqB0uCAjjxQ.md#KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K1 'KeepCoding.UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K1')  
Key at which the inner Dictionary is located in the outer Dictionary.
  
<a name='KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_key2'></a>
`key2` [K2](UtilityExtensions_RemoveSafe_QcI6JfrsVh_IqB0uCAjjxQ.md#KeepCoding_UtilityExtensions_RemoveSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2)_K2 'KeepCoding.UtilityExtensions.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K2')  
Key at which the value is located in the inner Dictionary.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A value indicating whether a value was removed or not.