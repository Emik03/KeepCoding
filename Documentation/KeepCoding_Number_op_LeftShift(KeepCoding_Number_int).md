### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](KeepCoding_Number.md 'KeepCoding.Number')
## Number.operator &lt;&lt;(Number, int) Operator
Left shift operator.  
```csharp
public static KeepCoding.Number operator <<(KeepCoding.Number number, int other);
```
#### Parameters
<a name='KeepCoding_Number_op_LeftShift(KeepCoding_Number_int)_number'></a>
`number` [Number](KeepCoding_Number.md 'KeepCoding.Number')  
The left-hand side of the operator.
  
<a name='KeepCoding_Number_op_LeftShift(KeepCoding_Number_int)_other'></a>
`other` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The right-hand side of the operator.
  
#### Returns
[Number](KeepCoding_Number.md 'KeepCoding.Number')  
A number representing the result of the two numbers applied with the operator.
### Remarks
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), and [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') implicitly converts to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Calling this will assume that the value is [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'), or [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). An exception is thrown otherwise.  
            
