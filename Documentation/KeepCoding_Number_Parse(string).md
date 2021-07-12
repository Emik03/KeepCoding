### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](KeepCoding_Number.md 'KeepCoding.Number')
## Number.Parse(string) Method
Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.  
```csharp
public static KeepCoding.Number Parse(string s);
```
#### Parameters
<a name='KeepCoding_Number_Parse(string)_s'></a>
`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to parse.
  
#### Returns
[Number](KeepCoding_Number.md 'KeepCoding.Number')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number').
### Remarks
The smallest possible type is used. The order of types from first-to-last are: [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'), [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'), [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'), [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'), [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').  
