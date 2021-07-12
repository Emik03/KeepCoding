### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](KeepCoding_Number.md 'KeepCoding.Number')
## Number.operator -(Number) Operator
Minus operator.  
```csharp
public static KeepCoding.Number operator -(KeepCoding.Number number);
```
#### Parameters
<a name='KeepCoding_Number_op_UnaryNegation(KeepCoding_Number)_number'></a>
`number` [Number](KeepCoding_Number.md 'KeepCoding.Number')  
The number to apply the operator to.
  
#### Returns
[Number](KeepCoding_Number.md 'KeepCoding.Number')  
The number with the operator applied to it.
### Remarks
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), and [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') implicitly converts to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') implicitly converts to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Calling this will assume that the value is not [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). An exception is thrown otherwise.  
            
