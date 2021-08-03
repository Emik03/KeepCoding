#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInteger](BigInteger.md 'KeepCoding.BigInteger')
## BigInteger.IsBetween&lt;T&gt;(T, T) Method
Determines if it is between 2 other variables. Equality will count as true.  
```csharp
public bool IsBetween<T>(T min, T max);
```
#### Type parameters
<a name='KeepCoding.BigInteger.IsBetween.T.(T.T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.BigInteger.IsBetween.T.(T.T).min'></a>
`min` [T](BigInteger.IsBetween.yJzhZWc9mVQuODYolbnC3g.md#KeepCoding.BigInteger.IsBetween.T.(T.T).T 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).T')  
The minimum value accepted.
  
<a name='KeepCoding.BigInteger.IsBetween.T.(T.T).max'></a>
`max` [T](BigInteger.IsBetween.yJzhZWc9mVQuODYolbnC3g.md#KeepCoding.BigInteger.IsBetween.T.(T.T).T 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).T')  
The maximum value accepted.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [min](BigInteger.IsBetween.yJzhZWc9mVQuODYolbnC3g.md#KeepCoding.BigInteger.IsBetween.T.(T.T).min 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).min') is smaller or equal itself and [max](BigInteger.IsBetween.yJzhZWc9mVQuODYolbnC3g.md#KeepCoding.BigInteger.IsBetween.T.(T.T).max 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T).max') is greater or equal itself.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
