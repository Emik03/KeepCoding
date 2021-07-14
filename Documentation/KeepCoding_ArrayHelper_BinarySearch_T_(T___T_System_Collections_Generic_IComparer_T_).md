#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.BinarySearch&lt;T&gt;(T[], T, IComparer&lt;T&gt;) Method
Searches an entire one-dimensional sorted array for a value using the specified [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') generic interface.  
```csharp
public static int BinarySearch<T>(this T[] array, T value, System.Collections.Generic.IComparer<T> comparer);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array'></a>
`array` [T](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sorted one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value'></a>
`value` [T](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).T')  
The object to search for.
  
<a name='KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
The [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') implementation to use when comparing elements or `null` to use the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') implementation of each element.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the specified [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') in the specified [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).array'), if [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is found; otherwise, a negative number. If [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is not found and [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is less than one or more elements in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).array'), the negative number returned is the bitwise complement of the index of the first element that is larger than [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value'). If [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is not found and [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is greater than all elements in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).array'), the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).array'), the return [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') can be incorrect and a negative number could be returned, even if [value](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).value') is present in [array](KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_).md#KeepCoding_ArrayHelper_BinarySearch_T_(T___T_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], T, System.Collections.Generic.IComparer&lt;T&gt;).array').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_System_Collections_Generic_IComparer___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_System_Collections_Generic_IComparer___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0_____0_System_Collections_Generic_IComparer___0__')