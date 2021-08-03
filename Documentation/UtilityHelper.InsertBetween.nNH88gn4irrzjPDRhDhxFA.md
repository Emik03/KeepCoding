#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.InsertBetween&lt;T&gt;(IEnumerable&lt;T&gt;, T) Method
Inserts the specified item in between each element in the input collection.
```csharp
public static System.Collections.Generic.IEnumerable<T> InsertBetween<T>(this System.Collections.Generic.IEnumerable<T> source, T extraElement);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.InsertBetween.nNH88gn4irrzjPDRhDhxFA.md#KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input collection.
  
<a name='KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).extraElement'></a>
`extraElement` [T](UtilityHelper.InsertBetween.nNH88gn4irrzjPDRhDhxFA.md#KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
The element to insert between each consecutive pair of elements in the input collection.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.InsertBetween.nNH88gn4irrzjPDRhDhxFA.md#KeepCoding.UtilityHelper.InsertBetween.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.InsertBetween&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the original collection with the extra element inserted. For example, new[] { 1, 2, 3  
}.InsertBetween(0) returns { 1, 0, 2, 0, 3 }.
