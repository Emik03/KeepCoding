#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int) Method
Sorts a range of elements in a pair of [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation of each key.  
```csharp
public static KeepCoding.Tuple<TKey[],TValue[]> Sort<TKey,TValue>(this TKey[] keys, TValue[] items, int index, int length);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TKey'></a>
`TKey`  
The type of the elements of the key array.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TValue'></a>
`TValue`  
The type of the elements of the items array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_keys'></a>
`keys` [TKey](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_items'></a>
`items` [TValue](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to the keys in [keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys'), or `null` to sort only [keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys').
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
#### Returns
[KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TKey](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TValue](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys') and [items](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int)_items 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_')
