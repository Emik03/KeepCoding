### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Slice&lt;T&gt;(IEnumerable&lt;T&gt;, int, int) Method
Returns a slice of an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
```csharp
public static System.Collections.Generic.IEnumerable<T> Slice<T>(this System.Collections.Generic.IEnumerable<T> source, int start, int count);
```
#### Type parameters
<a name='KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_T'></a>
`T`  
The type of the [source](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_source 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).source') and return type.
  
#### Parameters
<a name='KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_T 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to take a slice of.
  
<a name='KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_start'></a>
`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the slice.
  
<a name='KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of items to take.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_T 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A slice of [source](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_source 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).source') based on [start](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_start 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).start') and [count](KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int).md#KeepCoding_Helper_Slice_T_(System_Collections_Generic_IEnumerable_T__int_int)_count 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).count').
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
