#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.SubstringSafe(string, int, int) Method
Same as [System.String.Substring(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Substring#System_String_Substring_System_Int32,System_Int32_ 'System.String.Substring(System.Int32,System.Int32)') but does not throw exceptions when the start index or length  
(or both) fall outside the boundaries of the string. Instead the result is truncated as appropriate.
```csharp
public static string SubstringSafe(this string source, int startIndex, int length);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.SubstringSafe(string.int.int).source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='KeepCoding.UtilityHelper.SubstringSafe(string.int.int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding.UtilityHelper.SubstringSafe(string.int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
