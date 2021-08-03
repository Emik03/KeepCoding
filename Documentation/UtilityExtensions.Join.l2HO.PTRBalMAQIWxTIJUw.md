#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Join&lt;T,U&gt;(IQueryable&lt;T&gt;, IQueryable&lt;U&gt;) Method
Returns an enumeration of [Tuple&lt;T1,T2&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')s containing all ordered pairs of elements from the two source collections.  
For example, [1, 2].Join(["one", "two"]) results in the tuples [1, "one"], [1, "two"], [2, "one"] and [2, "two"].  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,U>> Join<T,U>(this System.Linq.IQueryable<T> source, System.Linq.IQueryable<U> with);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).T'></a>
`T`  
  
<a name='KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).U'></a>
`U`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions.Join.l2HO.PTRBalMAQIWxTIJUw.md#KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).T 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
<a name='KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).with'></a>
`with` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[U](UtilityExtensions.Join.l2HO.PTRBalMAQIWxTIJUw.md#KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).U 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).U')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions.Join.l2HO.PTRBalMAQIWxTIJUw.md#KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).T 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).T')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[U](UtilityExtensions.Join.l2HO.PTRBalMAQIWxTIJUw.md#KeepCoding.UtilityExtensions.Join.T.U.(System.Linq.IQueryable.T..System.Linq.IQueryable.U.).U 'KeepCoding.UtilityExtensions.Join&lt;T,U&gt;(System.Linq.IQueryable&lt;T&gt;, System.Linq.IQueryable&lt;U&gt;).U')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
