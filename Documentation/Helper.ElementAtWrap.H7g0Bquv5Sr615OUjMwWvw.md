#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.ElementAtWrap&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Returns the element of an array, pretending that the array wraps around or is circular.  
```csharp
public static T ElementAtWrap<T>(this System.Collections.Generic.IEnumerable<T> source, int index);
```
#### Type parameters
<a name='KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).T'></a>
`T`  
The type of the array.
  
#### Parameters
<a name='KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.ElementAtWrap.H7g0Bquv5Sr615OUjMwWvw.md#KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).T 'KeepCoding.Helper.ElementAtWrap&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array itself.
  
<a name='KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index, which will wrap around if it's larger than the array.
  
#### Returns
[T](Helper.ElementAtWrap.H7g0Bquv5Sr615OUjMwWvw.md#KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).T 'KeepCoding.Helper.ElementAtWrap&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')  
The element in [source](Helper.ElementAtWrap.H7g0Bquv5Sr615OUjMwWvw.md#KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).source 'KeepCoding.Helper.ElementAtWrap&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).source') using [index](Helper.ElementAtWrap.H7g0Bquv5Sr615OUjMwWvw.md#KeepCoding.Helper.ElementAtWrap.T.(System.Collections.Generic.IEnumerable.T..int).index 'KeepCoding.Helper.ElementAtWrap&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).index') with rem-euclid modulo.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
