#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(IEnumerable&lt;T&gt;, T, T) Method
Inserts the [comma](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_comma 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).comma') item in between each element in the input collection except between the  
second-last and last, where it inserts [and](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_and 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).and') instead.
```csharp
public static System.Collections.Generic.IEnumerable<T> InsertBetweenWithAnd<T>(this System.Collections.Generic.IEnumerable<T> source, T comma, T and);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_T 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input collection.
  
<a name='KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_comma'></a>
`comma` [T](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_T 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')  
The element to insert between each consecutive pair of elements in the input collection except between the  
second-last and last.
  
<a name='KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_and'></a>
`and` [T](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_T 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')  
The element to insert between the second-last and last element of the input collection.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_InsertBetweenWithAnd_r6OPOxVZFDJmZiYdmO4ISQ.md#KeepCoding_UtilityExtensions_InsertBetweenWithAnd_T_(System_Collections_Generic_IEnumerable_T__T_T)_T 'KeepCoding.UtilityExtensions.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the original collection with the extra element inserted. For example, new[] { "a",  
"b", "c" }.InsertBetweenWithAnd(", ", " and ") returns { "a", ", ", "b", " and ", "c" }.
