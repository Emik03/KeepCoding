#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Slice&lt;T&gt;(IEnumerable&lt;T&gt;, int, int) Method
Returns a slice of an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
```csharp
public static System.Collections.Generic.IEnumerable<T> Slice<T>(this System.Collections.Generic.IEnumerable<T> source, int start, int count);
```
#### Type parameters
<a name='KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).T'></a>
`T`  
The type of the [source](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).source 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).source') and return type.
  
#### Parameters
<a name='KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).T 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to take a slice of.
  
<a name='KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).start'></a>
`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the slice.
  
<a name='KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of items to take.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).T 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A slice of [source](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).source 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).source') based on [start](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).start 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).start') and [count](Helper.Slice.IlLeCOc6zOKHWgTws+q+Ng.md#KeepCoding.Helper.Slice.T.(System.Collections.Generic.IEnumerable.T..int.int).count 'KeepCoding.Helper.Slice&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, int).count').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
