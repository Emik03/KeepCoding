#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort(Array, Array, int, int) Method
Sorts a range of elements in a pair of one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') implementation of each key.  
```csharp
public static KeepCoding.Tuple<System.Array,System.Array> Sort(this System.Array keys, System.Array items, int index, int length);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_keys'></a>
`keys` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_items'></a>
`items` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to each of the keys in the [keys](ArrayHelper_Sort_5VxLntWd0cpdRzu4r3MMRw.md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, int, int).keys')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') or `null` to sort only the [keys](ArrayHelper_Sort_5VxLntWd0cpdRzu4r3MMRw.md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, int, int).keys')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
#### Returns
[KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](ArrayHelper_Sort_5VxLntWd0cpdRzu4r3MMRw.md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, int, int).keys') and [items](ArrayHelper_Sort_5VxLntWd0cpdRzu4r3MMRw.md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_int_int)_items 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, int, int).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Int32_System_Int32_
#### See Also
- []( '')
