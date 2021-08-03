#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Include&lt;T&gt;(IEnumerable&lt;T&gt;, int[]) Method
Removes the elements whose index does not match any of the indices.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Include<T>(this System.Collections.Generic.IEnumerable<T> source, params int[] indices);
```
#### Type parameters
<a name='KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).T'></a>
`T`  
The datatype of both the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Parameters
<a name='KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Include.0FEdskjQVmCS+GPCjShpsw.md#KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).T 'KeepCoding.Helper.Include&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to be modified.
  
<a name='KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).indices'></a>
`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The indices to include in [source](Helper.Include.0FEdskjQVmCS+GPCjShpsw.md#KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).source 'KeepCoding.Helper.Include&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).source').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Include.0FEdskjQVmCS+GPCjShpsw.md#KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).T 'KeepCoding.Helper.Include&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](Helper.Include.0FEdskjQVmCS+GPCjShpsw.md#KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).source 'KeepCoding.Helper.Include&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).source'), but without the element indexing [indices](Helper.Include.0FEdskjQVmCS+GPCjShpsw.md#KeepCoding.Helper.Include.T.(System.Collections.Generic.IEnumerable.T..int..).indices 'KeepCoding.Helper.Include&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).indices').
