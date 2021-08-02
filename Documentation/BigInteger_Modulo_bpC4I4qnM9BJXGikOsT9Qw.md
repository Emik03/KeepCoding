#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.Modulo&lt;T&gt;(T) Method
Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.  
```csharp
public KeepCoding.BigInteger Modulo<T>(T obj);
```
#### Type parameters
<a name='KeepCoding_BigInteger_Modulo_T_(T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_BigInteger_Modulo_T_(T)_obj'></a>
`obj` [T](BigInteger_Modulo_bpC4I4qnM9BJXGikOsT9Qw.md#KeepCoding_BigInteger_Modulo_T_(T)_T 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T).T')  
The right-hand side operator.
  
#### Returns
[BigInteger](BigInteger.md 'KeepCoding.BigInteger')  
Itself mod [obj](BigInteger_Modulo_bpC4I4qnM9BJXGikOsT9Qw.md#KeepCoding_BigInteger_Modulo_T_(T)_obj 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T).obj').
#### Exceptions
[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
[NegativeNumberException](NegativeNumberException.md 'KeepCoding.Internal.NegativeNumberException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
