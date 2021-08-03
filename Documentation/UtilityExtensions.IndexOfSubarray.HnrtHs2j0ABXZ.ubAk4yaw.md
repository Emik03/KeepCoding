#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], IEqualityComparer&lt;T&gt;) Method
Searches the current array for a specified subarray and returns the index of the first occurrence, or -1 if  
not found.
```csharp
public static int IndexOfSubarray<T>(this T[] sourceArray, T[] findWhat, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).sourceArray'></a>
`sourceArray` [T](UtilityExtensions.IndexOfSubarray.HnrtHs2j0ABXZ.ubAk4yaw.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array in which to search for the subarray.
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).findWhat'></a>
`findWhat` [T](UtilityExtensions.IndexOfSubarray.HnrtHs2j0ABXZ.ubAk4yaw.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Subarray to search for.
  
<a name='KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityExtensions.IndexOfSubarray.HnrtHs2j0ABXZ.ubAk4yaw.md#KeepCoding.UtilityExtensions.IndexOfSubarray.T.(T...T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.IndexOfSubarray&lt;T&gt;(T[], T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the first match, or -1 if no match is found.
