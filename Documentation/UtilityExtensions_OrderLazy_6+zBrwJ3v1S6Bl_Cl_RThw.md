#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.OrderLazy&lt;T&gt;(IEnumerable&lt;T&gt;, IComparer&lt;T&gt;) Method
This does the same as [Order&lt;T&gt;(IEnumerable&lt;T&gt;, IComparer&lt;T&gt;)](UtilityExtensions_Order_sSTinLXlRELyJL6XN40mzQ.md 'KeepCoding.UtilityExtensions.Order&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;)'), but it is much faster if you intend  
to extract only the first few items using [System.Linq.Enumerable.Take&lt;&gt;.Collections.Generic.IEnumerable{&lt;&gt;.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Enumerable.Take--1#System_Linq_Enumerable_Take__1_System_Collections_Generic_IEnumerable{__0},System_Int32_ 'System.Linq.Enumerable.Take``1(System.Collections.Generic.IEnumerable{``0},System.Int32)').
```csharp
public static System.Collections.Generic.IEnumerable<T> OrderLazy<T>(this System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IComparer<T> comparer);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_OrderLazy_6+zBrwJ3v1S6Bl_Cl_RThw.md#KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_T 'KeepCoding.UtilityExtensions.OrderLazy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequence to be sorted.
  
<a name='KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](UtilityExtensions_OrderLazy_6+zBrwJ3v1S6Bl_Cl_RThw.md#KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_T 'KeepCoding.UtilityExtensions.OrderLazy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
An instance of [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') specifying the comparison to use on the items.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_OrderLazy_6+zBrwJ3v1S6Bl_Cl_RThw.md#KeepCoding_UtilityExtensions_OrderLazy_T_(System_Collections_Generic_IEnumerable_T__System_Collections_Generic_IComparer_T_)_T 'KeepCoding.UtilityExtensions.OrderLazy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The given IEnumerable<T> with its elements sorted progressively.
