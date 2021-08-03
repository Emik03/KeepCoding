#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.DictionaryEqual&lt;TK,TV&gt;(IDictionary&lt;TK,TV&gt;, IDictionary&lt;TK,TV&gt;) Method
Compares two dictionaries for equality, member-wise. Two dictionaries are equal if they contain all the same  
key-value pairs.
```csharp
public static bool DictionaryEqual<TK,TV>(this System.Collections.Generic.IDictionary<TK,TV> dictA, System.Collections.Generic.IDictionary<TK,TV> dictB)
    where TV : System.IEquatable<TV>;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TK'></a>
`TK`  
  
<a name='KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TV'></a>
`TV`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).dictA'></a>
`dictA` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TK](UtilityHelper.DictionaryEqual.EYjoJcANcw9QRseLxJnG1Q.md#KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TK 'KeepCoding.UtilityHelper.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TK')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TV](UtilityHelper.DictionaryEqual.EYjoJcANcw9QRseLxJnG1Q.md#KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TV 'KeepCoding.UtilityHelper.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TV')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
  
<a name='KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).dictB'></a>
`dictB` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TK](UtilityHelper.DictionaryEqual.EYjoJcANcw9QRseLxJnG1Q.md#KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TK 'KeepCoding.UtilityHelper.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TK')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TV](UtilityHelper.DictionaryEqual.EYjoJcANcw9QRseLxJnG1Q.md#KeepCoding.UtilityHelper.DictionaryEqual.TK.TV.(System.Collections.Generic.IDictionary.TK.TV..System.Collections.Generic.IDictionary.TK.TV.).TV 'KeepCoding.UtilityHelper.DictionaryEqual&lt;TK,TV&gt;(System.Collections.Generic.IDictionary&lt;TK,TV&gt;, System.Collections.Generic.IDictionary&lt;TK,TV&gt;).TV')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
