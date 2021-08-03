#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], IComparer&lt;TKey&gt;) Method
Sorts a pair of [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') generic interface.  
```csharp
public static KeepCoding.Tuple<TKey[],TValue[]> Sort<TKey,TValue>(this TKey[] keys, TValue[] items, System.Collections.Generic.IComparer<TKey> comparer);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TKey'></a>
`TKey`  
The type of the elements of the key array.
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TValue'></a>
`TValue`  
The type of the elements of the items array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).keys'></a>
`keys` [TKey](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).items'></a>
`items` [TValue](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to the keys in [keys](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).keys'), or `null` to sort only [keys](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).keys').
  
<a name='KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[TKey](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
The [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation to use when comparing elements, or `null` to use the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation of each element.
  
#### Returns
[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TKey](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TKey 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).TKey')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[TValue](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).TValue 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).keys 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).keys') and [items](ArrayHelper.Sort.osNrZlFYYtV6No6r+omT4Q.md#KeepCoding.ArrayHelper.Sort.TKey.TValue.(TKey...TValue...System.Collections.Generic.IComparer.TKey.).items 'KeepCoding.ArrayHelper.Sort&lt;TKey,TValue&gt;(TKey[], TValue[], System.Collections.Generic.IComparer&lt;TKey&gt;).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Collections_Generic_IComparer___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Collections_Generic_IComparer___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__2___0_____1___System_Collections_Generic_IComparer___0__')
