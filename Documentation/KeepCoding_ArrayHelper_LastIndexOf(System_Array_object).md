### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.LastIndexOf(Array, object) Method
Searches for the specified object and returns the index of its last occurrence in a one-dimensional array.  
```csharp
public static int LastIndexOf(this System.Array array, object value);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_LastIndexOf(System_Array_object)_array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional array to search.
  
<a name='KeepCoding_ArrayHelper_LastIndexOf(System_Array_object)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to locate in [array](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object)_array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object).array').
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the last occurrence of [value](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object)_value 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object).value') in [array](KeepCoding_ArrayHelper_LastIndexOf(System_Array_object).md#KeepCoding_ArrayHelper_LastIndexOf(System_Array_object)_array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object).array'), if found; otherwise, the lower bound of the array minus 1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_')
