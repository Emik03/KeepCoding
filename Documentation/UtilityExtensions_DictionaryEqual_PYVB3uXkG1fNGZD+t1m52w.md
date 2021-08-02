#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.DictionaryEqual&lt;TK,TV&gt;(IDictionary&lt;TK,TV&gt;, IDictionary&lt;TK,TV&gt;) Method
Compares two dictionaries for equality, member-wise. Two dictionaries are equal if they contain all the same  
key-value pairs.
```csharp
public static bool DictionaryEqual<TK,TV>(this System.Collections.Generic.IDictionary<TK,TV> dictA, System.Collections.Generic.IDictionary<TK,TV> dictB)
    where TV : System.IEquatable<TV>;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TK'></a>
`TK`  
  
<a name='KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TV'></a>
`TV`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_dictA'></a>
`dictA` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TK](UtilityExtensions_DictionaryEqual_PYVB3uXkG1fNGZD+t1m52w.md#KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TK 'KeepCoding.UtilityExtensions.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TK')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TV](UtilityExtensions_DictionaryEqual_PYVB3uXkG1fNGZD+t1m52w.md#KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TV 'KeepCoding.UtilityExtensions.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TV')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
  
<a name='KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_dictB'></a>
`dictB` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TK](UtilityExtensions_DictionaryEqual_PYVB3uXkG1fNGZD+t1m52w.md#KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TK 'KeepCoding.UtilityExtensions.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TK')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TV](UtilityExtensions_DictionaryEqual_PYVB3uXkG1fNGZD+t1m52w.md#KeepCoding_UtilityExtensions_DictionaryEqual_TK_TV_(System_Collections_Generic_IDictionary_TK_TV__System_Collections_Generic_IDictionary_TK_TV_)_TV 'KeepCoding.UtilityExtensions.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TV')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
