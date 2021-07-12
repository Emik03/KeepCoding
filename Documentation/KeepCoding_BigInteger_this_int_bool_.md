### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.this[int, bool] Property
Indexable number. Allows you to treat the value as an array.  
```csharp
public int this[int index, bool isLeftToRight=true] { get; set; }
```
#### Parameters
<a name='KeepCoding_BigInteger_this_int_bool__index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The [index](KeepCoding_BigInteger_this_int_bool_.md#KeepCoding_BigInteger_this_int_bool__index 'KeepCoding.BigInteger.this[int, bool].index')th digit to look from.
  
<a name='KeepCoding_BigInteger_this_int_bool__isLeftToRight'></a>
`isLeftToRight` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines if the index goes from left-to-right ([true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')), or right-to-left ([false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')).
  
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
#### Exceptions
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
