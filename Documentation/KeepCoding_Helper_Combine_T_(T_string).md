#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Combine&lt;T&gt;(T, string) Method
Conbines the iterator into one long [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
```csharp
public static string Combine<T>(this T source, string delimiter=", ");
```
#### Type parameters
<a name='KeepCoding_Helper_Combine_T_(T_string)_T'></a>
`T`  
The type of the [source](KeepCoding_Helper_Combine_T_(T_string).md#KeepCoding_Helper_Combine_T_(T_string)_source 'KeepCoding.Helper.Combine&lt;T&gt;(T, string).source').
  
#### Parameters
<a name='KeepCoding_Helper_Combine_T_(T_string)_source'></a>
`source` [T](KeepCoding_Helper_Combine_T_(T_string).md#KeepCoding_Helper_Combine_T_(T_string)_T 'KeepCoding.Helper.Combine&lt;T&gt;(T, string).T')  
The iterator.
  
<a name='KeepCoding_Helper_Combine_T_(T_string)_delimiter'></a>
`delimiter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The separator between each element.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representing all elements in [source](KeepCoding_Helper_Combine_T_(T_string).md#KeepCoding_Helper_Combine_T_(T_string)_source 'KeepCoding.Helper.Combine&lt;T&gt;(T, string).source') with the separator [delimiter](KeepCoding_Helper_Combine_T_(T_string).md#KeepCoding_Helper_Combine_T_(T_string)_delimiter 'KeepCoding.Helper.Combine&lt;T&gt;(T, string).delimiter').
