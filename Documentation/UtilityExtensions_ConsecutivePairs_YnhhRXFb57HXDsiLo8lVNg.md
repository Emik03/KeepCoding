#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ConsecutivePairs&lt;T&gt;(IEnumerable&lt;T&gt;, bool) Method
Returns an enumeration of tuples containing all consecutive pairs of the elements.
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.Tuple<T,T>> ConsecutivePairs<T>(this System.Collections.Generic.IEnumerable<T> source, bool closed);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_ConsecutivePairs_YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input enumerable.
  
<a name='KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_closed'></a>
`closed` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true, an additional pair containing the last and first element is included. For example, if the source  
collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if [closed](UtilityExtensions_ConsecutivePairs_YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_closed 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).closed') is false, and { (1, 2), (2, 3), (3, 4), (4, 1) } if [closed](UtilityExtensions_ConsecutivePairs_YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_closed 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).closed') is true.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_ConsecutivePairs_YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions_ConsecutivePairs_YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding_UtilityExtensions_ConsecutivePairs_T_(System_Collections_Generic_IEnumerable_T__bool)_T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
