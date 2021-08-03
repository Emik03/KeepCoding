#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.JsQuotes Enum
Selects how the escaped JS string should be put into quotes.
```csharp
public enum UtilityExtensions.JsQuotes

```
#### Fields
<a name='KeepCoding.UtilityExtensions.JsQuotes.Double'></a>
`Double` 1  
Put double quotes around the output. Double quotes are allowed both in JavaScript and JSON.
  
<a name='KeepCoding.UtilityExtensions.JsQuotes.None'></a>
`None` 2  
Do not put any quotes around the output. The escaped output may be surrounded with either type of quotes.
  
<a name='KeepCoding.UtilityExtensions.JsQuotes.Single'></a>
`Single` 0  
Put single quotes around the output. Single quotes are allowed in JavaScript only, but not in JSON.
  
