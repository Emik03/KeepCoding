#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Replace&lt;T&gt;(IEnumerable&lt;T&gt;, int, T) Method
Replaces an index in the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') and returns the new one.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Replace<T>(this System.Collections.Generic.IEnumerable<T> source, int index, T value);
```
#### Type parameters
<a name='KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_T'></a>
`T`  
The type of the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').
  
#### Parameters
<a name='KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The initial source.
  
<a name='KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index to change.
  
<a name='KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_value'></a>
`value` [T](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')  
The value to replace at [source](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_source 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).source')'s [index](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_index 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).index') element.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_source 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).source') but the [index](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_index 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).index') element is [value](KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T).md#KeepCoding_Helper_Replace_T_(System_Collections_Generic_IEnumerable_T__int_T)_value 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).value') instead.
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
