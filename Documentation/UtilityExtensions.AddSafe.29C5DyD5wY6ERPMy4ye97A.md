#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.AddSafe&lt;K,V&gt;(IDictionary&lt;K,List&lt;V&gt;&gt;, K, V) Method
Adds an element to a List<V> stored in the current IDictionary<K, List<V>>. If the specified  
key does not exist in the current IDictionary, a new List is created.
```csharp
public static void AddSafe<K,V>(this System.Collections.Generic.IDictionary<K,System.Collections.Generic.List<V>> dic, K key, V value);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K'></a>
`K`  
Type of the key of the IDictionary.
  
<a name='KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V'></a>
`V`  
Type of the values in the Lists.
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K](UtilityExtensions.AddSafe.29C5DyD5wY6ERPMy4ye97A.md#KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K 'KeepCoding.UtilityExtensions.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).K')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[V](UtilityExtensions.AddSafe.29C5DyD5wY6ERPMy4ye97A.md#KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V 'KeepCoding.UtilityExtensions.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
IDictionary to operate on.
  
<a name='KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).key'></a>
`key` [K](UtilityExtensions.AddSafe.29C5DyD5wY6ERPMy4ye97A.md#KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).K 'KeepCoding.UtilityExtensions.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).K')  
Key at which the list is located in the IDictionary.
  
<a name='KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).value'></a>
`value` [V](UtilityExtensions.AddSafe.29C5DyD5wY6ERPMy4ye97A.md#KeepCoding.UtilityExtensions.AddSafe.K.V.(System.Collections.Generic.IDictionary.K.System.Collections.Generic.List.V...K.V).V 'KeepCoding.UtilityExtensions.AddSafe&lt;K,V&gt;(System.Collections.Generic.IDictionary&lt;K,System.Collections.Generic.List&lt;V&gt;&gt;, K, V).V')  
Value to add to the List located at the specified Key.
  
