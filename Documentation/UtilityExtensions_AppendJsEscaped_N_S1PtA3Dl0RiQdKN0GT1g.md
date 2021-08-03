#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.AppendJsEscaped(StringBuilder, string, JsQuotes) Method
Appends a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped  
into the specified StringBuilder.
```csharp
public static void AppendJsEscaped(this System.Text.StringBuilder sb, string input, KeepCoding.UtilityExtensions.JsQuotes quotes=KeepCoding.UtilityExtensions.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_AppendJsEscaped(System_Text_StringBuilder_string_KeepCoding_UtilityExtensions_JsQuotes)_sb'></a>
`sb` [System.Text.StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder 'System.Text.StringBuilder')  
The StringBuilder to add the result to.
  
<a name='KeepCoding_UtilityExtensions_AppendJsEscaped(System_Text_StringBuilder_string_KeepCoding_UtilityExtensions_JsQuotes)_input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding_UtilityExtensions_AppendJsEscaped(System_Text_StringBuilder_string_KeepCoding_UtilityExtensions_JsQuotes)_quotes'></a>
`quotes` [JsQuotes](UtilityExtensions_JsQuotes.md 'KeepCoding.UtilityExtensions.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  