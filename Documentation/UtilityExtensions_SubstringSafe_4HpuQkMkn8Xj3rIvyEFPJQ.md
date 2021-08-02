#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SubstringSafe(string, int) Method
Same as [System.String.Substring(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Substring#System_String_Substring_System_Int32_ 'System.String.Substring(System.Int32)') but does not throw exceptions when the start index falls outside  
the boundaries of the string. Instead the result is truncated as appropriate.
```csharp
public static string SubstringSafe(this string source, int startIndex);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_SubstringSafe(string_int)_source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='KeepCoding_UtilityExtensions_SubstringSafe(string_int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
