#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.JsEscapeNull(string, JsQuotes) Method
Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.  
Returns "null" if the input is null.
```csharp
public static string JsEscapeNull(this string input, KeepCoding.UtilityHelper.JsQuotes quotes=KeepCoding.UtilityHelper.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.JsEscapeNull(string.KeepCoding.UtilityHelper.JsQuotes).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding.UtilityHelper.JsEscapeNull(string.KeepCoding.UtilityHelper.JsQuotes).quotes'></a>
`quotes` [JsQuotes](UtilityHelper.JsQuotes.md 'KeepCoding.UtilityHelper.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
JavaScript- or JSON-compatible representation of the input string, or the "null" keyword if the input is null.
