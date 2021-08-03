#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.LongToBase(long, string) Method
Converts any base-10 number to any base.  
```csharp
public static string LongToBase(this long value, string baseChars="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
```
#### Parameters
<a name='KeepCoding.Helper.LongToBase(long.string).value'></a>
`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The value to convert.
  
<a name='KeepCoding.Helper.LongToBase(long.string).baseChars'></a>
`baseChars` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
All of the base characters for the conversion to the base number, use [Alphanumeric](Helper.Alphanumeric.md 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](Helper.Decimal.md 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](Helper.Binary.md 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[value](Helper.LongToBase.kglNsTCKchNAG3sTw6pfMw.md#KeepCoding.Helper.LongToBase(long.string).value 'KeepCoding.Helper.LongToBase(long, string).value'), but in the base specified.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
