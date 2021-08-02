#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.CLiteralUnescape(string) Method
Reverses the escaping done by [CLiteralEscape(string)](UtilityExtensions_CLiteralEscape_ZW3Y7Ny6Fqf8Zm9ZxcKQZw.md 'KeepCoding.UtilityExtensions.CLiteralEscape(string)'). Note that unescaping is not fully C/C#-compatible  
in the sense that not all strings that are valid string literals in C/C# can be correctly unescaped by this  
procedure.
```csharp
public static string CLiteralUnescape(this string value);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_CLiteralUnescape(string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
#### See Also
- [CLiteralEscape(string)](UtilityExtensions_CLiteralEscape_ZW3Y7Ny6Fqf8Zm9ZxcKQZw.md 'KeepCoding.UtilityExtensions.CLiteralEscape(string)')
