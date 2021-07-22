#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.operator ==(object, BigInteger) Operator
Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').  
```csharp
public static bool operator ==(object value, KeepCoding.BigInteger bigInteger);
```
#### Parameters
<a name='KeepCoding_BigInteger_op_Equality(object_KeepCoding_BigInteger)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The left-hand side operator.
  
<a name='KeepCoding_BigInteger_op_Equality(object_KeepCoding_BigInteger)_bigInteger'></a>
`bigInteger` [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger')  
The right-hand side operator
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if both are the same number.
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[ConstructorArgumentException](KeepCoding_Internal_ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
[UnrecognizedValueException](KeepCoding_Internal_UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
