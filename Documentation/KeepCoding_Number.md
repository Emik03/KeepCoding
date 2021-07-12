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

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Number](KeepCoding_Number.md 'KeepCoding.Number')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Number](KeepCoding_Number.md 'KeepCoding.Number')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [Number(byte)](KeepCoding_Number_Number(byte).md 'KeepCoding.Number.Number(byte)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').<br/> |
| [Number(decimal)](KeepCoding_Number_Number(decimal).md 'KeepCoding.Number.Number(decimal)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').<br/> |
| [Number(double)](KeepCoding_Number_Number(double).md 'KeepCoding.Number.Number(double)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').<br/> |
| [Number(float)](KeepCoding_Number_Number(float).md 'KeepCoding.Number.Number(float)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').<br/> |
| [Number(int)](KeepCoding_Number_Number(int).md 'KeepCoding.Number.Number(int)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').<br/> |
| [Number(long)](KeepCoding_Number_Number(long).md 'KeepCoding.Number.Number(long)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').<br/> |
| [Number(sbyte)](KeepCoding_Number_Number(sbyte).md 'KeepCoding.Number.Number(sbyte)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').<br/> |
| [Number(short)](KeepCoding_Number_Number(short).md 'KeepCoding.Number.Number(short)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').<br/> |
| [Number(uint)](KeepCoding_Number_Number(uint).md 'KeepCoding.Number.Number(uint)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').<br/> |
| [Number(ulong)](KeepCoding_Number_Number(ulong).md 'KeepCoding.Number.Number(ulong)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').<br/> |
| [Number(ushort)](KeepCoding_Number_Number(ushort).md 'KeepCoding.Number.Number(ushort)') | Creates a [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').<br/> |

| Properties | |
| :--- | :--- |
| [Epsilon](KeepCoding_Number_Epsilon.md 'KeepCoding.Number.Epsilon') |  |
| [MaxValue](KeepCoding_Number_MaxValue.md 'KeepCoding.Number.MaxValue') |  |
| [MinValue](KeepCoding_Number_MinValue.md 'KeepCoding.Number.MinValue') |  |
| [NaN](KeepCoding_Number_NaN.md 'KeepCoding.Number.NaN') |  |
| [NegativeInfinity](KeepCoding_Number_NegativeInfinity.md 'KeepCoding.Number.NegativeInfinity') |  |
| [PositiveInfinity](KeepCoding_Number_PositiveInfinity.md 'KeepCoding.Number.PositiveInfinity') |  |

| Methods | |
| :--- | :--- |
| [Cast&lt;T&gt;()](KeepCoding_Number_Cast_T_().md 'KeepCoding.Number.Cast&lt;T&gt;()') | Casts the [Number](KeepCoding_Number.md 'KeepCoding.Number') into the numeric type. Unlike implicit casting, the value will trim the bytes that cannot occupy the new datatype, such as a number being too large or decimals.<br/> |
| [CompareTo(Number)](KeepCoding_Number_CompareTo(KeepCoding_Number).md 'KeepCoding.Number.CompareTo(KeepCoding.Number)') | Compares and determines the difference between both items.<br/> |
| [CompareTo(object)](KeepCoding_Number_CompareTo(object).md 'KeepCoding.Number.CompareTo(object)') | Compares and determines the difference between both items.<br/> |
| [CompareTo(ValueType)](KeepCoding_Number_CompareTo(System_ValueType).md 'KeepCoding.Number.CompareTo(System.ValueType)') | Compares and determines the difference between both items.<br/> |
| [Equals(Number)](KeepCoding_Number_Equals(KeepCoding_Number).md 'KeepCoding.Number.Equals(KeepCoding.Number)') | Determines if both items are equal in value.<br/> |
| [Equals(object)](KeepCoding_Number_Equals(object).md 'KeepCoding.Number.Equals(object)') | Determines if both items are equal in value.<br/> |
| [Equals(ValueType)](KeepCoding_Number_Equals(System_ValueType).md 'KeepCoding.Number.Equals(System.ValueType)') | Determines if both items are equal in value.<br/> |
| [GetHashCode()](KeepCoding_Number_GetHashCode().md 'KeepCoding.Number.GetHashCode()') | Determines the hash code of the item, based on the value.<br/> |
| [GetTypeCode()](KeepCoding_Number_GetTypeCode().md 'KeepCoding.Number.GetTypeCode()') | Determines the type of value it currently is within the [System.TypeCode](https://docs.microsoft.com/en-us/dotnet/api/System.TypeCode 'System.TypeCode') enum.<br/> |
| [IsNaN()](KeepCoding_Number_IsNaN().md 'KeepCoding.Number.IsNaN()') | Determines if the value is not a number.<br/> |
| [Modulo(Number)](KeepCoding_Number_Modulo(KeepCoding_Number).md 'KeepCoding.Number.Modulo(KeepCoding.Number)') | Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.<br/> |
| [New&lt;T&gt;(T)](KeepCoding_Number_New_T_(T).md 'KeepCoding.Number.New&lt;T&gt;(T)') | Creates a new [Number](KeepCoding_Number.md 'KeepCoding.Number') with the inner type being the type specified.<br/> |
| [Parse(string)](KeepCoding_Number_Parse(string).md 'KeepCoding.Number.Parse(string)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles)](KeepCoding_Number_Parse(string_System_Globalization_NumberStyles).md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles, NumberFormatInfo)](KeepCoding_Number_Parse(string_System_Globalization_NumberStyles_System_Globalization_NumberFormatInfo).md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, NumberStyles, IFormatProvider)](KeepCoding_Number_Parse(string_System_Globalization_NumberStyles_System_IFormatProvider).md 'KeepCoding.Number.Parse(string, System.Globalization.NumberStyles, System.IFormatProvider)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [Parse(string, IFormatProvider)](KeepCoding_Number_Parse(string_System_IFormatProvider).md 'KeepCoding.Number.Parse(string, System.IFormatProvider)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number'). An exception is thrown if it fails.<br/> |
| [ToString()](KeepCoding_Number_ToString().md 'KeepCoding.Number.ToString()') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string)](KeepCoding_Number_ToString(string).md 'KeepCoding.Number.ToString(string)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string, NumberFormatInfo)](KeepCoding_Number_ToString(string_System_Globalization_NumberFormatInfo).md 'KeepCoding.Number.ToString(string, System.Globalization.NumberFormatInfo)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(string, IFormatProvider)](KeepCoding_Number_ToString(string_System_IFormatProvider).md 'KeepCoding.Number.ToString(string, System.IFormatProvider)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [ToString(IFormatProvider)](KeepCoding_Number_ToString(System_IFormatProvider).md 'KeepCoding.Number.ToString(System.IFormatProvider)') | Converts the value to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |
| [TryParse(string, Number)](KeepCoding_Number_TryParse(string_KeepCoding_Number).md 'KeepCoding.Number.TryParse(string, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [TryParse(string, NumberStyles, NumberFormatInfo, Number)](KeepCoding_Number_TryParse(string_System_Globalization_NumberStyles_System_Globalization_NumberFormatInfo_KeepCoding_Number).md 'KeepCoding.Number.TryParse(string, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [TryParse(string, NumberStyles, IFormatProvider, Number)](KeepCoding_Number_TryParse(string_System_Globalization_NumberStyles_System_IFormatProvider_KeepCoding_Number).md 'KeepCoding.Number.TryParse(string, System.Globalization.NumberStyles, System.IFormatProvider, KeepCoding.Number)') | Attempts to parse a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |

| Operators | |
| :--- | :--- |
| [operator +(Number, Number)](KeepCoding_Number_op_Addition(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Addition(KeepCoding.Number, KeepCoding.Number)') | Add operator.<br/> |
| [operator &(Number, Number)](KeepCoding_Number_op_BitwiseAnd(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_BitwiseAnd(KeepCoding.Number, KeepCoding.Number)') | And operator.<br/> |
| [operator |(Number, Number)](KeepCoding_Number_op_BitwiseOr(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_BitwiseOr(KeepCoding.Number, KeepCoding.Number)') | Or operator.<br/> |
| [operator --(Number)](KeepCoding_Number_op_Decrement(KeepCoding_Number).md 'KeepCoding.Number.op_Decrement(KeepCoding.Number)') | Decrement operator.<br/> |
| [operator /(Number, Number)](KeepCoding_Number_op_Division(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Division(KeepCoding.Number, KeepCoding.Number)') | Divide operator.<br/> |
| [operator ==(Number, Number)](KeepCoding_Number_op_Equality(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Equality(KeepCoding.Number, KeepCoding.Number)') | Equals operator.<br/> |
| [operator ==(Number, ValueType)](KeepCoding_Number_op_Equality(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_Equality(KeepCoding.Number, System.ValueType)') | Equals operator.<br/> |
| [operator ^(Number, Number)](KeepCoding_Number_op_ExclusiveOr(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_ExclusiveOr(KeepCoding.Number, KeepCoding.Number)') | Xor operator.<br/> |
| [operator false(Number)](KeepCoding_Number_op_False(KeepCoding_Number).md 'KeepCoding.Number.op_False(KeepCoding.Number)') | False operator.<br/> |
| [operator &gt;(Number, Number)](KeepCoding_Number_op_GreaterThan(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number, KeepCoding.Number)') | More than operator.<br/> |
| [operator &gt;(Number, ValueType)](KeepCoding_Number_op_GreaterThan(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number, System.ValueType)') | More than operator.<br/> |
| [operator &gt;=(Number, Number)](KeepCoding_Number_op_GreaterThanOrEqual(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number, KeepCoding.Number)') | More than or equal operator.<br/> |
| [operator &gt;=(Number, ValueType)](KeepCoding_Number_op_GreaterThanOrEqual(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number, System.ValueType)') | More than or equals operator.<br/> |
| [implicit operator bool(Number)](KeepCoding_Number_op_Implicitbool(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit bool(KeepCoding.Number)') | Bool operator.<br/> |
| [implicit operator byte(Number)](KeepCoding_Number_op_Implicitbyte(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit byte(KeepCoding.Number)') | Implicitly converts the value to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').<br/> |
| [implicit operator decimal(Number)](KeepCoding_Number_op_Implicitdecimal(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit decimal(KeepCoding.Number)') | Implicitly converts the value to a [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').<br/> |
| [implicit operator double(Number)](KeepCoding_Number_op_Implicitdouble(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit double(KeepCoding.Number)') | Implicitly converts the value to a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').<br/> |
| [implicit operator float(Number)](KeepCoding_Number_op_Implicitfloat(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit float(KeepCoding.Number)') | Implicitly converts the value to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').<br/> |
| [implicit operator int(Number)](KeepCoding_Number_op_Implicitint(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit int(KeepCoding.Number)') | Implicitly converts the value to a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').<br/> |
| [implicit operator Number(byte)](KeepCoding_Number_op_ImplicitKeepCoding_Number(byte).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(byte)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(decimal)](KeepCoding_Number_op_ImplicitKeepCoding_Number(decimal).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(decimal)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(double)](KeepCoding_Number_op_ImplicitKeepCoding_Number(double).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(double)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(float)](KeepCoding_Number_op_ImplicitKeepCoding_Number(float).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(float)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(int)](KeepCoding_Number_op_ImplicitKeepCoding_Number(int).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(int)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(long)](KeepCoding_Number_op_ImplicitKeepCoding_Number(long).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(long)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(sbyte)](KeepCoding_Number_op_ImplicitKeepCoding_Number(sbyte).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(sbyte)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(short)](KeepCoding_Number_op_ImplicitKeepCoding_Number(short).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(short)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(uint)](KeepCoding_Number_op_ImplicitKeepCoding_Number(uint).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(uint)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(ulong)](KeepCoding_Number_op_ImplicitKeepCoding_Number(ulong).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(ulong)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator Number(ushort)](KeepCoding_Number_op_ImplicitKeepCoding_Number(ushort).md 'KeepCoding.Number.op_Implicit KeepCoding.Number(ushort)') | Implicitly converts the value to a [Number](KeepCoding_Number.md 'KeepCoding.Number').<br/> |
| [implicit operator long(Number)](KeepCoding_Number_op_Implicitlong(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit long(KeepCoding.Number)') | Implicitly converts the value to a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').<br/> |
| [implicit operator sbyte(Number)](KeepCoding_Number_op_Implicitsbyte(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit sbyte(KeepCoding.Number)') | Implicitly converts the value to a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').<br/> |
| [implicit operator short(Number)](KeepCoding_Number_op_Implicitshort(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit short(KeepCoding.Number)') | Implicitly converts the value to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').<br/> |
| [implicit operator ValueType(Number)](KeepCoding_Number_op_ImplicitSystem_ValueType(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit System.ValueType(KeepCoding.Number)') | Implicitly converts the value to a [System.ValueType](https://docs.microsoft.com/en-us/dotnet/api/System.ValueType 'System.ValueType').<br/> |
| [implicit operator uint(Number)](KeepCoding_Number_op_Implicituint(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit uint(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').<br/> |
| [implicit operator ulong(Number)](KeepCoding_Number_op_Implicitulong(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit ulong(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').<br/> |
| [implicit operator ushort(Number)](KeepCoding_Number_op_Implicitushort(KeepCoding_Number).md 'KeepCoding.Number.op_Implicit ushort(KeepCoding.Number)') | Implicitly converts the value to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').<br/> |
| [operator ++(Number)](KeepCoding_Number_op_Increment(KeepCoding_Number).md 'KeepCoding.Number.op_Increment(KeepCoding.Number)') | Increment operator.<br/> |
| [operator !=(Number, Number)](KeepCoding_Number_op_Inequality(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Inequality(KeepCoding.Number, KeepCoding.Number)') | Equals operator.<br/> |
| [operator !=(Number, ValueType)](KeepCoding_Number_op_Inequality(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_Inequality(KeepCoding.Number, System.ValueType)') | Equals operator.<br/> |
| [operator &lt;&lt;(Number, int)](KeepCoding_Number_op_LeftShift(KeepCoding_Number_int).md 'KeepCoding.Number.op_LeftShift(KeepCoding.Number, int)') | Left shift operator.<br/> |
| [operator &lt;(Number, Number)](KeepCoding_Number_op_LessThan(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_LessThan(KeepCoding.Number, KeepCoding.Number)') | Less than operator.<br/> |
| [operator &lt;(Number, ValueType)](KeepCoding_Number_op_LessThan(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_LessThan(KeepCoding.Number, System.ValueType)') | Less than operator.<br/> |
| [operator &lt;=(Number, Number)](KeepCoding_Number_op_LessThanOrEqual(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number, KeepCoding.Number)') | Less than or equal operator.<br/> |
| [operator &lt;=(Number, ValueType)](KeepCoding_Number_op_LessThanOrEqual(KeepCoding_Number_System_ValueType).md 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number, System.ValueType)') | Less than or equal operator.<br/> |
| [operator %(Number, Number)](KeepCoding_Number_op_Modulus(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Modulus(KeepCoding.Number, KeepCoding.Number)') | Modulo operator.<br/> |
| [operator *(Number, Number)](KeepCoding_Number_op_Multiply(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Multiply(KeepCoding.Number, KeepCoding.Number)') | Multiply operator.<br/> |
| [operator ~(Number)](KeepCoding_Number_op_OnesComplement(KeepCoding_Number).md 'KeepCoding.Number.op_OnesComplement(KeepCoding.Number)') | Tilde operator.<br/> |
| [operator &gt;&gt;(Number, int)](KeepCoding_Number_op_RightShift(KeepCoding_Number_int).md 'KeepCoding.Number.op_RightShift(KeepCoding.Number, int)') | Right shift operator.<br/> |
| [operator -(Number, Number)](KeepCoding_Number_op_Subtraction(KeepCoding_Number_KeepCoding_Number).md 'KeepCoding.Number.op_Subtraction(KeepCoding.Number, KeepCoding.Number)') | Subtract operator.<br/> |
| [operator true(Number)](KeepCoding_Number_op_True(KeepCoding_Number).md 'KeepCoding.Number.op_True(KeepCoding.Number)') | True operator.<br/> |
| [operator -(Number)](KeepCoding_Number_op_UnaryNegation(KeepCoding_Number).md 'KeepCoding.Number.op_UnaryNegation(KeepCoding.Number)') | Minus operator.<br/> |
| [operator +(Number)](KeepCoding_Number_op_UnaryPlus(KeepCoding_Number).md 'KeepCoding.Number.op_UnaryPlus(KeepCoding.Number)') | Plus operator.<br/> |
