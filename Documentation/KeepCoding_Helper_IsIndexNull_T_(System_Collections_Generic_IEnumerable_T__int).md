### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.IsIndexNull&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Determines if the index is pointing to null in any way.  
```csharp
public static bool IsIndexNull<T>(this System.Collections.Generic.IEnumerable<T> source, int index);
```
#### Type parameters
<a name='KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array to index with.
  
<a name='KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [source](KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_source 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).source') is null, if [index](KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_IsIndexNull_T_(System_Collections_Generic_IEnumerable_T__int)_index 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).index') is out of range, or if the element is null.
