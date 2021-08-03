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
| [BigInteger()](BigInteger.BigInteger().md 'KeepCoding.BigInteger.BigInteger()') | Creates a big integer with the default value. (0)<br/> |
| [BigInteger(object)](BigInteger..ctor.H5v27k6wJYsoTS495Nf4Rg.md 'KeepCoding.BigInteger.BigInteger(object)') | Creates a big integer containing the number specified.<br/> |

| Properties | |
| :--- | :--- |
| [GetLowerBound](BigInteger.GetLowerBound.md 'KeepCoding.BigInteger.GetLowerBound') | The first digit's index.<br/> |
| [GetUpperBound](BigInteger.GetUpperBound.md 'KeepCoding.BigInteger.GetUpperBound') | The last digit's index.<br/> |
| [IsNegative](BigInteger.IsNegative.md 'KeepCoding.BigInteger.IsNegative') | Whether or not the number is negative.<br/> |
| [Length](BigInteger.Length.md 'KeepCoding.BigInteger.Length') | The amount of digits of the value.<br/> |
| [One](BigInteger.One.md 'KeepCoding.BigInteger.One') | BigInteger with value one.<br/> |
| [this[int, bool]](BigInteger.Item.+Q9WebTztOqeFcRhE.wdYA.md 'KeepCoding.BigInteger.this[int, bool]') | Indexable number. Allows you to treat the value as an array.<br/> |
| [Value](BigInteger.Value.md 'KeepCoding.BigInteger.Value') | The number itself. The instance is duplicated so that the original BigInteger's value may not be modified directly.<br/> |
| [Zero](BigInteger.Zero.md 'KeepCoding.BigInteger.Zero') | BigInteger with value zero. (Default value)<br/> |

