#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.BinarySearch(Array, object) Method
Searches an entire one-dimensional sorted array for a specific element, using the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') interface implemented by each element of the array and by the specified object.  
```csharp
public static int BinarySearch(this System.Array array, object value);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sorted one-dimensional Array to search.
  
<a name='KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the specified [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') in the specified [array](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).array'), if [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is found; otherwise, a negative number. If [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is not found and [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is less than one or more elements in [array](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).array'), the negative number returned is the bitwise complement of the index of the first element that is larger than [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value'). If [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is not found and [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is greater than all elements in [array](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).array'), the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted [array](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).array'), the return [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') can be incorrect and a negative number could be returned, even if [value](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).value 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).value') is present in [array](ArrayHelper.BinarySearch.P9lLCQGvaJTKyJyjuXgk.w.md#KeepCoding.ArrayHelper.BinarySearch(System.Array.object).array 'KeepCoding.ArrayHelper.BinarySearch(System.Array, object).array').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Object_](https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Object_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch_System_Array_System_Object_')
