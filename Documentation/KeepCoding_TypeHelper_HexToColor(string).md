#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.HexToColor(string) Method
Converts a hexadecimal string into colors.  
```csharp
public static Color32 HexToColor(this string hex);
```
#### Parameters
<a name='KeepCoding_TypeHelper_HexToColor(string)_hex'></a>
`hex` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string of hexadecimal, which can be formatted as "FFFFFF", "#FFFFFF", or "0xFFFFFF"
  
#### Returns
[UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
[UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32') converted from hexadecimal string.
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
