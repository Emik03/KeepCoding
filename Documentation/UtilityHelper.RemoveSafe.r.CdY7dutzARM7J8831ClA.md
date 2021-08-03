#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.RemoveSafe&lt;K,V&gt;(IDictionary&lt;K,List&lt;V&gt;&gt;, K, V) Method
Removes the first occurrence of an element from a List<V> stored in the current IDictionary<K,  
List<V>>. If this leaves the list stored at the specified key empty, the key is removed from the  
IDictionary. If the key is not in the dictionary to begin with, nothing happens.
```csharp
public static void RemoveSafe<K,V>(this System.Collections.Generic.IDictionary<K,System.Collections.Generic.List<V>> dic, K key, V value);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K'></a>
`K`  
Type of the key of the IDictionary.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V'></a>
`V`  
Type of the values in the Lists.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K](UtilityHelper.RemoveSafe.r.CdY7dutzARM7J8831ClA.md#KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K 'KeepCoding.UtilityHelper.RemoveSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).K')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[V](UtilityHelper.RemoveSafe.r.CdY7dutzARM7J8831ClA.md#KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V 'KeepCoding.UtilityHelper.RemoveSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
IDictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).key'></a>
`key` [K](UtilityHelper.RemoveSafe.r.CdY7dutzARM7J8831ClA.md#KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K 'KeepCoding.UtilityHelper.RemoveSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).K')  
Key at which the list is located in the IDictionary.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).value'></a>
`value` [V](UtilityHelper.RemoveSafe.r.CdY7dutzARM7J8831ClA.md#KeepCoding.UtilityHelper.RemoveSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V 'KeepCoding.UtilityHelper.RemoveSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).V')  
Value to add to the List located at the specified Key.
  
