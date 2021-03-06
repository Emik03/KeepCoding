#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Indent(string, int, bool) Method
Inserts spaces at the beginning of every line contained within the specified string.
```csharp
public static string Indent(this string str, int by, bool indentFirstLine=true);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.Indent(string.int.bool).str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to add indentation to.
  
<a name='KeepCoding.UtilityHelper.Indent(string.int.bool).by'></a>
`by` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Number of spaces to add.
  
<a name='KeepCoding.UtilityHelper.Indent(string.int.bool).indentFirstLine'></a>
`indentFirstLine` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true (default), all lines are indented; otherwise, all lines except the first.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The indented string.
