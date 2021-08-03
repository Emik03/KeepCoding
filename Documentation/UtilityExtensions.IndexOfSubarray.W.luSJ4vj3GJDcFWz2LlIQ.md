#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, Nullable&lt;int&gt;, IEqualityComparer&lt;T&gt;) Method
Searches the current array for a specified subarray and returns the index of the first occurrence, or -1 if  
not found.
```csharp
public static int IndexOfSubarray<T>(this T[] sourceArray, T[] findWhat, int startIndex, System.Nullable<int> sourceLength=null, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).sourceArray'></a>
`sourceArray` [T](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array in which to search for the subarray.
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).findWhat'></a>
`findWhat` [T](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Subarray to search for.
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Index in [sourceArray](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).sourceArray 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).sourceArray') at which to start searching.
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).sourceLength'></a>
`sourceLength` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
Maximum length of the source array to search starting from [startIndex](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).startIndex 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).startIndex'). The greatest index  
that can be returned is this minus the length of [findWhat](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).findWhat 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).findWhat') plus [startIndex](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).startIndex 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).startIndex').
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityExtensions.IndexOfSubarray.W.luSJ4vj3GJDcFWz2LlIQ.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...int.System.Nullable.int..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], int, System.Nullable&lt;int&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the first match, or -1 if no match is found.
