#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;T&gt;(T[], int, int) Method
Sorts the elements in a range of elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T[] Sort<T>(this T[] array, int index, int length);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int)_array'></a>
`array` [T](ArrayHelper_Sort_O5eKAHetW3MC+t0bWDSVKQ.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
#### Returns
[T](ArrayHelper_Sort_O5eKAHetW3MC+t0bWDSVKQ.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper_Sort_O5eKAHetW3MC+t0bWDSVKQ.md#KeepCoding_ArrayHelper_Sort_T_(T___int_int)_array 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], int, int).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Int32_System_Int32_')
