#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.UniquePairs&lt;T&gt;(IQueryable&lt;T&gt;) Method
Returns an enumeration of tuples containing all unique pairs of distinct elements from the source collection.  
For example, the input sequence 1, 2, 3 yields the pairs [1,2], [1,3] and [2,3] only.  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,T>> UniquePairs<T>(this System.Linq.IQueryable<T> source);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_UniquePairs_T_(System_Linq_IQueryable_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_UniquePairs_T_(System_Linq_IQueryable_T_)_source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions_UniquePairs_bSIL68V5+rB1hQG6jjvtMQ.md#KeepCoding_UtilityExtensions_UniquePairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_UniquePairs_bSIL68V5+rB1hQG6jjvtMQ.md#KeepCoding_UtilityExtensions_UniquePairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_UniquePairs_bSIL68V5+rB1hQG6jjvtMQ.md#KeepCoding_UtilityExtensions_UniquePairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.UniquePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
### Remarks
Warning: This method does not work with IQToolkit.
