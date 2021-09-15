#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.SetOrReplace&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Func&lt;TValue,TValue&gt;) Method
Sets or replaces the value of a dictionary with a given function.  
```csharp
public static TValue SetOrReplace<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, System.Func<TValue,TValue> func);
```
#### Type parameters
<a name='KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TKey'></a>
`TKey`  
Type of the key of the dictionary.
  
<a name='KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TValue'></a>
`TValue`  
Type of the value of the dictionary.
  
#### Parameters
<a name='KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TKey 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TValue 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).key'></a>
`key` [TKey](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TKey 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TKey')  
Key at which the list is located in the dictionary.
  
<a name='KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TValue 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TValue 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function that returns the new value.
  
#### Returns
[TValue](Helper.SetOrReplace.6MmTmOnHYM8TCBdvEnotIw.md#KeepCoding.Helper.SetOrReplace.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Func.TValue.TValue.).TValue 'KeepCoding.Helper.SetOrReplace&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue,TValue&gt;).TValue')  
The new value at the specified key.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
