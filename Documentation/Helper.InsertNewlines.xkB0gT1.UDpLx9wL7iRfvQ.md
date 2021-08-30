#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.InsertNewlines(string, int) Method
Replaces whitespace characters with line breaks based on the line length.  
```csharp
public static string InsertNewlines(this string condition, int maxLineLength);
```
#### Parameters
<a name='KeepCoding.Helper.InsertNewlines(string.int).condition'></a>
`condition` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to insert line breaks with.
  
<a name='KeepCoding.Helper.InsertNewlines(string.int).maxLineLength'></a>
`maxLineLength` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The maximum number of characters in one line.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[condition](Helper.InsertNewlines.xkB0gT1.UDpLx9wL7iRfvQ.md#KeepCoding.Helper.InsertNewlines(string.int).condition 'KeepCoding.Helper.InsertNewlines(string, int).condition') with a line break every [maxLineLength](Helper.InsertNewlines.xkB0gT1.UDpLx9wL7iRfvQ.md#KeepCoding.Helper.InsertNewlines(string.int).maxLineLength 'KeepCoding.Helper.InsertNewlines(string, int).maxLineLength') or less characters.
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
[NegativeNumberException](NegativeNumberException.md 'KeepCoding.Internal.NegativeNumberException')  
### Remarks
This can be useful to prevent a [UnityEngine.TextMesh](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.TextMesh 'UnityEngine.TextMesh') from going outside its boundaries. A monospaced font is recommended in this case.  
