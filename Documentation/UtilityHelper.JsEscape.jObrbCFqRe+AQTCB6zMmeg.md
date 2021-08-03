#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.JsEscape(string, JsQuotes) Method
Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.
```csharp
public static string JsEscape(this string input, KeepCoding.UtilityHelper.JsQuotes quotes=KeepCoding.UtilityHelper.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.JsEscape(string.KeepCoding.UtilityHelper.JsQuotes).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding.UtilityHelper.JsEscape(string.KeepCoding.UtilityHelper.JsQuotes).quotes'></a>
`quotes` [JsQuotes](UtilityHelper.JsQuotes.md 'KeepCoding.UtilityHelper.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
JavaScript- or JSON-compatible representation of the input string.
