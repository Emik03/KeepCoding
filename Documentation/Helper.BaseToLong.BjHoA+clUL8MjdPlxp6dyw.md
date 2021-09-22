#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.BaseToLong(string, string) Method
Converts any base number to base-10.  
```csharp
public static long BaseToLong(this string value, string baseChars);
```
#### Parameters
<a name='KeepCoding.Helper.BaseToLong(string.string).value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to convert.
  
<a name='KeepCoding.Helper.BaseToLong(string.string).baseChars'></a>
`baseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion from the base number, use [Alphanumeric](Helper.Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](Helper.Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](Helper.Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
[value](Helper.BaseToLong.BjHoA+clUL8MjdPlxp6dyw.md#KeepCoding.Helper.BaseToLong(string.string).value 'KeepCoding.Helper.BaseToLong(string, string).value'), but in the base specified.
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
