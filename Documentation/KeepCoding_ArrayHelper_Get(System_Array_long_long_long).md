### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Get(Array, long, long, long) Method
Gets the value at the specified position in the three-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). The indexes are specified as 64-bit integers.  
```csharp
public static object Get(this System.Array @this, long index1, long index2, long index3);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Get(System_Array_long_long_long)_this'></a>
`this` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
`this`
  
<a name='KeepCoding_ArrayHelper_Get(System_Array_long_long_long)_index1'></a>
`index1` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the first-dimension index of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') element to get.
  
<a name='KeepCoding_ArrayHelper_Get(System_Array_long_long_long)_index2'></a>
`index2` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the second-dimension index of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') element to get.
  
<a name='KeepCoding_ArrayHelper_Get(System_Array_long_long_long)_index3'></a>
`index3` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
A 64-bit integer that represents the third-dimension index of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') element to get.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value at the specified position in the three-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_System_Int64_System_Int64_](https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_System_Int64_System_Int64_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64_System_Int64_System_Int64_')
