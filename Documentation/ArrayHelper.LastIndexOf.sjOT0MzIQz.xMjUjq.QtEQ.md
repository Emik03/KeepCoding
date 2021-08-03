#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.LastIndexOf(Array, object, int, int) Method
Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs last occurrence. The range extends from a specified index for a specified number of elements.  
```csharp
public static int LastIndexOf(this System.Array array, object value, int startIndex, int count);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional array to search.
  
<a name='KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to locate in [array](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).array').
  
<a name='KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the search. 0 (zero) is valid in an empty array.
  
<a name='KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements to search.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the last occurrence of [value](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).value 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).value'), if it's found in the [array](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).array 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).array') from index [startIndex](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).startIndex 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).startIndex') to [startIndex](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).startIndex 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).startIndex') + [count](ArrayHelper.LastIndexOf.sjOT0MzIQz.xMjUjq.QtEQ.md#KeepCoding.ArrayHelper.LastIndexOf(System.Array.object.int.int).count 'KeepCoding.ArrayHelper.LastIndexOf(System.Array, object, int, int).count') - 1; otherwise, the lower bound of the array minus 1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-5.0#System_Array_IndexOf_System_Array_System_Object_System_Int32_System_Int32_')
