#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.InsertNewlines(string, ushort) Method
Replaces whitespace characters with line breaks based on the line length.  
```csharp
public static string InsertNewlines(this string condition, ushort maxLineLength);
```
#### Parameters
<a name='KeepCoding_Helper_InsertNewlines(string_ushort)_condition'></a>
`condition` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to insert line breaks with.
  
<a name='KeepCoding_Helper_InsertNewlines(string_ushort)_maxLineLength'></a>
`maxLineLength` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The maximum number of characters in one line.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[condition](KeepCoding_Helper_InsertNewlines(string_ushort).md#KeepCoding_Helper_InsertNewlines(string_ushort)_condition 'KeepCoding.Helper.InsertNewlines(string, ushort).condition') with a line break every [maxLineLength](KeepCoding_Helper_InsertNewlines(string_ushort).md#KeepCoding_Helper_InsertNewlines(string_ushort)_maxLineLength 'KeepCoding.Helper.InsertNewlines(string, ushort).maxLineLength') or less characters.
### Remarks
This can be useful to prevent a [UnityEngine.TextMesh](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.TextMesh 'UnityEngine.TextMesh') from going outside its boundaries. A monospaced font is recommended in this case.  
