#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.BaseToLong(string, string) Method
Converts any base number to base-10.  
```csharp
public static long BaseToLong(this string value, string baseChars="01");
```
#### Parameters
<a name='KeepCoding_Helper_BaseToLong(string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to convert.
  
<a name='KeepCoding_Helper_BaseToLong(string_string)_baseChars'></a>
`baseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion from the base number, use [Alphanumeric](Helper_Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](Helper_Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](Helper_Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
[value](Helper_BaseToLong_BjHoA+clUL8MjdPlxp6dyw.md#KeepCoding_Helper_BaseToLong(string_string)_value 'KeepCoding.Helper.BaseToLong(string, string).value'), but in the base specified.
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  