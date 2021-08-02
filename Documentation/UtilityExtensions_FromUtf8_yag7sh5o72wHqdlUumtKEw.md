#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FromUtf8(byte[], bool) Method
Converts the specified raw UTF-8 data to a string.
```csharp
public static string FromUtf8(this byte[] input, bool removeBom=false);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_FromUtf8(byte___bool)_input'></a>
`input` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Data to interpret as UTF-8 text.
  
<a name='KeepCoding_UtilityExtensions_FromUtf8(byte___bool)_removeBom'></a>
`removeBom` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` to remove the first character if it is a UTF-8 BOM.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing the characters represented by the UTF-8-encoded input.
