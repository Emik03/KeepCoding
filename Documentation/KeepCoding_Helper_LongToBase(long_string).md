#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.LongToBase(long, string) Method
Converts any base-10 number to any base.  
```csharp
public static string LongToBase(this long value, string baseChars="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
```
#### Parameters
<a name='KeepCoding_Helper_LongToBase(long_string)_value'></a>
`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The value to convert.
  
<a name='KeepCoding_Helper_LongToBase(long_string)_baseChars'></a>
`baseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion to the base number, use [Alphanumeric](KeepCoding_Helper_Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](KeepCoding_Helper_Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](KeepCoding_Helper_Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[value](KeepCoding_Helper_LongToBase(long_string).md#KeepCoding_Helper_LongToBase(long_string)_value 'KeepCoding.Helper.LongToBase(long, string).value'), but in the base specified.
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
