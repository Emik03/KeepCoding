#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Copy(Array, Array, int) Method
Copies a range of elements from an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the first element and pastes them into another [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the first element. The length is specified as a 32-bit integer.  
```csharp
public static System.Array Copy(this System.Array sourceArray, System.Array destinationArray, int length);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_int)_sourceArray'></a>
`sourceArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the data to copy.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_int)_destinationArray'></a>
`destinationArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that receives the data.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_System_Array_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the number of elements to copy.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[destinationArray](KeepCoding_ArrayHelper_Copy(System_Array_System_Array_int).md#KeepCoding_ArrayHelper_Copy(System_Array_System_Array_int)_destinationArray 'KeepCoding.ArrayHelper.Copy(System.Array, System.Array, int).destinationArray')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Array_System_Int32_')
