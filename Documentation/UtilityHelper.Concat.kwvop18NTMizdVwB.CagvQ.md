#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Concat&lt;T&gt;(IQueryable&lt;T&gt;, T) Method
Adds a single element to the end of an IQueryable.  
```csharp
public static System.Linq.IQueryable<T> Concat<T>(this System.Linq.IQueryable<T> input, T element);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).T'></a>
`T`  
Type of enumerable to return.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).input'></a>
`input` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityHelper.Concat.kwvop18NTMizdVwB.CagvQ.md#KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
<a name='KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).element'></a>
`element` [T](UtilityHelper.Concat.kwvop18NTMizdVwB.CagvQ.md#KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityHelper.Concat.kwvop18NTMizdVwB.CagvQ.md#KeepCoding.UtilityHelper.Concat.T.(System.Linq.IQueryable.T..T).T 'KeepCoding.UtilityHelper.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
IQueryable containing all the input elements, followed by the specified additional element.
