### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Get(Array, int[]) Method
Gets the value at the specified position in the multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). The indexes are specified as an array of 32-bit integers.  
```csharp
public static object Get(this System.Array @this, params int[] indices);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Get(System_Array_int__)_this'></a>
`this` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
`this`
  
<a name='KeepCoding_ArrayHelper_Get(System_Array_int__)_indices'></a>
`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the Array element to get.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value at the specified position in the multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32___](https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32___ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int32___')
