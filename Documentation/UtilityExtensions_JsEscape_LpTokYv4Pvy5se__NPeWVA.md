#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.JsEscape(string, JsQuotes) Method
Returns a JavaScript- or JSON-compatible representation of the string with the appropriate characters escaped.
```csharp
public static string JsEscape(this string input, KeepCoding.UtilityExtensions.JsQuotes quotes=KeepCoding.UtilityExtensions.JsQuotes.Double);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_JsEscape(string_KeepCoding_UtilityExtensions_JsQuotes)_input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to escape.
  
<a name='KeepCoding_UtilityExtensions_JsEscape(string_KeepCoding_UtilityExtensions_JsQuotes)_quotes'></a>
`quotes` [JsQuotes](UtilityExtensions_JsQuotes.md 'KeepCoding.UtilityExtensions.JsQuotes')  
Specifies what type of quotes to put around the result, if any.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
JavaScript- or JSON-compatible representation of the input string.
