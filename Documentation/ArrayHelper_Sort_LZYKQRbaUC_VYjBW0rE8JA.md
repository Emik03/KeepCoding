#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;T&gt;(T[], int, int, IComparer&lt;T&gt;) Method
Sorts the elements in a range of elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') generic interface.  
```csharp
public static T[] Sort<T>(this T[] array, int index, int length, System.Collections.Generic.IComparer<T> comparer);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_array'></a>
`array` [T](ArrayHelper_Sort_LZYKQRbaUC_VYjBW0rE8JA.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int, System.Collections.Generic.IComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](ArrayHelper_Sort_LZYKQRbaUC_VYjBW0rE8JA.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int, System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
The implementation to use when comparing elements or `null` to use the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') implementation of each element.
  
#### Returns
[T](ArrayHelper_Sort_LZYKQRbaUC_VYjBW0rE8JA.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int, System.Collections.Generic.IComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper_Sort_LZYKQRbaUC_VYjBW0rE8JA.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int_System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int, System.Collections.Generic.IComparer&lt;T&gt;).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__')
