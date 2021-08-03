#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.JsQuotes Enum
Selects how the escaped JS string should be put into quotes.
```csharp
public enum UtilityHelper.JsQuotes

```
#### Fields
<a name='KeepCoding.UtilityHelper.JsQuotes.Double'></a>
`Double` 1  
Put double quotes around the output. Double quotes are allowed both in JavaScript and JSON.
  
<a name='KeepCoding.UtilityHelper.JsQuotes.None'></a>
`None` 2  
Do not put any quotes around the output. The escaped output may be surrounded with either type of quotes.
  
<a name='KeepCoding.UtilityHelper.JsQuotes.Single'></a>
`Single` 0  
Put single quotes around the output. Single quotes are allowed in JavaScript only, but not in JSON.
  
