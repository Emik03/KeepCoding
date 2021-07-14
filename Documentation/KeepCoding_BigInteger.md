#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## BigInteger Class
Stores an arbitrarily large number.  
```csharp
public sealed class BigInteger :
System.ICloneable,
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.BigInteger>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BigInteger  

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [BigInteger()](KeepCoding_BigInteger_BigInteger().md 'KeepCoding.BigInteger.BigInteger()') | Creates a big integer with the default value. (0)<br/> |
| [BigInteger(object)](KeepCoding_BigInteger_BigInteger(object).md 'KeepCoding.BigInteger.BigInteger(object)') | Creates a big integer containing the number specified.<br/> |

| Properties | |
| :--- | :--- |
| [GetLowerBound](KeepCoding_BigInteger_GetLowerBound.md 'KeepCoding.BigInteger.GetLowerBound') |  |
| [GetUpperBound](KeepCoding_BigInteger_GetUpperBound.md 'KeepCoding.BigInteger.GetUpperBound') |  |
| [IsNegative](KeepCoding_BigInteger_IsNegative.md 'KeepCoding.BigInteger.IsNegative') |  |
| [Length](KeepCoding_BigInteger_Length.md 'KeepCoding.BigInteger.Length') |  |
| [One](KeepCoding_BigInteger_One.md 'KeepCoding.BigInteger.One') |  |
| [this[int, bool]](KeepCoding_BigInteger_this_int_bool_.md 'KeepCoding.BigInteger.this[int, bool]') | Indexable number. Allows you to treat the value as an array.<br/> |
| [Value](KeepCoding_BigInteger_Value.md 'KeepCoding.BigInteger.Value') | The number itself. The instance is duplicated so that the original BigInteger's value may not be modified directly.<br/> |
| [Zero](KeepCoding_BigInteger_Zero.md 'KeepCoding.BigInteger.Zero') |  |

| Methods | |
| :--- | :--- |
| [Clone()](KeepCoding_BigInteger_Clone().md 'KeepCoding.BigInteger.Clone()') | Makes a new instance/deep clone of [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Clone(BigInteger)](KeepCoding_BigInteger_Clone(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.Clone(KeepCoding.BigInteger)') | Makes a new instance/deep clone of [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Equals(BigInteger)](KeepCoding_BigInteger_Equals(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.Equals(KeepCoding.BigInteger)') | Determins if both values are equal.<br/> |
| [Equals(object)](KeepCoding_BigInteger_Equals(object).md 'KeepCoding.BigInteger.Equals(object)') | Determins if both values are equal.<br/> |
| [GetEnumerator()](KeepCoding_BigInteger_GetEnumerator().md 'KeepCoding.BigInteger.GetEnumerator()') | Gets the enumerator of the [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger'), using [Value](KeepCoding_BigInteger_Value.md 'KeepCoding.BigInteger.Value').<br/> |
| [GetHashCode()](KeepCoding_BigInteger_GetHashCode().md 'KeepCoding.BigInteger.GetHashCode()') | Gets the hash code of the current values.<br/> |
| [IsBetween&lt;T&gt;(T, T)](KeepCoding_BigInteger_IsBetween_T_(T_T).md 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T)') | Determines if it is between 2 other variables. Equality will count as true.<br/> |
| [IsBetween(BigInteger, BigInteger)](KeepCoding_BigInteger_IsBetween(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.IsBetween(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Determines if it is between 2 other [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger') variables. Equality will count as true.<br/> |
| [Modulo&lt;T&gt;(T)](KeepCoding_BigInteger_Modulo_T_(T).md 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [Modulo(BigInteger)](KeepCoding_BigInteger_Modulo(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.Modulo(KeepCoding.BigInteger)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [ToNumber()](KeepCoding_BigInteger_ToNumber().md 'KeepCoding.BigInteger.ToNumber()') | Converts the BigInteger to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [ToString()](KeepCoding_BigInteger_ToString().md 'KeepCoding.BigInteger.ToString()') | Converts the current array it stores as a string.<br/> |

| Operators | |
| :--- | :--- |
| [operator +(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Addition(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(BigInteger, object)](KeepCoding_BigInteger_op_Addition(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, object)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(object, BigInteger)](KeepCoding_BigInteger_op_Addition(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Addition(object, KeepCoding.BigInteger)') | Addition operator; gets the sum of 2 numbers.<br/> |
| [operator --(BigInteger)](KeepCoding_BigInteger_op_Decrement(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Decrement(KeepCoding.BigInteger)') | Subtraction operator; subtracts 1.<br/> |
| [operator /(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Division(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(BigInteger, object)](KeepCoding_BigInteger_op_Division(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, object)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(object, BigInteger)](KeepCoding_BigInteger_op_Division(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Division(object, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator ==(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Equality(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value.<br/> |
| [operator ==(BigInteger, object)](KeepCoding_BigInteger_op_Equality(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, object)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ==(object, BigInteger)](KeepCoding_BigInteger_op_Equality(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Equality(object, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [explicit operator Number(BigInteger)](KeepCoding_BigInteger_op_ExplicitKeepCoding_Number(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Explicit KeepCoding.Number(KeepCoding.BigInteger)') | Converts the [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger') to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [operator &gt;(BigInteger, BigInteger)](KeepCoding_BigInteger_op_GreaterThan(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(BigInteger, object)](KeepCoding_BigInteger_op_GreaterThan(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, object)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(object, BigInteger)](KeepCoding_BigInteger_op_GreaterThan(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_GreaterThan(object, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;=(BigInteger, BigInteger)](KeepCoding_BigInteger_op_GreaterThanOrEqual(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(BigInteger, object)](KeepCoding_BigInteger_op_GreaterThanOrEqual(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, object)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(object, BigInteger)](KeepCoding_BigInteger_op_GreaterThanOrEqual(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(object, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [implicit operator BigInteger(Number)](KeepCoding_BigInteger_op_ImplicitKeepCoding_BigInteger(KeepCoding_Number).md 'KeepCoding.BigInteger.op_Implicit KeepCoding.BigInteger(KeepCoding.Number)') | Converts the [Number](KeepCoding_Number.md 'KeepCoding.Number') to a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ++(BigInteger)](KeepCoding_BigInteger_op_Increment(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Increment(KeepCoding.BigInteger)') | Addition operator; adds 1.<br/> |
| [operator !=(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Inequality(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value.<br/> |
| [operator !=(BigInteger, object)](KeepCoding_BigInteger_op_Inequality(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, object)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator !=(object, BigInteger)](KeepCoding_BigInteger_op_Inequality(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Inequality(object, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator &lt;(BigInteger, BigInteger)](KeepCoding_BigInteger_op_LessThan(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(BigInteger, object)](KeepCoding_BigInteger_op_LessThan(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, object)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(object, BigInteger)](KeepCoding_BigInteger_op_LessThan(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_LessThan(object, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;=(BigInteger, BigInteger)](KeepCoding_BigInteger_op_LessThanOrEqual(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(BigInteger, object)](KeepCoding_BigInteger_op_LessThanOrEqual(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, object)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(object, BigInteger)](KeepCoding_BigInteger_op_LessThanOrEqual(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_LessThanOrEqual(object, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator %(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Modulus(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(BigInteger, object)](KeepCoding_BigInteger_op_Modulus(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, object)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(object, BigInteger)](KeepCoding_BigInteger_op_Modulus(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Modulus(object, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator *(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Multiply(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(BigInteger, object)](KeepCoding_BigInteger_op_Multiply(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, object)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(object, BigInteger)](KeepCoding_BigInteger_op_Multiply(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Multiply(object, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator -(BigInteger, BigInteger)](KeepCoding_BigInteger_op_Subtraction(KeepCoding_BigInteger_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger, object)](KeepCoding_BigInteger_op_Subtraction(KeepCoding_BigInteger_object).md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, object)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(object, BigInteger)](KeepCoding_BigInteger_op_Subtraction(object_KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_Subtraction(object, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger)](KeepCoding_BigInteger_op_UnaryNegation(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_UnaryNegation(KeepCoding.BigInteger)') | Negative operator; inverts [IsNegative](KeepCoding_BigInteger_IsNegative.md 'KeepCoding.BigInteger.IsNegative').<br/> |
| [operator +(BigInteger)](KeepCoding_BigInteger_op_UnaryPlus(KeepCoding_BigInteger).md 'KeepCoding.BigInteger.op_UnaryPlus(KeepCoding.BigInteger)') | Positive operator; returns itself.<br/> |
