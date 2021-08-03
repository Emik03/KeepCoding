#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.AsEnumerable&lt;T&gt;(IEnumerator&lt;T&gt;) Method
Converts an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').  
```csharp
public static System.Collections.Generic.IEnumerable<T> AsEnumerable<T>(this System.Collections.Generic.IEnumerator<T> source);
```
#### Type parameters
<a name='KeepCoding.Helper.AsEnumerable.T.(System.Collections.Generic.IEnumerator.T.).T'></a>
`T`  
The parameter and return type.
  
#### Parameters
<a name='KeepCoding.Helper.AsEnumerable.T.(System.Collections.Generic.IEnumerator.T.).source'></a>
`source` [System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](Helper.AsEnumerable.VXb6Ujxlh0L56clvfLe9vg.md#KeepCoding.Helper.AsEnumerable.T.(System.Collections.Generic.IEnumerator.T.).T 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
The [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to convert.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.AsEnumerable.VXb6Ujxlh0L56clvfLe9vg.md#KeepCoding.Helper.AsEnumerable.T.(System.Collections.Generic.IEnumerator.T.).T 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](Helper.AsEnumerable.VXb6Ujxlh0L56clvfLe9vg.md#KeepCoding.Helper.AsEnumerable.T.(System.Collections.Generic.IEnumerator.T.).source 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).source') as an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
