#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsIndexNull&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Determines if the index is pointing to null in any way.  
```csharp
public static bool IsIndexNull<T>(this System.Collections.Generic.IEnumerable<T> source, int index);
```
#### Type parameters
<a name='KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.IsIndexNull.2mY7yVgk8UbAh+mS4QJinA.md#KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).T 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array to index with.
  
<a name='KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [source](Helper.IsIndexNull.2mY7yVgk8UbAh+mS4QJinA.md#KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).source 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).source') is null, if [index](Helper.IsIndexNull.2mY7yVgk8UbAh+mS4QJinA.md#KeepCoding.Helper.IsIndexNull.T.(System.Collections.Generic.IEnumerable.T..int).index 'KeepCoding.Helper.IsIndexNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).index') is out of range, or if the element is null.
