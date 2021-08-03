#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.AddSafe&lt;K,V&gt;(IDictionary&lt;K,HashSet&lt;V&gt;&gt;, K, V) Method
Adds an element to a HashSet<V> stored in the current IDictionary<K, HashSet<V>>. If the  
specified key does not exist in the current IDictionary, a new HashSet is created.
```csharp
public static bool AddSafe<K,V>(this System.Collections.Generic.IDictionary<K,System.Collections.Generic.HashSet<V>> dic, K key, V value);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).K'></a>
`K`  
Type of the key of the IDictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).V'></a>
`V`  
Type of the values in the HashSets.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K](UtilityHelper.AddSafe.rbcT0Fm0SKsJqezDPByFNg.md#KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).K 'KeepCoding.UtilityHelper.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.HashSet&lt;V&gt;&gt;, K, V).K')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[V](UtilityHelper.AddSafe.rbcT0Fm0SKsJqezDPByFNg.md#KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).V 'KeepCoding.UtilityHelper.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.HashSet&lt;V&gt;&gt;, K, V).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
IDictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).key'></a>
`key` [K](UtilityHelper.AddSafe.rbcT0Fm0SKsJqezDPByFNg.md#KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).K 'KeepCoding.UtilityHelper.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.HashSet&lt;V&gt;&gt;, K, V).K')  
Key at which the HashSet is located in the IDictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).value'></a>
`value` [V](UtilityHelper.AddSafe.rbcT0Fm0SKsJqezDPByFNg.md#KeepCoding.UtilityHelper.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.HashSet.V...K.V).V 'KeepCoding.UtilityHelper.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.HashSet&lt;V&gt;&gt;, K, V).V')  
Value to add to the HashSet located at the specified Key.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
