#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Stringify&lt;T&gt;(T) Method
Converts [source](KeepCoding_Helper_Stringify_T_(T).md#KeepCoding_Helper_Stringify_T_(T)_source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](KeepCoding_Helper_Stringify_T_(T).md#KeepCoding_Helper_Stringify_T_(T)_source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source').  
```csharp
public static string Stringify<T>(this T source);
```
#### Type parameters
<a name='KeepCoding_Helper_Stringify_T_(T)_T'></a>
`T`  
The format of the string.
  
#### Parameters
<a name='KeepCoding_Helper_Stringify_T_(T)_source'></a>
`source` [T](KeepCoding_Helper_Stringify_T_(T).md#KeepCoding_Helper_Stringify_T_(T)_T 'KeepCoding.Helper.Stringify&lt;T&gt;(T).T')  
The item to represent as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](KeepCoding_Helper_Stringify_T_(T).md#KeepCoding_Helper_Stringify_T_(T)_source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').
### Remarks
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the individual items inside [source](KeepCoding_Helper_Stringify_T_(T).md#KeepCoding_Helper_Stringify_T_(T)_source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') if it is an iterator is deconstructed.  
