#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Base(string, string, string) Method
Converts any base number to any base.  
```csharp
public static string Base(this string value, string fromBaseChars="01", string toBaseChars="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
```
#### Parameters
<a name='KeepCoding_Helper_Base(string_string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to convert.
  
<a name='KeepCoding_Helper_Base(string_string_string)_fromBaseChars'></a>
`fromBaseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion from the base number, use [Alphanumeric](KeepCoding_Helper_Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](KeepCoding_Helper_Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](KeepCoding_Helper_Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
<a name='KeepCoding_Helper_Base(string_string_string)_toBaseChars'></a>
`toBaseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion to the base number, use [Alphanumeric](KeepCoding_Helper_Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](KeepCoding_Helper_Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](KeepCoding_Helper_Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[value](KeepCoding_Helper_Base(string_string_string).md#KeepCoding_Helper_Base(string_string_string)_value 'KeepCoding.Helper.Base(string, string, string).value'), but in the base specified.
