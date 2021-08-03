#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IncSafe&lt;K&gt;(IDictionary&lt;K,int&gt;, K, int) Method
Increments an integer in an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') by the specified amount. If the specified  
key does not exist in the current dictionary, the value [amount](UtilityExtensions_IncSafe_jdsrR0l0I27lWUuisk_j_Q.md#KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_amount 'KeepCoding.UtilityExtensions.IncSafe&lt;K&gt;(System.Collections.Generic.IDictionary&lt;K,int&gt;, K, int).amount') is inserted.
```csharp
public static int IncSafe<K>(this System.Collections.Generic.IDictionary<K,int> dic, K key, int amount=1);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_K'></a>
`K`  
Type of the key of the dictionary.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K](UtilityExtensions_IncSafe_jdsrR0l0I27lWUuisk_j_Q.md#KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_K 'KeepCoding.UtilityExtensions.IncSafe&lt;K&gt;(System.Collections.Generic.IDictionary&lt;K,int&gt;, K, int).K')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_key'></a>
`key` [K](UtilityExtensions_IncSafe_jdsrR0l0I27lWUuisk_j_Q.md#KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_K 'KeepCoding.UtilityExtensions.IncSafe&lt;K&gt;(System.Collections.Generic.IDictionary&lt;K,int&gt;, K, int).K')  
Key at which the list is located in the dictionary.
  
<a name='KeepCoding_UtilityExtensions_IncSafe_K_(System_Collections_Generic_IDictionary_K_int__K_int)_amount'></a>
`amount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount by which to increment the integer.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The new value at the specified key.