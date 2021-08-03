#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.IndexOf&lt;T&gt;(T[], T, int) Method
Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.  
```csharp
public static int IndexOf<T>(this T[] array, T value, int startIndex);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).array'></a>
`array` [T](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).T 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based array to search.
  
<a name='KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).value'></a>
`value` [T](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).T 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).T')  
The object to locate in [array](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).array 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).array').
  
<a name='KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based starting index of the search. 0 (zero) is valid in an empty array.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the first occurrence of [value](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).value 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).value') within the range of elements in [array](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).array 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).array') that extends from [startIndex](ArrayHelper.IndexOf.d4I83tcOKGUvD+etNIxd1Q.md#KeepCoding.ArrayHelper.IndexOf.T.(T...T.int).startIndex 'KeepCoding.ArrayHelper.IndexOf&lt;T&gt;(T[], T, int).startIndex') to the last element, if found; otherwise, -1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf__1___0_____0_System_Int32_')
