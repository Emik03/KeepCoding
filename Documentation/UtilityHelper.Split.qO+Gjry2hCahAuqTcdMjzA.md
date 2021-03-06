#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Split&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Splits a collection into chunks of equal size. The last chunk may be smaller than [chunkSize](UtilityHelper.Split.qO+Gjry2hCahAuqTcdMjzA.md#KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).chunkSize 'KeepCoding.UtilityHelper.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).chunkSize'), but all chunks, if any, will contain at least one item.
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Split<T>(this System.Collections.Generic.IEnumerable<T> source, int chunkSize);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.Split.qO+Gjry2hCahAuqTcdMjzA.md#KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).T 'KeepCoding.UtilityHelper.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).chunkSize'></a>
`chunkSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.Split.qO+Gjry2hCahAuqTcdMjzA.md#KeepCoding.UtilityHelper.Split.T.(System.Collections.Generic.IEnumerable.T..int).T 'KeepCoding.UtilityHelper.Split&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
