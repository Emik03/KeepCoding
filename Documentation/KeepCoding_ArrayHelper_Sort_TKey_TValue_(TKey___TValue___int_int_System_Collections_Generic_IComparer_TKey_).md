#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, IComparer&lt;TKey&gt;) Method
Sorts a range of elements in a pair of [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') generic interface.  
```csharp
public static KeepCoding.Tuple<TKey[],TValue[]> Sort<TKey,TValue>(this TKey[] keys, TValue[] items, int index, int length, System.Collections.Generic.IComparer<TKey> comparer);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TKey'></a>
`TKey`  
The type of the elements of the key array.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TValue'></a>
`TValue`  
The type of the elements of the items array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_keys'></a>
`keys` [TKey](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_items'></a>
`items` [TValue](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to the keys in [keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).keys'), or `null` to sort only [keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).keys').
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[TKey](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
The implementation to use when comparing elements or `null` to use the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') implementation of each element.
  
#### Returns
[KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TKey](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TValue](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).keys') and [items](KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_).md#KeepCoding_ArrayHelper_Sort_TKey_TValue_(TKey___TValue___int_int_System_Collections_Generic_IComparer_TKey_)_items 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int, System.Collections.Generic.IComparer&lt;TKey&gt;).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_System_Collections_Generic_IComparer___0__')
