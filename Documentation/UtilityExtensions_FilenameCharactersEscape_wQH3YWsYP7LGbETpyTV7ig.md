#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FilenameCharactersEscape(string, bool) Method
Escapes all characters in this string which cannot form part of a valid filename on at least one supported  
filesystem. The escaping is fully reversible (via [FilenameCharactersUnescape(string)](UtilityExtensions_FilenameCharactersUnescape_VCgbL6JLUkohULVbcmIPnw.md 'KeepCoding.UtilityExtensions.FilenameCharactersUnescape(string)')), but does not  
treat characters at specific positions differently (e.g. the "." at the end of the name is not escaped, even  
though it will disappear on a Win32 system).
```csharp
public static string FilenameCharactersEscape(this string input, bool includeNonAscii=false);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_FilenameCharactersEscape(string_bool)_input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='KeepCoding_UtilityExtensions_FilenameCharactersEscape(string_bool)_includeNonAscii'></a>
`includeNonAscii` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
