#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Base64UrlDecode(string) Method
Decodes this string from base-64-url encoding, which is safe for use in URLs and does not contain the  
unnecessary padding when the number of bytes is not divisible by 3, into a byte array.
```csharp
public static byte[] Base64UrlDecode(this string input);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.Base64UrlDecode(string).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
#### See Also
- [Base64UrlEncode(byte[])](UtilityHelper.Base64UrlEncode.+6sRIcSTyOfUoXKkpW4RAA.md 'KeepCoding.UtilityHelper.Base64UrlEncode(byte[])')
