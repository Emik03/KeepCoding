#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.JsEscapeNull(string, JsQuotes) Method
Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.  
Returns "null" if the input is null.
```csharp
public static string JsEscapeNull(this string input, KeepCoding.UtilityExtensions.JsQuotes quotes=KeepCoding.UtilityExtensions.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.JsEscapeNull(string.KeepCoding.UtilityExtensions.JsQuotes).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding.UtilityExtensions.JsEscapeNull(string.KeepCoding.UtilityExtensions.JsQuotes).quotes'></a>
`quotes` [JsQuotes](UtilityExtensions.JsQuotes.md 'KeepCoding.UtilityExtensions.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
JavaScript- or JSON-compatible representation of the input string, or the "null" keyword if the input is null.
