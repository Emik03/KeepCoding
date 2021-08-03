#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Replace&lt;T&gt;(IEnumerable&lt;T&gt;, int, T) Method
Replaces an index in the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') and returns the new one.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Replace<T>(this System.Collections.Generic.IEnumerable<T> source, int index, T value);
```
#### Type parameters
<a name='KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).T'></a>
`T`  
The type of the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').
  
#### Parameters
<a name='KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The initial source.
  
<a name='KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index to change.
  
<a name='KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).value'></a>
`value` [T](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')  
The value to replace at [source](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).source 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).source')'s [index](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).index 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).index') element.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).T 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).source 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).source') but the [index](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).index 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).index') element is [value](Helper.Replace.2Ghol2smZYonmDtBL8jmnQ.md#KeepCoding.Helper.Replace.T.(System.Collections.Generic.IEnumerable.T..int.T).value 'KeepCoding.Helper.Replace&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, T).value') instead.
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
