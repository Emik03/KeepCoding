#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.UniquePairs&lt;T&gt;(IQueryable&lt;T&gt;) Method
Returns an enumeration of tuples containing all unique pairs of distinct elements from the source collection.  
For example, the input sequence 1, 2, 3 yields the pairs [1,2], [1,3] and [2,3] only.  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,T>> UniquePairs<T>(this System.Linq.IQueryable<T> source);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.UniquePairs.T.(System.Linq.IQueryable.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.UniquePairs.T.(System.Linq.IQueryable.T.).source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityHelper.UniquePairs.Y0SfLQoxgxmvM7D0JubJTg.md#KeepCoding.UtilityHelper.UniquePairs.T.(System.Linq.IQueryable.T.).T 'KeepCoding.UtilityHelper.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityHelper.UniquePairs.Y0SfLQoxgxmvM7D0JubJTg.md#KeepCoding.UtilityHelper.UniquePairs.T.(System.Linq.IQueryable.T.).T 'KeepCoding.UtilityHelper.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityHelper.UniquePairs.Y0SfLQoxgxmvM7D0JubJTg.md#KeepCoding.UtilityHelper.UniquePairs.T.(System.Linq.IQueryable.T.).T 'KeepCoding.UtilityHelper.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
### Remarks
Warning: This method does not work with IQToolkit.
