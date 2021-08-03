#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Get(Array, long[]) Method
Gets the value at the specified position in the multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). The indexes are specified as an array of 64-bit integers.  
```csharp
public static object Get(this System.Array @this, params long[] indices);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.Get(System.Array.long..).this'></a>
`this` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
`this`
  
<a name='KeepCoding.ArrayHelper.Get(System.Array.long..).indices'></a>
`indices` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the Array element to get.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value at the specified position in the multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64___](https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64___ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-5.0#System_Array_GetValue_System_Int64___')
