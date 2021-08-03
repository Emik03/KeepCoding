#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(IDictionary&lt;K1,Dictionary&lt;K2,V&gt;&gt;, K1, K2) Method
Removes an element from a two-level Dictionary<,>. If this leaves the inner dictionary empty, the key is  
removed from the outer Dictionary.
```csharp
public static bool RemoveSafe<K1,K2,V>(this System.Collections.Generic.IDictionary<K1,System.Collections.Generic.Dictionary<K2,V>> dic, K1 key1, K2 key2);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K1'></a>
`K1`  
Type of the key of the outer Dictionary.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K2'></a>
`K2`  
Type of the key of the inner Dictionary.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).V'></a>
`V`  
Type of the values in the inner Dictionary.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).dic'></a>
`dic` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[K1](UtilityHelper.RemoveSafe.IGQgrV9qGCvMdVwxfSqZPQ.md#KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K1 'KeepCoding.UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[K2](UtilityHelper.RemoveSafe.IGQgrV9qGCvMdVwxfSqZPQ.md#KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K2 'KeepCoding.UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[V](UtilityHelper.RemoveSafe.IGQgrV9qGCvMdVwxfSqZPQ.md#KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).V 'KeepCoding.UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).V')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).key1'></a>
`key1` [K1](UtilityHelper.RemoveSafe.IGQgrV9qGCvMdVwxfSqZPQ.md#KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K1 'KeepCoding.UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K1')  
Key at which the inner Dictionary is located in the outer Dictionary.
  
<a name='KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).key2'></a>
`key2` [K2](UtilityHelper.RemoveSafe.IGQgrV9qGCvMdVwxfSqZPQ.md#KeepCoding.UtilityHelper.RemoveSafe.K1.K2.V.(System.Collections.Generic.IDictionary.K1.System.Collections.Generic.Dictionary.K2.V...K1.K2).K2 'KeepCoding.UtilityHelper.RemoveSafe&lt;K1,K2,V&gt;(System.Collections.Generic.IDictionary&lt;K1,System.Collections.Generic.Dictionary&lt;K2,V&gt;&gt;, K1, K2).K2')  
Key at which the value is located in the inner Dictionary.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A value indicating whether a value was removed or not.
