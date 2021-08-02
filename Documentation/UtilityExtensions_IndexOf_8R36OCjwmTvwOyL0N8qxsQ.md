#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, T, IEqualityComparer&lt;T&gt;) Method
Returns the index of the first element in this [source](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_source 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).source') that is equal to the specified  
[element](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_element 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).element') as determined by the specified [comparer](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_comparer 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).comparer'). If no such elements are  
found, returns `-1`.
```csharp
public static int IndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, T element, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_element'></a>
`element` [T](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')  
  
<a name='KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityExtensions_IndexOf_8R36OCjwmTvwOyL0N8qxsQ.md#KeepCoding_UtilityExtensions_IndexOf_T_(System_Collections_Generic_IEnumerable_T__T_System_Collections_Generic_IEqualityComparer_T_)_T 'KeepCoding.UtilityExtensions.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
