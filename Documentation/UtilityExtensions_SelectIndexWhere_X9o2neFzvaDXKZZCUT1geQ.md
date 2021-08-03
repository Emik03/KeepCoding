#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SelectIndexWhere&lt;T&gt;(IEnumerable&lt;T&gt;, Predicate&lt;T&gt;) Method
Returns a collection of integers containing the indexes at which the elements of the source collection match  
the given predicate.
```csharp
public static System.Collections.Generic.IEnumerable<int> SelectIndexWhere<T>(this System.Collections.Generic.IEnumerable<T> source, System.Predicate<T> predicate);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T'></a>
`T`  
The type of elements in the collection.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SelectIndexWhere_X9o2neFzvaDXKZZCUT1geQ.md#KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.UtilityExtensions.SelectIndexWhere&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source collection whose elements are tested using [predicate](UtilityExtensions_SelectIndexWhere_X9o2neFzvaDXKZZCUT1geQ.md#KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_predicate 'KeepCoding.UtilityExtensions.SelectIndexWhere&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).predicate').
  
<a name='KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_predicate'></a>
`predicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](UtilityExtensions_SelectIndexWhere_X9o2neFzvaDXKZZCUT1geQ.md#KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.UtilityExtensions.SelectIndexWhere&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The predicate against which the elements of [source](UtilityExtensions_SelectIndexWhere_X9o2neFzvaDXKZZCUT1geQ.md#KeepCoding_UtilityExtensions_SelectIndexWhere_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_source 'KeepCoding.UtilityExtensions.SelectIndexWhere&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).source') are tested.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the zero-based indexes of all the matching elements, in increasing order.