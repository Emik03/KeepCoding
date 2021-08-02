#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort&lt;T&gt;(T[], IComparer&lt;T&gt;) Method
Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') generic interface.  
```csharp
public static T[] Sort<T>(this T[] array, System.Collections.Generic.IComparer<T> comparer);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_array'></a>
`array` [T](ArrayHelper_Sort_DGvcu5X76bMzsHOcYAqFOw.md#KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], System.Collections.Generic.IComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-base [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.
  
<a name='KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](ArrayHelper_Sort_DGvcu5X76bMzsHOcYAqFOw.md#KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
The [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation to use when comparing elements, or `null` to use the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic interface implementation of each element.
  
#### Returns
[T](ArrayHelper_Sort_DGvcu5X76bMzsHOcYAqFOw.md#KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_T 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], System.Collections.Generic.IComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper_Sort_DGvcu5X76bMzsHOcYAqFOw.md#KeepCoding_ArrayHelper_Sort_T_(T___System_Collections_Generic_IComparer_T_)_array 'KeepCoding.ArrayHelper.Sort&lt;T&gt;(T[], System.Collections.Generic.IComparer&lt;T&gt;).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Collections_Generic_IComparer___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Collections_Generic_IComparer___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort__1___0___System_Collections_Generic_IComparer___0__')
