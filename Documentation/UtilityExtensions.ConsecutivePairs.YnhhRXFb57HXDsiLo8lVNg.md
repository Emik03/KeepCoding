#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ConsecutivePairs&lt;T&gt;(IEnumerable&lt;T&gt;, bool) Method
Returns an enumeration of tuples containing all consecutive pairs of the elements.
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.Tuple<T,T>> ConsecutivePairs<T>(this System.Collections.Generic.IEnumerable<T> source, bool closed);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions.ConsecutivePairs.YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input enumerable.
  
<a name='KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).closed'></a>
`closed` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true, an additional pair containing the last and first element is included. For example, if the source  
collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if [closed](UtilityExtensions.ConsecutivePairs.YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).closed 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).closed') is false, and { (1, 2), (2, 3), (3, 4), (4, 1) } if [closed](UtilityExtensions.ConsecutivePairs.YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).closed 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).closed') is true.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions.ConsecutivePairs.YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T](UtilityExtensions.ConsecutivePairs.YnhhRXFb57HXDsiLo8lVNg.md#KeepCoding.UtilityExtensions.ConsecutivePairs.T.(System.Collections.Generic.IEnumerable.T..bool).T 'KeepCoding.UtilityExtensions.ConsecutivePairs&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool).T')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
