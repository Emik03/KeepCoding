#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Base64UrlEncode(byte[]) Method
Encodes this byte array to base-64-url format, which is safe for use in URLs and does not contain the  
unnecessary padding when the number of bytes is not divisible by 3.
```csharp
public static string Base64UrlEncode(this byte[] bytes);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_Base64UrlEncode(byte__)_bytes'></a>
`bytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
#### See Also
- [Base64UrlDecode(string)](UtilityExtensions_Base64UrlDecode_MtMGAr_193mNL_Vcmol6QQ.md 'KeepCoding.UtilityExtensions.Base64UrlDecode(string)')