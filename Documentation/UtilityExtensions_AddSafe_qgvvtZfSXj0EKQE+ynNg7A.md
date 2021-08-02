#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(IDictionary&lt;K1,Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, IEqualityComparer&lt;K2&gt;) Method
Adds an element to a two-level Dictionary<,>. If the specified key does not exist in the outer  
Dictionary, a new Dictionary is created.
```csharp
public static void AddSafe<K1,K2,V>(this System.Collections.Generic.IDictionary<K1,System.Collections.Generic.Dictionary<K2,V>> dic, K1 key1, K2 key2, V value, System.Collections.Generic.IEqualityComparer<K2> comparer=null);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K1'></a>
`K1`  
Type of the key of the outer Dictionary.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K2'></a>
`K2`  
Type of the key of the inner Dictionary.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_V'></a>
`V`  
Type of the values in the inner Dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K1](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K1 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).K1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[K2](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K2 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).K2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[V](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_V 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_key1'></a>
`key1` [K1](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K1 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).K1')  
Key at which the inner Dictionary is located in the outer Dictionary.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_key2'></a>
`key2` [K2](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K2 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).K2')  
Key at which the value is located in the inner Dictionary.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_value'></a>
`value` [V](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_V 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).V')  
Value to add to the inner Dictionary.
  
<a name='KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[K2](UtilityExtensions_AddSafe_qgvvtZfSXj0EKQE+ynNg7A.md#KeepCoding_UtilityExtensions_AddSafe_K1_K2_V_(System_Collections_Generic_IDictionary_K1_System_Collections_Generic_Dictionary_K2_V___K1_K2_V_System_Collections_Generic_IEqualityComparer_K2_)_K2 'KeepCoding.UtilityExtensions.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2, V, System.Collections.Generic.IEqualityComparer&lt;K2&gt;).K2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer to pass into the inner dictionary if a new one is created.
  
