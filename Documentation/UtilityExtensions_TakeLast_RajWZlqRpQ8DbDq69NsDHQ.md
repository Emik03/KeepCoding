#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.TakeLast&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Returns a collection containing only the last [count](UtilityExtensions_TakeLast_RajWZlqRpQ8DbDq69NsDHQ.md#KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_count 'KeepCoding.UtilityExtensions.TakeLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).count') items of the input collection. This  
method enumerates the entire collection to the end once before returning. Note also that the memory usage of  
this method is proportional to [count](UtilityExtensions_TakeLast_RajWZlqRpQ8DbDq69NsDHQ.md#KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_count 'KeepCoding.UtilityExtensions.TakeLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).count').
```csharp
public static System.Collections.Generic.IEnumerable<T> TakeLast<T>(this System.Collections.Generic.IEnumerable<T> source, int count);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_TakeLast_RajWZlqRpQ8DbDq69NsDHQ.md#KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.UtilityExtensions.TakeLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_TakeLast_RajWZlqRpQ8DbDq69NsDHQ.md#KeepCoding_UtilityExtensions_TakeLast_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.UtilityExtensions.TakeLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
