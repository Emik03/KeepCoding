#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Prepend&lt;T&gt;(IEnumerable&lt;T&gt;, T) Method
Prepends the element provided to the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
```csharp
public static System.Collections.Generic.IEnumerable<T> Prepend<T>(this System.Collections.Generic.IEnumerable<T> source, T item);
```
#### Type parameters
<a name='KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_T'></a>
`T`  
The datatype of both the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Parameters
<a name='KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to be modified.
  
<a name='KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_item'></a>
`item` [T](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
The element to append to the [source](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_source 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_source 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source'), but with an added [item](KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T).md#KeepCoding_Helper_Prepend_T_(System_Collections_Generic_IEnumerable_T__T)_item 'KeepCoding.Helper.Prepend&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).item') as the first index.
