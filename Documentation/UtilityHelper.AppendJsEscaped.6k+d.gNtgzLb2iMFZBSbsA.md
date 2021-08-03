#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.AppendJsEscaped(StringBuilder, string, JsQuotes) Method
Appends a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped  
into the specified StringBuilder.
```csharp
public static void AppendJsEscaped(this System.Text.StringBuilder sb, string input, KeepCoding.UtilityHelper.JsQuotes quotes=KeepCoding.UtilityHelper.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.AppendJsEscaped(System.Text.StringBuilder.string.KeepCoding.UtilityHelper.JsQuotes).sb'></a>
`sb` [System.Text.StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder 'System.Text.StringBuilder')  
The StringBuilder to add the result to.
  
<a name='KeepCoding.UtilityHelper.AppendJsEscaped(System.Text.StringBuilder.string.KeepCoding.UtilityHelper.JsQuotes).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding.UtilityHelper.AppendJsEscaped(System.Text.StringBuilder.string.KeepCoding.UtilityHelper.JsQuotes).quotes'></a>
`quotes` [JsQuotes](UtilityHelper.JsQuotes.md 'KeepCoding.UtilityHelper.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  
