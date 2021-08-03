#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.implicit operator ulong(Number) Operator
Implicitly converts the value to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').  
```csharp
public static ulong implicit operator ulong(KeepCoding.Number number);
```
#### Parameters
<a name='KeepCoding.Number.op_Implicitulong(KeepCoding.Number).number'></a>
`number` [Number](Number.md 'KeepCoding.Number')  
The number to cast.
  
#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
### Remarks
Calling this will assume that the value is in inclusively between [System.UInt64.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64.MinValue 'System.UInt64.MinValue') and [System.UInt64.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64.MaxValue 'System.UInt64.MaxValue').  
