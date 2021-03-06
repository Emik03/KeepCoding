#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Subsequences&lt;T&gt;(IEnumerable&lt;T&gt;, int, Nullable&lt;int&gt;) Method
Returns all subsequences of the specified lengths of the input [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Subsequences<T>(this System.Collections.Generic.IEnumerable<T> source, int minLength=0, System.Nullable<int> maxLength=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.Subsequences.qhawDqbzSLDSp0D56k2I2Q.md#KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).T 'KeepCoding.UtilityHelper.Subsequences&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Nullable&lt;int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequence of items to generate subsequences of.
  
<a name='KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).minLength'></a>
`minLength` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The minimum length of a subsequence to return. Must be between 0 and the length of the input collection.
  
<a name='KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).maxLength'></a>
`maxLength` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum length of a subsequence to return. Must be between 0 and the length of the input collection. If  
`null` is specified, the size of the input collection is used.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.Subsequences.qhawDqbzSLDSp0D56k2I2Q.md#KeepCoding.UtilityHelper.Subsequences.T.(System.Collections.Generic.IEnumerable.T..int.System.Nullable.int.).T 'KeepCoding.UtilityHelper.Subsequences&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Nullable&lt;int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing all matching subsequences of the input [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
