#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.ConsecutivePairs&lt;T&gt;(IQueryable&lt;T&gt;, bool) Method
Returns an enumeration of tuples containing all consecutive pairs of the elements.  
```csharp
public static System.Linq.IQueryable<KeepCoding.Tuple<T,T>> ConsecutivePairs<T>(this System.Linq.IQueryable<T> source, bool closed);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityHelper.ConsecutivePairs.ac0f7ISZUTX3bIXweDsBmQ.md#KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).T 'KeepCoding.UtilityHelper.ConsecutivePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
The input enumerable.
  
<a name='KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).closed'></a>
`closed` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true, an additional pair containing the last and first element is included. For example,  
            if the source collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if [closed](UtilityHelper.ConsecutivePairs.ac0f7ISZUTX3bIXweDsBmQ.md#KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).closed 'KeepCoding.UtilityHelper.ConsecutivePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, bool).closed')  
            is false, and { (1, 2), (2, 3), (3, 4), (4, 1) } if [closed](UtilityHelper.ConsecutivePairs.ac0f7ISZUTX3bIXweDsBmQ.md#KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).closed 'KeepCoding.UtilityHelper.ConsecutivePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, bool).closed') is true.
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityHelper.ConsecutivePairs.ac0f7ISZUTX3bIXweDsBmQ.md#KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).T 'KeepCoding.UtilityHelper.ConsecutivePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, bool).T')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityHelper.ConsecutivePairs.ac0f7ISZUTX3bIXweDsBmQ.md#KeepCoding.UtilityHelper.ConsecutivePairs.T.(System.Linq.IQueryable.T..bool).T 'KeepCoding.UtilityHelper.ConsecutivePairs&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, bool).T')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
### Remarks
Warning: This method does not work with IQToolkit.
