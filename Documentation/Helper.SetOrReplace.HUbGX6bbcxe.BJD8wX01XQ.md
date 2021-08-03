#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.SetOrReplace&lt;T&gt;(IDictionary&lt;T,int&gt;, T, Func&lt;int,int&gt;) Method
Sets or replaces the value of a dictionary with a given function.  
```csharp
public static int SetOrReplace<T>(this System.Collections.Generic.IDictionary<T,int> source, T key, System.Func<int,int> func);
```
#### Type parameters
<a name='KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).T'></a>
`T`  
Type of the key of the dictionary.
  
#### Parameters
<a name='KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[T](Helper.SetOrReplace.HUbGX6bbcxe.BJD8wX01XQ.md#KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).T 'KeepCoding.Helper.SetOrReplace&lt;T&gt;(System.Collections.Generic.IDictionary&lt;T,int&gt;, T, System.Func&lt;int,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).key'></a>
`key` [T](Helper.SetOrReplace.HUbGX6bbcxe.BJD8wX01XQ.md#KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).T 'KeepCoding.Helper.SetOrReplace&lt;T&gt;(System.Collections.Generic.IDictionary&lt;T,int&gt;, T, System.Func&lt;int,int&gt;).T')  
Key at which the list is located in the dictionary.
  
<a name='KeepCoding.Helper.SetOrReplace.T.(System.Collections.Generic.IDictionary.T.int..T.System.Func.int.int.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function that returns the new value.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The new value at the specified key.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
