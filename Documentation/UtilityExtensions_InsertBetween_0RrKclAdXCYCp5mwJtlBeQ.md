#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.InsertBetween&lt;T&gt;(IEnumerable&lt;T&gt;, T) Method
Inserts the specified item in between each element in the input collection.
```csharp
public static System.Collections.Generic.IEnumerable<T> InsertBetween<T>(this System.Collections.Generic.IEnumerable<T> source, T extraElement);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_InsertBetween_0RrKclAdXCYCp5mwJtlBeQ.md#KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input collection.
  
<a name='KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_extraElement'></a>
`extraElement` [T](UtilityExtensions_InsertBetween_0RrKclAdXCYCp5mwJtlBeQ.md#KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
The element to insert between each consecutive pair of elements in the input collection.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_InsertBetween_0RrKclAdXCYCp5mwJtlBeQ.md#KeepCoding_UtilityExtensions_InsertBetween_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the original collection with the extra element inserted. For example, new[] { 1, 2, 3  
}.InsertBetween(0) returns { 1, 0, 2, 0, 3 }.