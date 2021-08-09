#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## BigInt Struct
Encapsulates an arbitrary-size integer.  
```csharp
public struct BigInt :
System.IComparable<KeepCoding.BigInt>,
System.IEquatable<KeepCoding.BigInt>
```

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[BigInt](BigInt.md 'KeepCoding.BigInt')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[BigInt](BigInt.md 'KeepCoding.BigInt')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Remarks
This struct has been written by Timwi. [https://github.com/Timwi/](https://github.com/Timwi/ 'https://github.com/Timwi/')

| Constructors | |
| :--- | :--- |
| [BigInt(int)](BigInt..ctor.GgSbrUys5pMs8H88IMzDkg.md 'KeepCoding.BigInt.BigInt(int)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 32-bit signed integer.<br/> |
| [BigInt(long)](BigInt..ctor.96ILF1CmGF0oGZUWq0EXMw.md 'KeepCoding.BigInt.BigInt(long)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 64-bit signed integer.<br/> |
| [BigInt(uint)](BigInt..ctor.13BGELPxDbJ+hdgx0EY8Lg.md 'KeepCoding.BigInt.BigInt(uint)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 32-bit signed integer.<br/> |
| [BigInt(ulong)](BigInt..ctor.7GzRACSzroCvDGmOO7gfEw.md 'KeepCoding.BigInt.BigInt(ulong)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 64-bit unsigned integer.<br/> |

| Properties | |
| :--- | :--- |
| [AbsoluteValue](BigInt.AbsoluteValue.md 'KeepCoding.BigInt.AbsoluteValue') | Returns the absolute value. |
| [Inverse](BigInt.Inverse.md 'KeepCoding.BigInt.Inverse') | Returns the bitwise inverse (bitwise NOT).<br/> |
| [IsZero](BigInt.IsZero.md 'KeepCoding.BigInt.IsZero') | Determines whether the integer is 0.<br/> |
| [MostSignificantBit](BigInt.MostSignificantBit.md 'KeepCoding.BigInt.MostSignificantBit') | Returns the bit-index of the most significant bit in this number. If the number is positive, this is the index of the most significant ‘1’ bit. If the number is negative, it is the index of the most significant ‘0’ bit. If the number is zero, the result is `-1`.<br/> |
| [Negative](BigInt.Negative.md 'KeepCoding.BigInt.Negative') | Returns the negative value.<br/> |
| [Sign](BigInt.Sign.md 'KeepCoding.BigInt.Sign') | Returns the sign of the number: −1 for negative numbers, 0 for zero, and 1 for positive numbers.<br/> |

| Methods | |
| :--- | :--- |
| [Add(BigInt)](BigInt.Add.bH4EWXhJ5al8to7Bv.XV3A.md 'KeepCoding.BigInt.Add(KeepCoding.BigInt)') | Returns the sum of this integer plus [other](BigInt.Add.bH4EWXhJ5al8to7Bv.XV3A.md#KeepCoding.BigInt.Add(KeepCoding.BigInt).other 'KeepCoding.BigInt.Add(KeepCoding.BigInt).other').<br/> |
| [CompareTo(BigInt)](BigInt.CompareTo.rqGRZbUbna.vdy6NszgzkQ.md 'KeepCoding.BigInt.CompareTo(KeepCoding.BigInt)') | Compares this integer to [other](BigInt.CompareTo.rqGRZbUbna.vdy6NszgzkQ.md#KeepCoding.BigInt.CompareTo(KeepCoding.BigInt).other 'KeepCoding.BigInt.CompareTo(KeepCoding.BigInt).other').<br/> |
| [Divide(BigInt)](BigInt.Divide.Tj+33o..jQkItwvaPt2hPQ.md 'KeepCoding.BigInt.Divide(KeepCoding.BigInt)') | Returns the quotient obtained by dividing this integer by [other](BigInt.Divide.Tj+33o..jQkItwvaPt2hPQ.md#KeepCoding.BigInt.Divide(KeepCoding.BigInt).other 'KeepCoding.BigInt.Divide(KeepCoding.BigInt).other').<br/> |
| [DivideModulo(BigInt)](BigInt.DivideModulo.hKNytB2JMgJyLX17vZnr3Q.md 'KeepCoding.BigInt.DivideModulo(KeepCoding.BigInt)') | Calculates a quotient and remainder by dividing this integer by [other](BigInt.DivideModulo.hKNytB2JMgJyLX17vZnr3Q.md#KeepCoding.BigInt.DivideModulo(KeepCoding.BigInt).other 'KeepCoding.BigInt.DivideModulo(KeepCoding.BigInt).other').<br/> |
| [Equals(BigInt)](BigInt.Equals.z9hX7TQe9Z2sVLNi.8zbPg.md 'KeepCoding.BigInt.Equals(KeepCoding.BigInt)') | Equality comparison.<br/> |
| [Equals(object)](BigInt.Equals.5Ojuqo5l7af9VYeu3fJn5g.md 'KeepCoding.BigInt.Equals(object)') | Equality comparison.<br/> |
| [GetBit(int)](BigInt.GetBit.oTqEE9Kz73+bDeqztoytlw.md 'KeepCoding.BigInt.GetBit(int)') | Returns whether the bit at [index](BigInt.GetBit.oTqEE9Kz73+bDeqztoytlw.md#KeepCoding.BigInt.GetBit(int).index 'KeepCoding.BigInt.GetBit(int).index') is 1 (regardless of the integer’s sign).<br/> |
| [GetHashCode()](BigInt.GetHashCode().md 'KeepCoding.BigInt.GetHashCode()') | Hash code function.<br/> |
| [Modulo(BigInt)](BigInt.Modulo.bLrlGdip1uw394Nftl4mog.md 'KeepCoding.BigInt.Modulo(KeepCoding.BigInt)') | Returns the remainder obtained when dividing this integer by [other](BigInt.Modulo.bLrlGdip1uw394Nftl4mog.md#KeepCoding.BigInt.Modulo(KeepCoding.BigInt).other 'KeepCoding.BigInt.Modulo(KeepCoding.BigInt).other').<br/> |
| [Multiply(BigInt)](BigInt.Multiply.GhV119JihWCLnmq3rx1g6Q.md 'KeepCoding.BigInt.Multiply(KeepCoding.BigInt)') | Returns the product of this integer times [other](BigInt.Multiply.GhV119JihWCLnmq3rx1g6Q.md#KeepCoding.BigInt.Multiply(KeepCoding.BigInt).other 'KeepCoding.BigInt.Multiply(KeepCoding.BigInt).other').<br/> |
| [Parse(string)](BigInt.Parse.HydzVomzJEhU9NgLdSS7yg.md 'KeepCoding.BigInt.Parse(string)') | Parses a numerical string (consisting only of digits `0` to `9`, optionally prepended with a `-`) into a [BigInt](BigInt.md 'KeepCoding.BigInt').<br/> |
| [ToString()](BigInt.ToString().md 'KeepCoding.BigInt.ToString()') | Override; see base.<br/> |
| [TryParse(string, BigInt)](BigInt.TryParse.qVIeTvpRH9QsyakpZVwNUw.md 'KeepCoding.BigInt.TryParse(string, KeepCoding.BigInt)') | Parses a numerical string (consisting only of digits `0` to `9`, optionally prepended with a `-`) into a [BigInt](BigInt.md 'KeepCoding.BigInt').<br/> |

| Operators | |
| :--- | :--- |
| [operator +(BigInt, BigInt)](BigInt.op_Addition.D.J0vnGVuqcq5eESKWmOWg.md 'KeepCoding.BigInt.op_Addition(KeepCoding.BigInt, KeepCoding.BigInt)') | Returns the sum of [one](BigInt.op_Addition.D.J0vnGVuqcq5eESKWmOWg.md#KeepCoding.BigInt.op_Addition(KeepCoding.BigInt.KeepCoding.BigInt).one 'KeepCoding.BigInt.op_Addition(KeepCoding.BigInt, KeepCoding.BigInt).one') plus [two](BigInt.op_Addition.D.J0vnGVuqcq5eESKWmOWg.md#KeepCoding.BigInt.op_Addition(KeepCoding.BigInt.KeepCoding.BigInt).two 'KeepCoding.BigInt.op_Addition(KeepCoding.BigInt, KeepCoding.BigInt).two').<br/> |
| [operator &(BigInt, BigInt)](BigInt.op_BitwiseAnd.9i9gcTNq.TlTZorCZ77wCQ.md 'KeepCoding.BigInt.op_BitwiseAnd(KeepCoding.BigInt, KeepCoding.BigInt)') | Bitwise and operator. |
| [operator |(BigInt, BigInt)](BigInt.op_BitwiseOr.pKMpwzupbk3ah4S4S6wDBg.md 'KeepCoding.BigInt.op_BitwiseOr(KeepCoding.BigInt, KeepCoding.BigInt)') | Bitwise or operator.<br/> |
| [operator --(BigInt)](BigInt.op_Decrement.hVegHTP9Bd4oz8lbzViL6A.md 'KeepCoding.BigInt.op_Decrement(KeepCoding.BigInt)') | Decrement operator.<br/> |
| [operator /(BigInt, BigInt)](BigInt.op_Division.mZ+ZayRGaTZkjmfHrF0hrQ.md 'KeepCoding.BigInt.op_Division(KeepCoding.BigInt, KeepCoding.BigInt)') | Returns the quotient obtained by dividing [one](BigInt.op_Division.mZ+ZayRGaTZkjmfHrF0hrQ.md#KeepCoding.BigInt.op_Division(KeepCoding.BigInt.KeepCoding.BigInt).one 'KeepCoding.BigInt.op_Division(KeepCoding.BigInt, KeepCoding.BigInt).one') by [two](BigInt.op_Division.mZ+ZayRGaTZkjmfHrF0hrQ.md#KeepCoding.BigInt.op_Division(KeepCoding.BigInt.KeepCoding.BigInt).two 'KeepCoding.BigInt.op_Division(KeepCoding.BigInt, KeepCoding.BigInt).two').<br/> |
| [operator ==(BigInt, BigInt)](BigInt.op_Equality.KOVQ7+iw.fm.VMDkPbUuMQ.md 'KeepCoding.BigInt.op_Equality(KeepCoding.BigInt, KeepCoding.BigInt)') | Equality comparison operator.<br/> |
| [operator ^(BigInt, BigInt)](BigInt.op_ExclusiveOr.dYzmYhItKGUCIgzCfP68iw.md 'KeepCoding.BigInt.op_ExclusiveOr(KeepCoding.BigInt, KeepCoding.BigInt)') | Bitwise xor operator.<br/> |
| [operator &gt;(BigInt, BigInt)](BigInt.op_GreaterThan.dMJEKncvkdJVLnMXYm8peQ.md 'KeepCoding.BigInt.op_GreaterThan(KeepCoding.BigInt, KeepCoding.BigInt)') | Greater-than comparison operator.<br/> |
| [operator &gt;=(BigInt, BigInt)](BigInt.op_GreaterThanOrEqual.eEGosBkcG3JWtolr2E04YQ.md 'KeepCoding.BigInt.op_GreaterThanOrEqual(KeepCoding.BigInt, KeepCoding.BigInt)') | Greater-than-or-equal-to comparison operator.<br/> |
| [implicit operator BigInt(byte)](BigInt.op_Implicit.50U5j.YAwAuQkFBdCvacuA.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(byte)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from an 8-bit unsigned integer.<br/> |
| [implicit operator BigInt(int)](BigInt.op_Implicit.+nJaveO6FWjHd.iQJY3hWQ.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(int)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 32-bit signed integer.<br/> |
| [implicit operator BigInt(long)](BigInt.op_Implicit.A1k74SvWxC8sD3HNp2WWjw.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(long)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 64-bit signed integer.<br/> |
| [implicit operator BigInt(sbyte)](BigInt.op_Implicit.EBb0l8b1yDKvFVJrasDohg.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(sbyte)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from an 8-bit signed integer.<br/> |
| [implicit operator BigInt(short)](BigInt.op_Implicit.K6CNHo+cnC8hHpB+nkG6QQ.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(short)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 16-bit unsigned integer.<br/> |
| [implicit operator BigInt(uint)](BigInt.op_Implicit.M+qZKJq+9a+tdniCmLckhg.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(uint)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 32-bit unsigned integer.<br/> |
| [implicit operator BigInt(ulong)](BigInt.op_Implicit.8LowTV9Xe.JH6eSEajJ8eg.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(ulong)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 64-bit unsigned integer.<br/> |
| [implicit operator BigInt(ushort)](BigInt.op_Implicit.iZqN2asORAY7BCij7OI0Pg.md 'KeepCoding.BigInt.op_Implicit KeepCoding.BigInt(ushort)') | Constructs a [BigInt](BigInt.md 'KeepCoding.BigInt') from a 16-bit signed integer.<br/> |
| [operator ++(BigInt)](BigInt.op_Increment.HuL1RQUoG6IeTJEDvBUxXg.md 'KeepCoding.BigInt.op_Increment(KeepCoding.BigInt)') | Increment operator.<br/> |
| [operator !=(BigInt, BigInt)](BigInt.op_Inequality.93FdPKIeHuGQ1+egRRMkyg.md 'KeepCoding.BigInt.op_Inequality(KeepCoding.BigInt, KeepCoding.BigInt)') | Inequality comparison operator.<br/> |
| [operator &lt;&lt;(BigInt, int)](BigInt.op_LeftShift.NsCpCnLRSBsnDqX+Wjeg9A.md 'KeepCoding.BigInt.op_LeftShift(KeepCoding.BigInt, int)') | Returns the result of a bit-shift-left by the specified [amount](BigInt.op_LeftShift.NsCpCnLRSBsnDqX+Wjeg9A.md#KeepCoding.BigInt.op_LeftShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_LeftShift(KeepCoding.BigInt, int).amount'). This is equivalent to multiply by 2 to the power of [amount](BigInt.op_LeftShift.NsCpCnLRSBsnDqX+Wjeg9A.md#KeepCoding.BigInt.op_LeftShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_LeftShift(KeepCoding.BigInt, int).amount'). |
| [operator &lt;(BigInt, BigInt)](BigInt.op_LessThan.1e9j3tV4wraoUqVUAx7qig.md 'KeepCoding.BigInt.op_LessThan(KeepCoding.BigInt, KeepCoding.BigInt)') | Less-than comparison operator.<br/> |
| [operator &lt;=(BigInt, BigInt)](BigInt.op_LessThanOrEqual..xsF1z0tNtOcOs4+CbTRbA.md 'KeepCoding.BigInt.op_LessThanOrEqual(KeepCoding.BigInt, KeepCoding.BigInt)') | Less-than-or-equal-to comparison operator.<br/> |
| [operator %(BigInt, BigInt)](BigInt.op_Modulus.oHGRGhvZsYP3gn4ID0a34w.md 'KeepCoding.BigInt.op_Modulus(KeepCoding.BigInt, KeepCoding.BigInt)') | Returns the remainder obtained when dividing [one](BigInt.op_Modulus.oHGRGhvZsYP3gn4ID0a34w.md#KeepCoding.BigInt.op_Modulus(KeepCoding.BigInt.KeepCoding.BigInt).one 'KeepCoding.BigInt.op_Modulus(KeepCoding.BigInt, KeepCoding.BigInt).one') by [two](BigInt.op_Modulus.oHGRGhvZsYP3gn4ID0a34w.md#KeepCoding.BigInt.op_Modulus(KeepCoding.BigInt.KeepCoding.BigInt).two 'KeepCoding.BigInt.op_Modulus(KeepCoding.BigInt, KeepCoding.BigInt).two').<br/> |
| [operator *(BigInt, BigInt)](BigInt.op_Multiply.G.2KzlU.rtnGVj8O4fsXOg.md 'KeepCoding.BigInt.op_Multiply(KeepCoding.BigInt, KeepCoding.BigInt)') | Returns the product of [one](BigInt.op_Multiply.G.2KzlU.rtnGVj8O4fsXOg.md#KeepCoding.BigInt.op_Multiply(KeepCoding.BigInt.KeepCoding.BigInt).one 'KeepCoding.BigInt.op_Multiply(KeepCoding.BigInt, KeepCoding.BigInt).one') times [two](BigInt.op_Multiply.G.2KzlU.rtnGVj8O4fsXOg.md#KeepCoding.BigInt.op_Multiply(KeepCoding.BigInt.KeepCoding.BigInt).two 'KeepCoding.BigInt.op_Multiply(KeepCoding.BigInt, KeepCoding.BigInt).two').<br/> |
| [operator ~(BigInt)](BigInt.op_OnesComplement.ms6Y202pSALkc9pVLGv.BQ.md 'KeepCoding.BigInt.op_OnesComplement(KeepCoding.BigInt)') | Returns the bitwise inverse (bitwise NOT).<br/> |
| [operator &gt;&gt;(BigInt, int)](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int)') | Returns the result of a bit-shift-right by the specified [amount](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md#KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int).amount'). This is equivalent to dividing by 2 to the power of [amount](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md#KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int).amount') and rounding down. |
| [operator -(BigInt, BigInt)](BigInt.op_Subtraction.LpJBIo2nZ8GpQOkwVCWm5Q.md 'KeepCoding.BigInt.op_Subtraction(KeepCoding.BigInt, KeepCoding.BigInt)') | Returns the difference of [one](BigInt.op_Subtraction.LpJBIo2nZ8GpQOkwVCWm5Q.md#KeepCoding.BigInt.op_Subtraction(KeepCoding.BigInt.KeepCoding.BigInt).one 'KeepCoding.BigInt.op_Subtraction(KeepCoding.BigInt, KeepCoding.BigInt).one') minus [two](BigInt.op_Subtraction.LpJBIo2nZ8GpQOkwVCWm5Q.md#KeepCoding.BigInt.op_Subtraction(KeepCoding.BigInt.KeepCoding.BigInt).two 'KeepCoding.BigInt.op_Subtraction(KeepCoding.BigInt, KeepCoding.BigInt).two').<br/> |
| [operator -(BigInt)](BigInt.op_UnaryNegation.y.pxIMMVIVJwxFs6yVolWA.md 'KeepCoding.BigInt.op_UnaryNegation(KeepCoding.BigInt)') | Returns the negative value.<br/> |
| [operator +(BigInt)](BigInt.op_UnaryPlus.TM2Vg1EAUR0hRwf7HiSYQA.md 'KeepCoding.BigInt.op_UnaryPlus(KeepCoding.BigInt)') | Returns the operand.<br/> |
