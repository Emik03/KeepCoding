#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.BinarySearch&lt;T&gt;(T[], T) Method
Searches an entire one-dimensional sorted array for a specific element, using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implemented by each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') and by the specified object.  
```csharp
public static int BinarySearch<T>(this T[] array, T value);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array'></a>
`array` [T](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sorted one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value'></a>
`value` [T](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).T')  
The object to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the specified [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') in the specified [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).array'), if [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is found; otherwise, a negative number. If [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is not found and [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is less than one or more elements in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).array'), the negative number returned is the bitwise complement of the index of the first element that is larger than [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value'). If [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is not found and [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is greater than all elements in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).array'), the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).array'), the return [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') can be incorrect and a negative number could be returned, even if [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).value') is present in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T).array').
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_](https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_')
