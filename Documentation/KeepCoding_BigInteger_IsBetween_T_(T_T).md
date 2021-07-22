#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.IsBetween&lt;T&gt;(T, T) Method
Determines if it is between 2 other variables. Equality will count as true.  
```csharp
public bool IsBetween<T>(T min, T max);
```
#### Type parameters
<a name='KeepCoding_BigInteger_IsBetween_T_(T_T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_BigInteger_IsBetween_T_(T_T)_min'></a>
`min` [T](KeepCoding_BigInteger_IsBetween_T_(T_T).md#KeepCoding_BigInteger_IsBetween_T_(T_T)_T 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).T')  
The minimum value accepted.
  
<a name='KeepCoding_BigInteger_IsBetween_T_(T_T)_max'></a>
`max` [T](KeepCoding_BigInteger_IsBetween_T_(T_T).md#KeepCoding_BigInteger_IsBetween_T_(T_T)_T 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).T')  
The maximum value accepted.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [min](KeepCoding_BigInteger_IsBetween_T_(T_T).md#KeepCoding_BigInteger_IsBetween_T_(T_T)_min 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).min') is smaller or equal itself and [max](KeepCoding_BigInteger_IsBetween_T_(T_T).md#KeepCoding_BigInteger_IsBetween_T_(T_T)_max 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).max') is greater or equal itself.
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[ConstructorArgumentException](KeepCoding_Internal_ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
[UnrecognizedValueException](KeepCoding_Internal_UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