| Methods | |
| :--- | :--- |
| [Clone()](BigInteger.Clone().md 'KeepCoding.BigInteger.Clone()') | Makes a new instance/deep clone of [BigInteger](BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Clone(BigInteger)](BigInteger.Clone.Ca6hCAAkoZB71ME8bnw+bA.md 'KeepCoding.BigInteger.Clone(KeepCoding.BigInteger)') | Makes a new instance/deep clone of [BigInteger](BigInteger.md 'KeepCoding.BigInteger') with the same value.<br/> |
| [Equals(BigInteger)](BigInteger.Equals.THjQZzgw3eRQmNw0yVhbEg.md 'KeepCoding.BigInteger.Equals(KeepCoding.BigInteger)') | Determins if both values are equal.<br/> |
| [Equals(object)](BigInteger.Equals.j0ve2P6uOqI9pDlomE.X6Q.md 'KeepCoding.BigInteger.Equals(object)') | Determins if both values are equal.<br/> |
| [GetEnumerator()](BigInteger.GetEnumerator().md 'KeepCoding.BigInteger.GetEnumerator()') | Gets the enumerator of the [BigInteger](BigInteger.md 'KeepCoding.BigInteger'), using [Value](BigInteger.Value.md 'KeepCoding.BigInteger.Value').<br/> |
| [GetHashCode()](BigInteger.GetHashCode().md 'KeepCoding.BigInteger.GetHashCode()') | Gets the hash code of the current values.<br/> |
| [IsBetween&lt;T&gt;(T, T)](BigInteger.IsBetween.yJzhZWc9mVQuODYolbnC3g.md 'KeepCoding.BigInteger.IsBetween&lt;T&gt;(T, T)') | Determines if it is between 2 other variables. Equality will count as true.<br/> |
| [IsBetween(BigInteger, BigInteger)](BigInteger.IsBetween.Yh3JRBV1uTJWyq.s.StQIQ.md 'KeepCoding.BigInteger.IsBetween(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Determines if it is between 2 other [BigInteger](BigInteger.md 'KeepCoding.BigInteger') variables. Equality will count as true.<br/> |
| [Modulo&lt;T&gt;(T)](BigInteger.Modulo.bpC4I4qnM9BJXGikOsT9Qw.md 'KeepCoding.BigInteger.Modulo&lt;T&gt;(T)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [Modulo(BigInteger)](BigInteger.Modulo.Cf2tHbYj9yV0s7KKKubQ2g.md 'KeepCoding.BigInteger.Modulo(KeepCoding.BigInteger)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [ToNumber()](BigInteger.ToNumber().md 'KeepCoding.BigInteger.ToNumber()') | Converts the BigInteger to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [ToString()](BigInteger.ToString().md 'KeepCoding.BigInteger.ToString()') | Converts the current array it stores as a string.<br/> |

| Operators | |
| :--- | :--- |
| [operator +(BigInteger, BigInteger)](BigInteger.op_Addition.dGZ.UVfIFNQTDarfe0+5eA.md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(BigInteger, object)](BigInteger.op_Addition.psPNknYHqbSdMQ56dJxqCA.md 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger, object)') | Add operator; gets the sum of 2 numbers.<br/> |
| [operator +(object, BigInteger)](BigInteger.op_Addition.We2qsSMRWfpDytfFvy4sdA.md 'KeepCoding.BigInteger.op_Addition(object, KeepCoding.BigInteger)') | Addition operator; gets the sum of 2 numbers.<br/> |
| [operator --(BigInteger)](BigInteger.op_Decrement.nAcmmNGNdQOl8r4Z+6zFWQ.md 'KeepCoding.BigInteger.op_Decrement(KeepCoding.BigInteger)') | Subtraction operator; subtracts 1.<br/> |
| [operator /(BigInteger, BigInteger)](BigInteger.op_Division.t+Wm9GcAvaoygv1wdJDNrQ.md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(BigInteger, object)](BigInteger.op_Division.zEcsOBTHQGLi7OAXANlsrA.md 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger, object)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator /(object, BigInteger)](BigInteger.op_Division.2H6kL0CWG4lP49vQIMHmJQ.md 'KeepCoding.BigInteger.op_Division(object, KeepCoding.BigInteger)') | Division operator; gets the quotient of 2 numbers.<br/> |
| [operator ==(BigInteger, BigInteger)](BigInteger.op_Equality.tXKyqvfLpz0I4822vdgZlQ.md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value.<br/> |
| [operator ==(BigInteger, object)](BigInteger.op_Equality.9rRfE7Qeo26p+0.uk+mVNg.md 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger, object)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ==(object, BigInteger)](BigInteger.op_Equality.pI6yzTIpSWcuT+.ZjjBk4A.md 'KeepCoding.BigInteger.op_Equality(object, KeepCoding.BigInteger)') | Equals operator; determines if both integers contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [explicit operator Number(BigInteger)](BigInteger.op_Explicit.ZuxcRlO6cK0VaIVz4wu2sw.md 'KeepCoding.BigInteger.op_Explicit KeepCoding.Number(KeepCoding.BigInteger)') | Converts the [BigInteger](BigInteger.md 'KeepCoding.BigInteger') to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [operator &gt;(BigInteger, BigInteger)](BigInteger.op_GreaterThan.JRopUk4wOHTzMNMyjavPjg.md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(BigInteger, object)](BigInteger.op_GreaterThan.WR.h26ru96aVZgcupy+Zdg.md 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger, object)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;(object, BigInteger)](BigInteger.op_GreaterThan.f22UR4h5vV17UPDDc.vZtg.md 'KeepCoding.BigInteger.op_GreaterThan(object, KeepCoding.BigInteger)') | More than operator; determines if left-hand side has a greater value than right-hand side.<br/> |
| [operator &gt;=(BigInteger, BigInteger)](BigInteger.op_GreaterThanOrEqual.VnWQEK+x3ORbEOXeXgkGOA.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(BigInteger, object)](BigInteger.op_GreaterThanOrEqual.7DMtp6hS.lG8XayxTWb4xA.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger, object)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [operator &gt;=(object, BigInteger)](BigInteger.op_GreaterThanOrEqual.CvzOZEBF0wq0cjlrWw2T6Q.md 'KeepCoding.BigInteger.op_GreaterThanOrEqual(object, KeepCoding.BigInteger)') | More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.<br/> |
| [implicit operator BigInteger(Number)](BigInteger.op_Implicit.jOqf5eeTX5ZrHURvWHlMrA.md 'KeepCoding.BigInteger.op_Implicit KeepCoding.BigInteger(KeepCoding.Number)') | Converts the [Number](Number.md 'KeepCoding.Number') to a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator ++(BigInteger)](BigInteger.op_Increment.hd+fhjeYhDbjcROaXf7BIg.md 'KeepCoding.BigInteger.op_Increment(KeepCoding.BigInteger)') | Addition operator; adds 1.<br/> |
| [operator !=(BigInteger, BigInteger)](BigInteger.op_Inequality.46yRbB3Q120ngu+HP8Vv8Q.md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value.<br/> |
| [operator !=(BigInteger, object)](BigInteger.op_Inequality.R.gkOxARA7ZE3TNO.p5Fvg.md 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger, object)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator !=(object, BigInteger)](BigInteger.op_Inequality.KBzTelpDT4utjOnFh1Eauw.md 'KeepCoding.BigInteger.op_Inequality(object, KeepCoding.BigInteger)') | Not equals operator; determines if both integers do not contain the same value. The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is casted as a [BigInteger](BigInteger.md 'KeepCoding.BigInteger').<br/> |
| [operator &lt;(BigInteger, BigInteger)](BigInteger.op_LessThan.KpU6rFKWRQSD6wuiCtzUww.md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(BigInteger, object)](BigInteger.op_LessThan.lVxvAodCSVtWBrXR3M11Nw.md 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger, object)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;(object, BigInteger)](BigInteger.op_LessThan.DmuGOVGU9QqQdDrlTh7MFA.md 'KeepCoding.BigInteger.op_LessThan(object, KeepCoding.BigInteger)') | Less than operator; determines if left-hand side has a lesser value than right-hand side.<br/> |
| [operator &lt;=(BigInteger, BigInteger)](BigInteger.op_LessThanOrEqual.zeOr33UeyJT8PRebY2m7tQ.md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(BigInteger, object)](BigInteger.op_LessThanOrEqual.DFcP5Tte1IqfqGvwVQ8ymQ.md 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger, object)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator &lt;=(object, BigInteger)](BigInteger.op_LessThanOrEqual.v5KNOtTmWRoal3MnEp83FA.md 'KeepCoding.BigInteger.op_LessThanOrEqual(object, KeepCoding.BigInteger)') | Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.<br/> |
| [operator %(BigInteger, BigInteger)](BigInteger.op_Modulus.wNLFZsyL.qoBtVBkNfJ4Bw.md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(BigInteger, object)](BigInteger.op_Modulus.pyFG.BfCWKtEmEckNgEtDA.md 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger, object)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator %(object, BigInteger)](BigInteger.op_Modulus.yF4ZjGoGEQivNO2WfhmF5g.md 'KeepCoding.BigInteger.op_Modulus(object, KeepCoding.BigInteger)') | Modulo operator; gets the modulo of 2 numbers.<br/> |
| [operator *(BigInteger, BigInteger)](BigInteger.op_Multiply.7.PUFW4MimlmjqzpXQGL4A.md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(BigInteger, object)](BigInteger.op_Multiply.u6BpcyYokG2Jx+SEQLmwWA.md 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger, object)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator *(object, BigInteger)](BigInteger.op_Multiply.iOiA7MdL1dxohyx7yRlVtw.md 'KeepCoding.BigInteger.op_Multiply(object, KeepCoding.BigInteger)') | Multiplication operator; gets the product of 2 numbers.<br/> |
| [operator -(BigInteger, BigInteger)](BigInteger.op_Subtraction.y+6GxTFKZvQVU3aAHKO2Vg.md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger, object)](BigInteger.op_Subtraction.dPMr0832JjkcdUrjaeHCdQ.md 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger, object)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(object, BigInteger)](BigInteger.op_Subtraction.tIAF3w3bciBa5tbZFkhx9Q.md 'KeepCoding.BigInteger.op_Subtraction(object, KeepCoding.BigInteger)') | Subtraction operator; gets the difference of 2 numbers.<br/> |
| [operator -(BigInteger)](BigInteger.op_UnaryNegation.mx+8ZKI9Ci4H+idF1psemA.md 'KeepCoding.BigInteger.op_UnaryNegation(KeepCoding.BigInteger)') | Negative operator; inverts [IsNegative](BigInteger.IsNegative.md 'KeepCoding.BigInteger.IsNegative').<br/> |
| [operator +(BigInteger)](BigInteger.op_UnaryPlus.OdaJxK7CiBTDiCKZQfv6CA.md 'KeepCoding.BigInteger.op_UnaryPlus(KeepCoding.BigInteger)') | Positive operator; returns itself.<br/> |
