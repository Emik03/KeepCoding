#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.TryParse(string, NumberStyles, NumberFormatInfo, Number) Method
Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number').  
```csharp
public static bool TryParse(string s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, out KeepCoding.Number number);
```
#### Parameters
<a name='KeepCoding.Number.TryParse(string.System.Globalization.NumberStyles.System.Globalization.NumberFormatInfo.KeepCoding.Number).s'></a>
`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to parse.
  
<a name='KeepCoding.Number.TryParse(string.System.Globalization.NumberStyles.System.Globalization.NumberFormatInfo.KeepCoding.Number).style'></a>
`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')  
The [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing.
  
<a name='KeepCoding.Number.TryParse(string.System.Globalization.NumberStyles.System.Globalization.NumberFormatInfo.KeepCoding.Number).info'></a>
`info` [System.Globalization.NumberFormatInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo')  
The [System.Globalization.NumberFormatInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') used for parsing.
  
<a name='KeepCoding.Number.TryParse(string.System.Globalization.NumberStyles.System.Globalization.NumberFormatInfo.KeepCoding.Number).number'></a>
`number` [Number](Number.md 'KeepCoding.Number')  
The number to store the result in. An instance is returned if it is able to be casted successfully, and [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') otherwise.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if it was able to successfully parse the string as a [Number](Number.md 'KeepCoding.Number').
### Remarks
The smallest possible type is used. The order of types from first-to-last are: [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'), [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'), [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'), [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'), [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').  
