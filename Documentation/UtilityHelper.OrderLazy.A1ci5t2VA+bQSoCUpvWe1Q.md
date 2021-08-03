#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.OrderLazy&lt;T&gt;(IEnumerable&lt;T&gt;) Method
This does the same as [Order&lt;T&gt;(IEnumerable&lt;T&gt;)](UtilityHelper.Order.t26keCvwaSdrsMgcwa11XQ.md 'KeepCoding.UtilityHelper.Order&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;)'), but it is much faster if you intend to extract  
only the first few items using [System.Linq.Enumerable.Take&lt;&gt;.Collections.Generic.IEnumerable{&lt;&gt;.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Enumerable.Take--1#System_Linq_Enumerable_Take__1_System_Collections_Generic_IEnumerable{__0},System_Int32_ 'System.Linq.Enumerable.Take``1(System.Collections.Generic.IEnumerable{``0},System.Int32)').
```csharp
public static System.Collections.Generic.IEnumerable<T> OrderLazy<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.OrderLazy.T.(System.Collections.Generic.IEnumerable.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.OrderLazy.T.(System.Collections.Generic.IEnumerable.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.OrderLazy.A1ci5t2VA+bQSoCUpvWe1Q.md#KeepCoding.UtilityHelper.OrderLazy.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.UtilityHelper.OrderLazy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequence to be sorted.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.OrderLazy.A1ci5t2VA+bQSoCUpvWe1Q.md#KeepCoding.UtilityHelper.OrderLazy.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.UtilityHelper.OrderLazy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The given [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') with its elements sorted progressively.
