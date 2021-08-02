#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Copy(Array, Array, long) Method
Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 64-bit integer.  
```csharp
public static System.Array Copy(this System.Array sourceArray, System.Array destinationArray, long length);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_long)_sourceArray'></a>
`sourceArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the data to copy.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_long)_destinationArray'></a>
`destinationArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that receives the data.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_long)_length'></a>
`length` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the number of elements to copy. The integer must be between zero and [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[destinationArray](ArrayHelper_Copy_5gms0WbkdbyjnITtZae1tw.md#KeepCoding_ArrayHelper_Copy(System_Array_System_Array_long)_destinationArray 'KeepCoding.ArrayHelper.Copy(System.Array, System.Array, long).destinationArray')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int64_](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int64_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int64_')
