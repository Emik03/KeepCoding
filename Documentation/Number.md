#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Number Class
Class meant to encapsulate a primitive numeric value.  
```csharp
public sealed class Number :
System.IComparable,
System.IFormattable,
System.IComparable<KeepCoding.Number>,
System.IEquatable<KeepCoding.Number>,
System.IComparable<System.ValueType>,
System.IEquatable<System.ValueType>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Number  

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Number](Number.md 'KeepCoding.Number')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Number](Number.md 'KeepCoding.Number')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [Number(byte)](Number..ctor.NVebn0CuAyxYQFMN73ycFw.md 'KeepCoding.Number.Number(byte)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').<br/> |
| [Number(decimal)](Number..ctor.9p8Cv4tPCF.Y5QnNlDTBng.md 'KeepCoding.Number.Number(decimal)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').<br/> |
| [Number(double)](Number..ctor.2leu04J8x8xb.KXMdWAbvg.md 'KeepCoding.Number.Number(double)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').<br/> |
| [Number(float)](Number..ctor.5+0F1MBgnYL6Bh9q1wHSZg.md 'KeepCoding.Number.Number(float)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').<br/> |
| [Number(int)](Number..ctor.9KiRLhmayXOs+XKkEPCVHQ.md 'KeepCoding.Number.Number(int)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').<br/> |
| [Number(long)](Number..ctor.EBOoA5Gxpr8zW+lqzYW3Fw.md 'KeepCoding.Number.Number(long)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').<br/> |
| [Number(sbyte)](Number..ctor.wdxtyKevH2.HvDM0LMhq4w.md 'KeepCoding.Number.Number(sbyte)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').<br/> |
| [Number(short)](Number..ctor.UzcRNTtViLi+ykX3iH0fBQ.md 'KeepCoding.Number.Number(short)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').<br/> |
| [Number(uint)](Number..ctor.xtgPVLe+XlZHOB5X9ZgHTA.md 'KeepCoding.Number.Number(uint)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').<br/> |
| [Number(ulong)](Number..ctor.AdtWnayghL9kRd9kBTonjw.md 'KeepCoding.Number.Number(ulong)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').<br/> |
| [Number(ushort)](Number..ctor.xcOVzbbJrZMxlUK06h11XQ.md 'KeepCoding.Number.Number(ushort)') | Creates a [Number](Number.md 'KeepCoding.Number') with the inner type [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').<br/> |

| Properties | |
| :--- | :--- |
| [Epsilon](Number.Epsilon.md 'KeepCoding.Number.Epsilon') | Returns the epsilon constant with precision based on the current type of the value.<br/> |
| [MaxValue](Number.MaxValue.md 'KeepCoding.Number.MaxValue') | Returns the biggest value of the current type of the value.<br/> |
| [MinValue](Number.MinValue.md 'KeepCoding.Number.MinValue') | Returns the smallest value of the current type of the value.<br/> |
| [NaN](Number.NaN.md 'KeepCoding.Number.NaN') | Returns the "not-a-number" constant.<br/> |
| [NegativeInfinity](Number.NegativeInfinity.md 'KeepCoding.Number.NegativeInfinity') | Returns the negative infinity constant.<br/> |
| [PositiveInfinity](Number.PositiveInfinity.md 'KeepCoding.Number.PositiveInfinity') | Returns the positive infinity constant.<br/> |

| Methods | |
| :--- | :--- |
| [Cast&lt;T&gt;()](Number.Cast.T.().md 'KeepCoding.Number.Cast&lt;T&gt;()') | Casts the [Number](Number.md 'KeepCoding.Number') into the numeric type. Unlike implicit casting, the value will trim the bytes that cannot occupy the new datatype, such as a number being too large or decimals.<br/> |
| [CompareTo(Number)](Number.CompareTo.Ad2OARdWlN+WLwiDh06lvQ.md 'KeepCoding.Number.CompareTo(KeepCoding.Number)') | Compares and determines the difference between both items.<br/> |
| [CompareTo(object)](Number.CompareTo.kdgeuAInk86nAmRANMabvw.md 'KeepCoding.Number.CompareTo(object)') | Compares and determines the difference between both items.<br/> |
| [CompareTo(ValueType)](Number.CompareTo.78MUZVKyrivqoA8qNCqo5A.md 'KeepCoding.Number.CompareTo(System.ValueType)') | Compares and determines the difference between both items.<br/> |
| [Equals(Number)](Number.Equals.f8WIvtg22T3ukD4hdAzRaQ.md 'KeepCoding.Number.Equals(KeepCoding.Number)') | Determines if both items are equal in value.<br/> |
| [Equals(object)](Number.Equals.WnSvHcs.1s9NDl.2GjnOyA.md 'KeepCoding.Number.Equals(object)') | Determines if both items are equal in value.<br/> |
| [Equals(ValueType)](Number.Equals.BChjAfLyCJW1Fdi7HivPUw.md 'KeepCoding.Number.Equals(System.ValueType)') | Determines if both items are equal in value.<br/> |
| [GetHashCode()](Number.GetHashCode().md 'KeepCoding.Number.GetHashCode()') | Determines the hash code of the item, based on the value.<br/> |
| [GetTypeCode()](Number.GetTypeCode().md 'KeepCoding.Number.GetTypeCode()') | Determines the type of value it currently is within the [System.TypeCode](https://docs.microsoft.com/en-us/dotnet/api/System.TypeCode 'System.TypeCode') enum.<br/> |
| [IsNaN()](Number.IsNaN().md 'KeepCoding.Number.IsNaN()') | Determines if the value is not a number.<br/> |
| [Modulo(Number)](Number.Modulo.teLHN2TmdMK7YocwCJ0Q4w.md 'KeepCoding.Number.Modulo(KeepCoding.Number)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [New&lt;T&gt;(T)](Number.New.yOwzApboITm5pkjb1Au0+g.md 'KeepCoding.Number.New&lt;T&gt;(T)') | Creates a new [Number](Number.md 'KeepCoding.Number') with the inner type being the type specified.<br/> |
| [Parse(string)](Number.Parse.Dtuv.1mYAyg7AxnI6Ct9ow.md 'KeepCoding.Number.Parse(string)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles)](Number.Parse.7KYZBz7soXSh.88QQgtknQ.md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles, NumberFormatInfo)](Number.Parse.H05sPgtN0xQ9f.kWzmwoWA.md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles, IFormatProvider)](Number.Parse.tY4FvsgPDvL5q9Tj4gTNFA.md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles, System.IFormatProvider)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, IFormatProvider)](Number.Parse.UH5lqie.MejZi5007BxwHw.md 'KeepCoding.Number.Parse(string, System.IFormatProvider)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [ToString()](Number.ToString().md 'KeepCoding.Number.ToString()') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string)](Number.ToString.qVw+kp7U78SBWDaLdbPatA.md 'KeepCoding.Number.ToString(string)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string, NumberFormatInfo)](Number.ToString.BajDmvbp99EDE5XJKWvDFw.md 'KeepCoding.Number.ToString(string, System.Globalization.NumberFormatInfo)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string, IFormatProvider)](Number.ToString.rn4YDlSE1LiDhnNbr27KvA.md 'KeepCoding.Number.ToString(string, System.IFormatProvider)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(IFormatProvider)](Number.ToString.tz0b.Z2MZnobDA3kiKwe3A.md 'KeepCoding.Number.ToString(System.IFormatProvider)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [TryParse(string, Number)](Number.TryParse.fGai3lC0S3Mxc1+g7tmvMg.md 'KeepCoding.Number.TryParse(string, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number').<br/> |
| [TryParse(string, NumberStyles, NumberFormatInfo, Number)](Number.TryParse.zIVfq3McgGpR7DVuHV.OsQ.md 'KeepCoding.Number.TryParse(string, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number').<br/> |
| [TryParse(string, NumberStyles, IFormatProvider, Number)](Number.TryParse.kUqd1qkkhI6t+z5GmSCcRg.md 'KeepCoding.Number.TryParse(string, System.Globalization.NumberStyles, System.IFormatProvider, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](Number.md 'KeepCoding.Number').<br/> |

| Operators | |
| :--- | :--- |
| [operator +(Number, Number)](Number.op_Addition.lqO4WpJY2Ah5I3T1H.bKJA.md 'KeepCoding.Number.op_Addition(KeepCoding.Number, KeepCoding.Number)') | Add operator.<br/> |
| [operator &(Number, Number)](Number.op_BitwiseAnd.16CvW9Q5+q68vvGtttGVWQ.md 'KeepCoding.Number.op_BitwiseAnd(KeepCoding.Number, KeepCoding.Number)') | And operator.<br/> |
| [operator |(Number, Number)](Number.op_BitwiseOr.yE3j7Dz3CRv9j.W99E4YBQ.md 'KeepCoding.Number.op_BitwiseOr(KeepCoding.Number, KeepCoding.Number)') | Or operator.<br/> |
| [operator --(Number)](Number.op_Decrement.rmSarnVSn5+ZvZCGtP3VFw.md 'KeepCoding.Number.op_Decrement(KeepCoding.Number)') | Decrement operator.<br/> |
| [operator /(Number, Number)](Number.op_Division.ftW3LDB3YI1KiieB63FH3Q.md 'KeepCoding.Number.op_Division(KeepCoding.Number, KeepCoding.Number)') | Divide operator.<br/> |
| [operator ==(Number, Number)](Number.op_Equality.0plP0Cekhzlk8d863Aqzdg.md 'KeepCoding.Number.op_Equality(KeepCoding.Number, KeepCoding.Number)') | Equals operator.<br/> |
| [operator ==(Number, ValueType)](Number.op_Equality.MRP84jTe.UwKuidIyLlrsQ.md 'KeepCoding.Number.op_Equality(KeepCoding.Number, System.ValueType)') | Equals operator.<br/> |
| [operator ^(Number, Number)](Number.op_ExclusiveOr..fQkM6aXeVgUr3Wy3QO5hQ.md 'KeepCoding.Number.op_ExclusiveOr(KeepCoding.Number, KeepCoding.Number)') | Xor operator.<br/> |
| [explicit operator bool(Number)](Number.op_Explicit.uOPwf+5Jett3+S+YltvXwg.md 'KeepCoding.Number.op_Explicit bool(KeepCoding.Number)') | Explicitly converts the value to a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean').<br/> |
| [operator false(Number)](Number.op_False.DjqcapJ.CS51GxlGgJvL7Q.md 'KeepCoding.Number.op_False(KeepCoding.Number)') | False operator.<br/> |
| [operator &gt;(Number, Number)](Number.op_GreaterThan.MNs2RRQBLVvbknZsLqMKSA.md 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number, KeepCoding.Number)') | More than operator.<br/> |
| [operator &gt;(Number, ValueType)](Number.op_GreaterThan.to0Cfyag41zjR14co5m6mQ.md 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number, System.ValueType)') | More than operator.<br/> |
| [operator &gt;=(Number, Number)](Number.op_GreaterThanOrEqual.nMRI.9m1W6vUqAY0wl.JRQ.md 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number, KeepCoding.Number)') | More than or equal operator.<br/> |
| [operator &gt;=(Number, ValueType)](Number.op_GreaterThanOrEqual.lew70dMSh3hkA2Q.eszmyA.md 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number, System.ValueType)') | More than or equals operator.<br/> |
| [implicit operator byte(Number)](Number.op_Implicit.yq46QL1uR2qoKNBMGCW2fA.md 'KeepCoding.Number.op_Implicit byte(KeepCoding.Number)') | Implicitly converts the value to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').<br/> |
| [implicit operator decimal(Number)](Number.op_Implicit.uLJJJ5XXc.p3oozvN60O6Q.md 'KeepCoding.Number.op_Implicit decimal(KeepCoding.Number)') | Implicitly converts the value to a [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').<br/> |
| [implicit operator double(Number)](Number.op_Implicit.0MXIAM3iKNeFsHd6q2VOEA.md 'KeepCoding.Number.op_Implicit double(KeepCoding.Number)') | Implicitly converts the value to a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').<br/> |
| [implicit operator float(Number)](Number.op_Implicit.klQLeXHbUmnGfwI1gAhATA.md 'KeepCoding.Number.op_Implicit float(KeepCoding.Number)') | Implicitly converts the value to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').<br/> |
| [implicit operator int(Number)](Number.op_Implicit.FnF8Tj4jlEKO6pprSl1aYg.md 'KeepCoding.Number.op_Implicit int(KeepCoding.Number)') | Implicitly converts the value to a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').<br/> |
| [implicit operator Number(byte)](Number.op_Implicit.zhITFq0m.e6FeFI8Ye1m.g.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(byte)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(decimal)](Number.op_Implicit.+MEuubMMuon90vXrOTDfuw.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(decimal)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(double)](Number.op_Implicit.ASKSoiRcdEUO.ydBBq+KVg.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(double)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(float)](Number.op_Implicit.oliuH7q9SxQ3NoBRz91t7g.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(float)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(int)](Number.op_Implicit.CeSaKFJKWmLGyYDsvIIc6g.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(int)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(long)](Number.op_Implicit.mfqQ3IMkTHJ1a.aJxQTNlw.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(long)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(sbyte)](Number.op_Implicit.Ul11c+0ODTqA1MZu1P2Cww.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(sbyte)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(short)](Number.op_Implicit.Q9pKbtM1pc4a22Wbn7aN7Q.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(short)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(uint)](Number.op_Implicit.3KIUW42MDWQuS86+tTmGlg.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(uint)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(ulong)](Number.op_Implicit.b7UqUsHJ5KDjIVgxaZIyUQ.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(ulong)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(ushort)](Number.op_Implicit.fUr8bl5e3TXwGV+RoC.QdA.md 'KeepCoding.Number.op_Implicit KeepCoding.Number(ushort)') | Implicitly converts the value to a [Number](Number.md 'KeepCoding.Number').<br/> |
| [implicit operator long(Number)](Number.op_Implicit.dqrf.ywWIAdXgj8UpNnkIQ.md 'KeepCoding.Number.op_Implicit long(KeepCoding.Number)') | Implicitly converts the value to a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').<br/> |
| [implicit operator sbyte(Number)](Number.op_Implicit.DD+oH5zxuIzyna4uZ96UZg.md 'KeepCoding.Number.op_Implicit sbyte(KeepCoding.Number)') | Implicitly converts the value to a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').<br/> |
| [implicit operator short(Number)](Number.op_Implicit.RBW5iDRxlvA3bztZTQecUA.md 'KeepCoding.Number.op_Implicit short(KeepCoding.Number)') | Implicitly converts the value to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').<br/> |
| [implicit operator ValueType(Number)](Number.op_Implicit.dIekkbHrzpQGd0vTCWyvIA.md 'KeepCoding.Number.op_Implicit System.ValueType(KeepCoding.Number)') | Implicitly converts the value to a [System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType').<br/> |
| [implicit operator uint(Number)](Number.op_Implicit.aWPmBTMQit3TQTyDVJg7Tg.md 'KeepCoding.Number.op_Implicit uint(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').<br/> |
| [implicit operator ulong(Number)](Number.op_Implicit.sgMKRdIqn7BX7lgRRu+q3Q.md 'KeepCoding.Number.op_Implicit ulong(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').<br/> |
| [implicit operator ushort(Number)](Number.op_Implicit.CU2hf7hj3nZwW9jgmDCpAQ.md 'KeepCoding.Number.op_Implicit ushort(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').<br/> |
| [operator ++(Number)](Number.op_Increment.4MZTmUENHXNTZtEdBq6YXw.md 'KeepCoding.Number.op_Increment(KeepCoding.Number)') | Increment operator.<br/> |
| [operator !=(Number, Number)](Number.op_Inequality.shb66ouCMTcRLJ4Y23+wpg.md 'KeepCoding.Number.op_Inequality(KeepCoding.Number, KeepCoding.Number)') | Equals operator.<br/> |
| [operator !=(Number, ValueType)](Number.op_Inequality.WVVMqzFz6SShICwzAy8BOg.md 'KeepCoding.Number.op_Inequality(KeepCoding.Number, System.ValueType)') | Equals operator.<br/> |
| [operator &lt;&lt;(Number, int)](Number.op_LeftShift.qeUffegTlgavZ4GTu+XFRQ.md 'KeepCoding.Number.op_LeftShift(KeepCoding.Number, int)') | Left shift operator.<br/> |
| [operator &lt;(Number, Number)](Number.op_LessThan.jeyNEKfsRobcs2lkklRaAw.md 'KeepCoding.Number.op_LessThan(KeepCoding.Number, KeepCoding.Number)') | Less than operator.<br/> |
| [operator &lt;(Number, ValueType)](Number.op_LessThan.UjFCpS+4gvn5FpFVfuDMSg.md 'KeepCoding.Number.op_LessThan(KeepCoding.Number, System.ValueType)') | Less than operator.<br/> |
| [operator &lt;=(Number, Number)](Number.op_LessThanOrEqual.AhjS3k1h63wltu1GGLS7Vw.md 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number, KeepCoding.Number)') | Less than or equal operator.<br/> |
| [operator &lt;=(Number, ValueType)](Number.op_LessThanOrEqual.UvXK38wsFWetOIclCkj3iQ.md 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number, System.ValueType)') | Less than or equal operator.<br/> |
| [operator %(Number, Number)](Number.op_Modulus.UMjm6cI.rm+CHNu46QNdTQ.md 'KeepCoding.Number.op_Modulus(KeepCoding.Number, KeepCoding.Number)') | Modulo operator.<br/> |
| [operator *(Number, Number)](Number.op_Multiply.24eArVoqXMwJyKwOzlqa8A.md 'KeepCoding.Number.op_Multiply(KeepCoding.Number, KeepCoding.Number)') | Multiply operator.<br/> |
| [operator ~(Number)](Number.op_OnesComplement.YJL+qSs6uogd9dqbNTm0PA.md 'KeepCoding.Number.op_OnesComplement(KeepCoding.Number)') | Tilde operator.<br/> |
| [operator &gt;&gt;(Number, int)](Number.op_RightShift.RKawtiBwuEv65QwT0J+2Ag.md 'KeepCoding.Number.op_RightShift(KeepCoding.Number, int)') | Right shift operator.<br/> |
| [operator -(Number, Number)](Number.op_Subtraction.yOd.x930tsv1gefXW910SQ.md 'KeepCoding.Number.op_Subtraction(KeepCoding.Number, KeepCoding.Number)') | Subtract operator.<br/> |
| [operator true(Number)](Number.op_True.Xo.fXfyhWJiohVjDH.QEdw.md 'KeepCoding.Number.op_True(KeepCoding.Number)') | True operator.<br/> |
| [operator -(Number)](Number.op_UnaryNegation.eJYl3JszLjOG8TK1cD.RdQ.md 'KeepCoding.Number.op_UnaryNegation(KeepCoding.Number)') | Minus operator.<br/> |
| [operator +(Number)](Number.op_UnaryPlus.wfP2ruH32WoFg02pUAlbKQ.md 'KeepCoding.Number.op_UnaryPlus(KeepCoding.Number)') | Plus operator.<br/> |
