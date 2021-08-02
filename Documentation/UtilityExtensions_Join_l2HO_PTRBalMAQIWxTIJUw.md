#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Join&lt;T,U&gt;(IQueryable&lt;T&gt;, IQueryable&lt;U&gt;) Method
Returns an enumeration of [Tuple&lt;T1,T2&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')s containing all ordered pairs of elements from the two source collections.  
For example, [1, 2].Join(["one", "two"]) results in the tuples [1, "one"], [1, "two"], [2, "one"] and [2, "two"].  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,U>> Join<T,U>(this System.Linq.IQueryable<T> source, System.Linq.IQueryable<U> with);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_T'></a>
`T`  
  
<a name='KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_U'></a>
`U`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions_Join_l2HO_PTRBalMAQIWxTIJUw.md#KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_T 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
<a name='KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_with'></a>
`with` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[U](UtilityExtensions_Join_l2HO_PTRBalMAQIWxTIJUw.md#KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_U 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).U')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_Join_l2HO_PTRBalMAQIWxTIJUw.md#KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_T 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).T')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[U](UtilityExtensions_Join_l2HO_PTRBalMAQIWxTIJUw.md#KeepCoding_UtilityExtensions_Join_T_U_(System_Linq_IQueryable_T__System_Linq_IQueryable_U_)_U 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).U')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
