#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.HtmlEscape(string, bool, bool) Method
Escapes all necessary characters in the specified string so as to make it usable safely in an HTML or XML  
context.
```csharp
public static string HtmlEscape(this string input, bool leaveSingleQuotesAlone=false, bool leaveDoubleQuotesAlone=false);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_HtmlEscape(string_bool_bool)_input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to apply HTML or XML escaping to.
  
<a name='KeepCoding_UtilityExtensions_HtmlEscape(string_bool_bool)_leaveSingleQuotesAlone'></a>
`leaveSingleQuotesAlone` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If `true`, does not escape single quotes (`'`, U+0027).
  
<a name='KeepCoding_UtilityExtensions_HtmlEscape(string_bool_bool)_leaveDoubleQuotesAlone'></a>
`leaveDoubleQuotesAlone` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If `true`, does not escape single quotes (`"`, U+0022).
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The specified string with the necessary HTML or XML escaping applied.
