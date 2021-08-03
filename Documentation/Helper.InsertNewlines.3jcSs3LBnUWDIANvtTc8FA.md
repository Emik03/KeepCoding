#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.InsertNewlines(string, ushort) Method
Replaces whitespace characters with line breaks based on the line length.  
```csharp
public static string InsertNewlines(this string condition, ushort maxLineLength);
```
#### Parameters
<a name='KeepCoding.Helper.InsertNewlines(string.ushort).condition'></a>
`condition` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to insert line breaks with.
  
<a name='KeepCoding.Helper.InsertNewlines(string.ushort).maxLineLength'></a>
`maxLineLength` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The maximum number of characters in one line.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[condition](Helper.InsertNewlines.3jcSs3LBnUWDIANvtTc8FA.md#KeepCoding.Helper.InsertNewlines(string.ushort).condition 'KeepCoding.Helper.InsertNewlines(string, ushort).condition') with a line break every [maxLineLength](Helper.InsertNewlines.3jcSs3LBnUWDIANvtTc8FA.md#KeepCoding.Helper.InsertNewlines(string.ushort).maxLineLength 'KeepCoding.Helper.InsertNewlines(string, ushort).maxLineLength') or less characters.
### Remarks
This can be useful to prevent a [UnityEngine.TextMesh](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.TextMesh 'UnityEngine.TextMesh') from going outside its boundaries. A monospaced font is recommended in this case.  
