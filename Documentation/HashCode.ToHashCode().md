#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[HashCode](HashCode.md 'KeepCoding.HashCode')
## HashCode.ToHashCode() Method
Calculates the final hash code after consecutive [KeepCoding.HashCode.Add(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.HashCode.Add#KeepCoding_HashCode_Add_System_Int32_ 'KeepCoding.HashCode.Add(System.Int32)')/[KeepCoding.HashCode.Add(System.UInt32,System.UInt32)](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.HashCode.Add#KeepCoding_HashCode_Add_System_UInt32,System_UInt32_ 'KeepCoding.HashCode.Add(System.UInt32,System.UInt32)') invocations.  
```csharp
public readonly int ToHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The calculated hash code.
### Remarks
This method must be called at most once per instance of [HashCode](HashCode.md 'KeepCoding.HashCode').  
