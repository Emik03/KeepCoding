#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Copy(Array, long, Array, long, long) Method
Copies a range of elements from an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified source index and pastes them to another [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified destination index. The length and the indexes are specified as 64-bit integers.  
```csharp
public static System.Array Copy(this System.Array sourceArray, long sourceIndex, System.Array destinationArray, long destinationIndex, long length);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).sourceArray'></a>
`sourceArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the data to copy.
  
<a name='KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).sourceIndex'></a>
`sourceIndex` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the index in the [sourceArray](ArrayHelper.Copy.RXVKImIxa.9Z7ceRYc.7pQ.md#KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).sourceArray 'KeepCoding.ArrayHelper.Copy(System.Array, long, System.Array, long, long).sourceArray') at which copying begins.
  
<a name='KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).destinationArray'></a>
`destinationArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that receives the data.
  
<a name='KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).destinationIndex'></a>
`destinationIndex` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the index in the [destinationIndex](ArrayHelper.Copy.RXVKImIxa.9Z7ceRYc.7pQ.md#KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).destinationIndex 'KeepCoding.ArrayHelper.Copy(System.Array, long, System.Array, long, long).destinationIndex') at which storing begins.
  
<a name='KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).length'></a>
`length` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the number of elements to copy. The integer must be between zero and [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[destinationArray](ArrayHelper.Copy.RXVKImIxa.9Z7ceRYc.7pQ.md#KeepCoding.ArrayHelper.Copy(System.Array.long.System.Array.long.long).destinationArray 'KeepCoding.ArrayHelper.Copy(System.Array, long, System.Array, long, long).destinationArray')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int64_System_Array_System_Int64_System_Int64_](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int64_System_Array_System_Int64_System_Int64_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int64_System_Array_System_Int64_System_Int64_')
