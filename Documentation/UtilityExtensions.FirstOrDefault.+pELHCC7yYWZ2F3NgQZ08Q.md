#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FirstOrDefault&lt;T&gt;(IQueryable&lt;T&gt;, T) Method
Returns the first element of a sequence, or a default value if the sequence contains no elements.  
```csharp
public static T FirstOrDefault<T>(this System.Linq.IQueryable<T> source, T @default);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T'></a>
`T`  
The type of the elements of [source](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source').
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source'></a>
`source` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
The collection to return the first element of.
  
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).default'></a>
`default` [T](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
The default value to return if the sequence contains no elements.
  
#### Returns
[T](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
[default](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).default 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).default') if [source](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source') is empty;  
            otherwise, the first element in [source](UtilityExtensions.FirstOrDefault.+pELHCC7yYWZ2F3NgQZ08Q.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Linq.IQueryable.T..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).source').
