### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.LastIndexOf(Array, object, int) Method
Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its last occurrence. The range extends from a specified index to the end of the array.  
```csharp
public static int LastIndexOf(this System.Array array, object value, int startIndex);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional array to search.
  
<a name='KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to locate in [array](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int).array').
  
<a name='KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the search. 0 (zero) is valid in an empty array.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the last occurrence of [value](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_value 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int).value'), if it's found, within the range of elements in [array](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int).array') that extends from [startIndex](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object_int)_startIndex 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int).startIndex') to the last element; otherwise, the lower bound of the array minus 1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_')
