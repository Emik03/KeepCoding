#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.AddSafe&lt;K1,K2,V&gt;(IDictionary&lt;K1,Dictionary&lt;K2,List&lt;V&gt;&gt;&gt;, K1, K2, V) Method
Adds an element to a List<V> stored in a two-level Dictionary<,>. If the specified key does not  
exist in the current Dictionary, a new List is created.
```csharp
public static void AddSafe<K1,K2,V>(this System.Collections.Generic.IDictionary<K1,System.Collections.Generic.Dictionary<K2,System.Collections.Generic.List<V>>> dic, K1 key1, K2 key2, V value);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K1'></a>
`K1`  
Type of the key of the first-level Dictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K2'></a>
`K2`  
Type of the key of the second-level Dictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).V'></a>
`V`  
Type of the values in the Lists.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K1](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K1 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).K1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[K2](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K2 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).K2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[V](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).V 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).key1'></a>
`key1` [K1](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K1 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).K1')  
Key at which the second-level Dictionary is located in the first-level Dictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).key2'></a>
`key2` [K2](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).K2 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).K2')  
Key at which the list is located in the second-level Dictionary.
  
<a name='KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).value'></a>
`value` [V](UtilityHelper.AddSafe.RJYfU37k0f5qP.Sy0n+RkQ.md#KeepCoding.UtilityHelper.AddSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.System.Collections.Generic.List.V....K1.K2.V).V 'KeepCoding.UtilityHelper.AddSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,System.Collections.Generic.List&lt;V&gt;&gt;&gt;, K1, K2, V).V')  
Value to add to the List located at the specified Keys.
  
