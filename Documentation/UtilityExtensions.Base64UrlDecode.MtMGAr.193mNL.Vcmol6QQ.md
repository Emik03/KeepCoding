#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Base64UrlDecode(string) Method
Decodes this string from base-64-url encoding, which is safe for use in URLs and does not contain the  
unnecessary padding when the number of bytes is not divisible by 3, into a byte array.
```csharp
public static byte[] Base64UrlDecode(this string input);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.Base64UrlDecode(string).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
#### See Also
- [Base64UrlEncode(byte[])](UtilityExtensions.Base64UrlEncode.5k7iKhHqzaZB5UkwO7d1Nw.md 'KeepCoding.UtilityExtensions.Base64UrlEncode(byte[])')
