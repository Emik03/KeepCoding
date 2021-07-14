#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.CreateInstance(Type, long[]) Method
Creates a multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.  
```csharp
public static System.Array CreateInstance(this System.Type elementType, params long[] lengths);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_long__)_elementType'></a>
`elementType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_long__)_lengths'></a>
`lengths` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of 64-bit integers that represent the size of each dimension of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create. Each integer in the array must be between zero and [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int64___](https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int64___ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int64___')
