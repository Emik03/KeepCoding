#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T) Method
Searches a range of elements in a one-dimensional sorted array for a value, using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implemented by each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') and by the specified value.  
```csharp
public static int BinarySearch<T>(this T[] array, int index, int length, T value);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array'></a>
`array` [T](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sorted one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to search.
  
<a name='KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the range to search.
  
<a name='KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value'></a>
`value` [T](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).T 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).T')  
The object to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the specified [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') in the specified [array](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).array'), if [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is found; otherwise, a negative number. If [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is not found and [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is less than one or more elements in [array](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).array'), the negative number returned is the bitwise complement of the index of the first element that is larger than [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value'). If [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is not found and [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is greater than all elements in [array](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).array'), the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted [array](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).array'), the return [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') can be incorrect and a negative number could be returned, even if [value](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).value 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).value') is present in [array](ArrayHelper.BinarySearch.iC4bOUgkBrBEEbFurgEfxw.md#KeepCoding.ArrayHelper.BinarySearch.T.(T...int.int.T).array 'KeepCoding.ArrayHelper.BinarySearch&lt;T&gt;(T[], int, int, T).array').
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0___System_Int32_System_Int32___0_](https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0___System_Int32_System_Int32___0_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.binarysearch?view=net-5.0#System_Array_BinarySearch__1___0___System_Int32_System_Int32___0_')
