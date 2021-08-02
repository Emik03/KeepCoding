#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.BinarySearch(Array, int, int, object) Method
Searches a range of elements in a one-dimensional sorted array for a value, using the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') interface implemented by each element of the array and by the specified value.  
```csharp
public static int BinarySearch(this System.Array array, int index, int length, object value);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sorted one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to search.
  
<a name='KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the range to search.
  
<a name='KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the specified [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') in the specified [array](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).array'), if [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is found; otherwise, a negative number. If [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is not found and [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is less than one or more elements in [array](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).array'), the negative number returned is the bitwise complement of the index of the first element that is larger than [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value'). If [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is not found and [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is greater than all elements in [array](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).array'), the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted [array](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).array'), the return [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') can be incorrect and a negative number could be returned, even if [value](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).value') is present in [array](ArrayHelper_BinarySearch_xEFHLnBYu19hnq9e_q2IQg.md#KeepCoding_ArrayHelper_BinarySearch(System_Array_int_int_object)_array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, int, int, object).array').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Int32_System_Int32_System_Object_](https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Int32_System_Int32_System_Object_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Int32_System_Int32_System_Object_')
