#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.operator &gt;&gt;(Number, int) Operator
Right shift operator.  
```csharp
public static KeepCoding.Number operator >>(KeepCoding.Number number, int other);
```
#### Parameters
<a name='KeepCoding.Number.op_RightShift(KeepCoding.Number.int).number'></a>
`number` [Number](Number.md 'KeepCoding.Number')  
The left-hand side of the operator.
  
<a name='KeepCoding.Number.op_RightShift(KeepCoding.Number.int).other'></a>
`other` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The right-hand side of the operator.
  
#### Returns
[Number](Number.md 'KeepCoding.Number')  
A number representing the result of the two numbers applied with the operator.
### Remarks
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), and [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') implicitly converts to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Calling this will assume that the value is [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'), or [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). An exception is thrown otherwise.  
            
