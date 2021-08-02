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

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[BigInteger](BigInteger.md 'KeepCoding.BigInteger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [BigInteger()](BigInteger_BigInteger().md 'KeepCoding.BigInteger.BigInteger()') | Creates a big integer with the default value. (0)<br/> |
| [BigInteger(object)](BigInteger__ctor_H5v27k6wJYsoTS495Nf4Rg.md 'KeepCoding.BigInteger.BigInteger(object)') | Creates a big integer containing the number specified.<br/> |

| Properties | |
| :--- | :--- |
| [GetLowerBound](BigInteger_GetLowerBound.md 'KeepCoding.BigInteger.GetLowerBound') | The first digit's index.<br/> |
| [GetUpperBound](BigInteger_GetUpperBound.md 'KeepCoding.BigInteger.GetUpperBound') | The last digit's index.<br/> |
| [IsNegative](BigInteger_IsNegative.md 'KeepCoding.BigInteger.IsNegative') | Whether or not the number is negative.<br/> |
| [Length](BigInteger_Length.md 'KeepCoding.BigInteger.Length') | The amount of digits of the value.<br/> |
| [One](BigInteger_One.md 'KeepCoding.BigInteger.One') | BigInteger with value one.<br/> |
| [this[int, bool]](BigInteger_Item_+Q9WebTztOqeFcRhE_wdYA.md 'KeepCoding.BigInteger.this[int, bool]') | Indexable number. Allows you to treat the value as an array.<br/> |
| [Value](BigInteger_Value.md 'KeepCoding.BigInteger.Value') | The number itself. The instance is duplicated so that the original BigInteger's value may not be modified directly.<br/> |
| [Zero](BigInteger_Zero.md 'KeepCoding.BigInteger.Zero') | BigInteger with value zero. (Default value)<br/> |

| Methods | |
| :--- | :--- |
| [Clone()](BigInteger_Clone().md 'KeepCoding.BigInteger.Clone()') | Makes a new instance/deep clone of [BigInteger](BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Clone(BigInteger)](BigInteger_Clone_Ca6hCAAkoZB71ME8bnw+bA.md 'KeepCoding.BigInteger.Clone(KeepCoding.BigInteger)') | Makes a new instance/deep clone of [BigInteger](BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Equals(BigInteger)](BigInteger_Equals_THjQZzgw3eRQmNw0yVhbEg.md 'KeepCoding.BigInteger.Equals(KeepCoding.BigInteger)') | Determins if both values are equal.<br/> |
| [Equals(object)](BigInteger_Equals_j0ve2P6uOqI9pDlomE_X6Q.md 'KeepCoding.BigInteger.Equals(object)') | Determins if both values are equal.<br/> |
| [GetEnumerator()](BigInteger_GetEnumerator().md 'KeepCoding.BigInteger.GetEnumerator()') | Gets the enumerator of the [BigInteger](BigInteger.md 'KeepCoding.BigInteger'), using [Value](BigInteger_Value.md 'KeepCoding.BigInteger.Value').<br/> |
| [GetHashCode()](BigInteger_GetHashCode().md 'KeepCoding.BigInteger.GetHashCode()') | Gets the hash code of the current values.<br/> |
| [IsBetween&lt;T&gt;(T, T)](BigInteger_IsBetween_yJzhZWc9mVQuODYolbnC3g.md 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T)') | Determines if it is between 2 other variables. Equality will count as true.<br/> |
| [IsBetween(BigInteger, BigInteger)](BigInteger_IsBetween_Yh3JRBV1uTJWyq_s_StQIQ.md 'KeepCoding.BigInteger.IsBetween(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Determines if it is between 2 other [BigInteger](BigInteger.md 'KeepCoding.BigInteger') variables. Equality will count as true.<br/> |
| [Modulo&lt;T&gt;(T)](BigInteger_Modulo_bpC4I4qnM9BJXGikOsT9Qw.md 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [Modulo(BigInteger)](BigInteger_Modulo_Cf2tHbYj9yV0s7KKKubQ2g.md 'KeepCoding.BigInteger.Modulo(KeepCoding.BigInteger)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [ToNumber()](BigInteger_ToNumber().md 'KeepCoding.BigInteger.ToNumber()') | Converts the BigInteger to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [ToString()](BigInteger_ToString().md 'KeepCoding.BigInteger.ToString()') | Converts the current array it stores as a string.<br/> |

| Operators | |
| :--- | :--- |
| [operator +(BigInteger, BigInteger)](BigInteger_op_Addition_dGZ_UVfIFNQTDarfe0+5eA.md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(BigInteger, object)](BigInteger_op_Addition_psPNknYHqbSdMQ56dJxqCA.md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, object)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(object, BigInteger)](BigInteger_op_Addition_We2qsSMRWfpDytfFvy4sdA.md 'KeepCoding.BigInteger.op_Addition(object, KeepCoding.BigInteger)') | Addition operator; gets the sum of 2 numbers.<br/> |
| [operator --(BigInteger)](BigInteger_op_Decrement_nAcmmNGNdQOl8r4Z+6zFWQ.md 'KeepCoding.BigInteger.op_Decrement(KeepCoding.BigInteger)') | Subtraction operator; subtracts 1.<br/> |
| [operator /(BigInteger, BigInteger)](BigInteger_op_Division_t+Wm9GcAvaoygv1wdJDNrQ.md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(BigInteger, object)](BigInteger_op_Division_zEcsOBTHQGLi7OAXANlsrA.md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, object)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(object, BigInteger)](BigInteger_op_Division_2H6kL0CWG4lP49vQIMHmJQ.md 'KeepCoding.BigInteger.op_Division(object, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator ==(BigInteger, BigInteger)](BigInteger_op_Equality_tXKyqvfLpz0I4822vdgZlQ.md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value.<br/> |
| [operator ==(BigInteger, object)](BigInteger_op_Equality_9rRfE7Qeo26p+0_uk+mVNg.md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, object)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ==(object, BigInteger)](BigInteger_op_Equality_pI6yzTIpSWcuT+_ZjjBk4A.md 'KeepCoding.BigInteger.op_Equality(object, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [explicit operator Number(BigInteger)](BigInteger_op_Explicit_ZuxcRlO6cK0VaIVz4wu2sw.md 'KeepCoding.BigInteger.op_Explicit KeepCoding.Number(KeepCoding.BigInteger)') | Converts the [BigInteger](BigInteger.md 'KeepCoding.BigInteger') to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [operator &gt;(BigInteger, BigInteger)](BigInteger_op_GreaterThan_JRopUk4wOHTzMNMyjavPjg.md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(BigInteger, object)](BigInteger_op_GreaterThan_WR_h26ru96aVZgcupy+Zdg.md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, object)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(object, BigInteger)](BigInteger_op_GreaterThan_f22UR4h5vV17UPDDc_vZtg.md 'KeepCoding.BigInteger.op_GreaterThan(object, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;=(BigInteger, BigInteger)](BigInteger_op_GreaterThanOrEqual_VnWQEK+x3ORbEOXeXgkGOA.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(BigInteger, object)](BigInteger_op_GreaterThanOrEqual_7DMtp6hS_lG8XayxTWb4xA.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, object)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(object, BigInteger)](BigInteger_op_GreaterThanOrEqual_CvzOZEBF0wq0cjlrWw2T6Q.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(object, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [implicit operator BigInteger(Number)](BigInteger_op_Implicit_jOqf5eeTX5ZrHURvWHlMrA.md 'KeepCoding.BigInteger.op_Implicit KeepCoding.BigInteger(KeepCoding.Number)') | Converts the [Number](Number.md 'KeepCoding.Number') to a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ++(BigInteger)](BigInteger_op_Increment_hd+fhjeYhDbjcROaXf7BIg.md 'KeepCoding.BigInteger.op_Increment(KeepCoding.BigInteger)') | Addition operator; adds 1.<br/> |
| [operator !=(BigInteger, BigInteger)](BigInteger_op_Inequality_46yRbB3Q120ngu+HP8Vv8Q.md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value.<br/> |
| [operator !=(BigInteger, object)](BigInteger_op_Inequality_R_gkOxARA7ZE3TNO_p5Fvg.md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, object)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator !=(object, BigInteger)](BigInteger_op_Inequality_KBzTelpDT4utjOnFh1Eauw.md 'KeepCoding.BigInteger.op_Inequality(object, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator &lt;(BigInteger, BigInteger)](BigInteger_op_LessThan_KpU6rFKWRQSD6wuiCtzUww.md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(BigInteger, object)](BigInteger_op_LessThan_lVxvAodCSVtWBrXR3M11Nw.md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, object)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(object, BigInteger)](BigInteger_op_LessThan_DmuGOVGU9QqQdDrlTh7MFA.md 'KeepCoding.BigInteger.op_LessThan(object, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;=(BigInteger, BigInteger)](BigInteger_op_LessThanOrEqual_zeOr33UeyJT8PRebY2m7tQ.md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(BigInteger, object)](BigInteger_op_LessThanOrEqual_DFcP5Tte1IqfqGvwVQ8ymQ.md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, object)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(object, BigInteger)](BigInteger_op_LessThanOrEqual_v5KNOtTmWRoal3MnEp83FA.md 'KeepCoding.BigInteger.op_LessThanOrEqual(object, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator %(BigInteger, BigInteger)](BigInteger_op_Modulus_wNLFZsyL_qoBtVBkNfJ4Bw.md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(BigInteger, object)](BigInteger_op_Modulus_pyFG_BfCWKtEmEckNgEtDA.md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, object)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(object, BigInteger)](BigInteger_op_Modulus_yF4ZjGoGEQivNO2WfhmF5g.md 'KeepCoding.BigInteger.op_Modulus(object, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator *(BigInteger, BigInteger)](BigInteger_op_Multiply_7_PUFW4MimlmjqzpXQGL4A.md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(BigInteger, object)](BigInteger_op_Multiply_u6BpcyYokG2Jx+SEQLmwWA.md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, object)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(object, BigInteger)](BigInteger_op_Multiply_iOiA7MdL1dxohyx7yRlVtw.md 'KeepCoding.BigInteger.op_Multiply(object, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator -(BigInteger, BigInteger)](BigInteger_op_Subtraction_y+6GxTFKZvQVU3aAHKO2Vg.md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger, object)](BigInteger_op_Subtraction_dPMr0832JjkcdUrjaeHCdQ.md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, object)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(object, BigInteger)](BigInteger_op_Subtraction_tIAF3w3bciBa5tbZFkhx9Q.md 'KeepCoding.BigInteger.op_Subtraction(object, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger)](BigInteger_op_UnaryNegation_mx+8ZKI9Ci4H+idF1psemA.md 'KeepCoding.BigInteger.op_UnaryNegation(KeepCoding.BigInteger)') | Negative operator; inverts [IsNegative](BigInteger_IsNegative.md 'KeepCoding.BigInteger.IsNegative').<br/> |
| [operator +(BigInteger)](BigInteger_op_UnaryPlus_OdaJxK7CiBTDiCKZQfv6CA.md 'KeepCoding.BigInteger.op_UnaryPlus(KeepCoding.BigInteger)') | Positive operator; returns itself.<br/> |
