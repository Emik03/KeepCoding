#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int) Method
Sorts a range of elements in a pair of [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation of each key.  
```csharp
public static KeepCoding.Tuple<TKey[],TValue[]> Sort<TKey,TValue>(this TKey[] keys, TValue[] items, int index, int length);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TKey'></a>
`TKey`  
The type of the elements of the key array.
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TValue'></a>
`TValue`  
The type of the elements of the items array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).keys'></a>
`keys` [TKey](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).items'></a>
`items` [TValue](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to the keys in [keys](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys'), or `null` to sort only [keys](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys').
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the range to sort.
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the range to sort.
  
#### Returns
[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TKey](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TValue](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).keys') and [items](ArrayHelper.Sort.CVWGLCb0DrzgZ8nx6MRvjQ.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...int.int).items 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], int, int).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Int32_System_Int32_')
