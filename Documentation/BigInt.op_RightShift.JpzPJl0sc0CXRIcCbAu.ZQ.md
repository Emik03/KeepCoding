#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[BigInt](BigInt.md 'KeepCoding.BigInt')
## BigInt.operator &gt;&gt;(BigInt, int) Operator
Returns the result of a bit-shift-right by the specified [amount](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md#KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int).amount'). This is equivalent to dividing by 2 to the power of [amount](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md#KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int).amount') and rounding down.  
```csharp
public static KeepCoding.BigInt operator >>(KeepCoding.BigInt operand, int amount);
```
#### Parameters
<a name='KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).operand'></a>
`operand` [BigInt](BigInt.md 'KeepCoding.BigInt')  
  
<a name='KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount'></a>
`amount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[BigInt](BigInt.md 'KeepCoding.BigInt')  
### Remarks
If [amount](BigInt.op_RightShift.JpzPJl0sc0CXRIcCbAu.ZQ.md#KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt.int).amount 'KeepCoding.BigInt.op_RightShift(KeepCoding.BigInt, int).amount') is negative, the number is shifted left instead.  
