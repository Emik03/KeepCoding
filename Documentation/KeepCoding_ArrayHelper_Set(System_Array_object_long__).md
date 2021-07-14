#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Set(Array, object, long[]) Method
Sets a value to the element at the specified position in the multi-dimensional Array. The index is specified as a 64-bit integer.  
```csharp
public static System.Array Set(this System.Array @this, object value, params long[] indices);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Set(System_Array_object_long__)_this'></a>
`this` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
`this`
  
<a name='KeepCoding_ArrayHelper_Set(System_Array_object_long__)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The new value for the specified element.
  
<a name='KeepCoding_ArrayHelper_Set(System_Array_object_long__)_indices'></a>
`indices` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the element to set.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[this](KeepCoding_ArrayHelper_Set(System_Array_object_long__).md#KeepCoding_ArrayHelper_Set(System_Array_object_long__)_this 'KeepCoding.ArrayHelper.Set(System.Array, object, long[]).this')
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64___](https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64___ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.setvalue?view=net-5.0#System_Array_SetValue_System_Object_System_Int64___')
