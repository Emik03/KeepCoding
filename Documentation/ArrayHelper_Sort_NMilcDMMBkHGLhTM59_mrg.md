#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort(Array, IComparer) Method
Sorts the elements in a one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer').  
```csharp
public static System.Array Sort(this System.Array array, System.Collections.IComparer comparer);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Collections_IComparer)_array'></a>
`array` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional array to sort.
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Collections_IComparer)_comparer'></a>
`comparer` [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer')  
The implementation to use when comparing elements or `null` to use the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') implementation of each element.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper_Sort_NMilcDMMBkHGLhTM59_mrg.md#KeepCoding_ArrayHelper_Sort(System_Array_System_Collections_IComparer)_array 'KeepCoding.ArrayHelper.Sort(System.Array, System.Collections.IComparer).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Collections_IComparer_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Collections_IComparer_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Collections_IComparer_')
