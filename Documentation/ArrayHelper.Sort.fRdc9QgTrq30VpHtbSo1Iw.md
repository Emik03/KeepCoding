#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort(Array, int, int, IComparer) Method
Sorts the elements in a range of elements in a one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer').  
```csharp
public static System.Array Sort(this System.Array array, int index, int length, System.Collections.IComparer comparer);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.Sort(System.Array.int.int.System.Collections.IComparer).array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.
  
<a name='KeepCoding.ArrayHelper.Sort(System.Array.int.int.System.Collections.IComparer).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding.ArrayHelper.Sort(System.Array.int.int.System.Collections.IComparer).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort
  
<a name='KeepCoding.ArrayHelper.Sort(System.Array.int.int.System.Collections.IComparer).comparer'></a>
`comparer` [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer')  
The [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer') implementation to use when comparing elements.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper.Sort.fRdc9QgTrq30VpHtbSo1Iw.md#KeepCoding.ArrayHelper.Sort(System.Array.int.int.System.Collections.IComparer).array 'KeepCoding.ArrayHelper.Sort(System.Array, int, int, System.Collections.IComparer).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Int32_System_Int32_System_Collections_IComparer_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Int32_System_Int32_System_Collections_IComparer_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Int32_System_Int32_System_Collections_IComparer_')
