### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.IndexOf&lt;T&gt;(T[], T) Method
Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.  
```csharp
public static int IndexOf<T>(this T[] array, T value);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_IndexOf_T_(T___T)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_IndexOf_T_(T___T)_array'></a>
`array` [T](KeepCoding_ArrayHelper_IndexOf_T_(T___T).md#KeepCoding_ArrayHelper_IndexOf_T_(T___T)_T 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based array to search.
  
<a name='KeepCoding_ArrayHelper_IndexOf_T_(T___T)_value'></a>
`value` [T](KeepCoding_ArrayHelper_IndexOf_T_(T___T).md#KeepCoding_ArrayHelper_IndexOf_T_(T___T)_T 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T).T')  
The object to locate in [array](KeepCoding_ArrayHelper_IndexOf_T_(T___T).md#KeepCoding_ArrayHelper_IndexOf_T_(T___T)_array 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T).array').
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the first occurrence of [value](KeepCoding_ArrayHelper_IndexOf_T_(T___T).md#KeepCoding_ArrayHelper_IndexOf_T_(T___T)_value 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T).value') in the entire [array](KeepCoding_ArrayHelper_IndexOf_T_(T___T).md#KeepCoding_ArrayHelper_IndexOf_T_(T___T)_array 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T).array'), if found; otherwise, -1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_')
