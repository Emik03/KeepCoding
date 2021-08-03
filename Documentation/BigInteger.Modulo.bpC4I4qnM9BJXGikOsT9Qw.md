#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.Modulo&lt;T&gt;(T) Method
Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.  
```csharp
public KeepCoding.BigInteger Modulo<T>(T obj);
```
#### Type parameters
<a name='KeepCoding.BigInteger.Modulo.T.(T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.BigInteger.Modulo.T.(T).obj'></a>
`obj` [T](BigInteger.Modulo.bpC4I4qnM9BJXGikOsT9Qw.md#KeepCoding.BigInteger.Modulo.T.(T).T 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T).T')  
The right-hand side operator.
  
#### Returns
[BigInteger](BigInteger.md 'KeepCoding.BigInteger')  
Itself mod [obj](BigInteger.Modulo.bpC4I4qnM9BJXGikOsT9Qw.md#KeepCoding.BigInteger.Modulo.T.(T).obj 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T).obj').
#### Exceptions
[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
[NegativeNumberException](NegativeNumberException.md 'KeepCoding.Internal.NegativeNumberException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
