#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Concat&lt;T&gt;(IQueryable&lt;T&gt;, T) Method
Adds a single element to the end of an IQueryable.  
```csharp
public static System.Linq.IQueryable<T> Concat<T>(this System.Linq.IQueryable<T> input, T element);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_T'></a>
`T`  
Type of enumerable to return.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_input'></a>
`input` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions_Concat_Y6PKkGm9nCJyLUyGiG4_Gw.md#KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_T 'KeepCoding.UtilityExtensions.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
  
<a name='KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_element'></a>
`element` [T](UtilityExtensions_Concat_Y6PKkGm9nCJyLUyGiG4_Gw.md#KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_T 'KeepCoding.UtilityExtensions.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')  
  
#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](UtilityExtensions_Concat_Y6PKkGm9nCJyLUyGiG4_Gw.md#KeepCoding_UtilityExtensions_Concat_T_(System_Linq_IQueryable_T__T)_T 'KeepCoding.UtilityExtensions.Concat&lt;T&gt;(System.Linq.IQueryable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
IQueryable containing all the input elements, followed by the specified additional element.
