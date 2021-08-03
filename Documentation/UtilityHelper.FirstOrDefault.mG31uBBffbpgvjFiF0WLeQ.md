#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.FirstOrDefault&lt;T&gt;(IQueryable&lt;T&gt;, T) Method
Returns the first element of a sequence, or a default value if the sequence contains no elements.  
```csharp
public static T FirstOrDefault<T>(this System.Linq.IQueryable<T> source, T @default);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T'></a>
`T`  
The type of the elements of [source](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
The collection to return the first element of.
  
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).default'></a>
`default` [T](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
The default value to return if the sequence contains no elements.
  
#### Returns
[T](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
[default](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).default 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).default') if [source](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source') is empty;  
            otherwise, the first element in [source](UtilityHelper.FirstOrDefault.mG31uBBffbpgvjFiF0WLeQ.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source').
