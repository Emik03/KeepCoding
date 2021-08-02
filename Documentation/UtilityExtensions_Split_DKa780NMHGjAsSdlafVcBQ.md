#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Split&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Splits a collection into chunks of equal size. The last chunk may be smaller than [chunkSize](UtilityExtensions_Split_DKa780NMHGjAsSdlafVcBQ.md#KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_chunkSize 'KeepCoding.UtilityExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).chunkSize'), but all chunks, if any, will contain at least one item.
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Split<T>(this System.Collections.Generic.IEnumerable<T> source, int chunkSize);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_Split_DKa780NMHGjAsSdlafVcBQ.md#KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.UtilityExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_chunkSize'></a>
`chunkSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_Split_DKa780NMHGjAsSdlafVcBQ.md#KeepCoding_UtilityExtensions_Split_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.UtilityExtensions.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
