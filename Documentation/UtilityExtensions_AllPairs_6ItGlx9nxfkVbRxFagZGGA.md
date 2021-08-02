#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.AllPairs&lt;T&gt;(IQueryable&lt;T&gt;) Method
Returns an enumeration of tuples containing all pairs of elements from the source collection.  
For example, the input sequence 1, 2 yields the pairs [1,1], [1,2], [2,1], and [2,2].  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,T>> AllPairs<T>(this System.Linq.IQueryable<T> source);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_AllPairs_T_(System_Linq_IQueryable_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_AllPairs_T_(System_Linq_IQueryable_T_)_source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions_AllPairs_6ItGlx9nxfkVbRxFagZGGA.md#KeepCoding_UtilityExtensions_AllPairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.AllPairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_AllPairs_6ItGlx9nxfkVbRxFagZGGA.md#KeepCoding_UtilityExtensions_AllPairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.AllPairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_AllPairs_6ItGlx9nxfkVbRxFagZGGA.md#KeepCoding_UtilityExtensions_AllPairs_T_(System_Linq_IQueryable_T_)_T 'KeepCoding.UtilityExtensions.AllPairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;).T')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
