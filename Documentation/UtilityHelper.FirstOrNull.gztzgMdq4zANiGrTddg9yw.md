#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.FirstOrNull&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Returns the first element of a sequence, or `null` if the sequence contains no elements.
```csharp
public static System.Nullable<T> FirstOrNull<T>(this System.Collections.Generic.IEnumerable<T> source)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).T'></a>
`T`  
The type of the elements of [source](UtilityHelper.FirstOrNull.gztzgMdq4zANiGrTddg9yw.md#KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).source 'KeepCoding.UtilityHelper.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.FirstOrNull.gztzgMdq4zANiGrTddg9yw.md#KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.UtilityHelper.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](UtilityHelper.FirstOrNull.gztzgMdq4zANiGrTddg9yw.md#KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.UtilityHelper.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
`null` if [source](UtilityHelper.FirstOrNull.gztzgMdq4zANiGrTddg9yw.md#KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).source 'KeepCoding.UtilityHelper.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source') is empty; otherwise, the first element in [source](UtilityHelper.FirstOrNull.gztzgMdq4zANiGrTddg9yw.md#KeepCoding.UtilityHelper.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T.).source 'KeepCoding.UtilityHelper.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source').
