### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Exclude&lt;T&gt;(IEnumerable&lt;T&gt;, int[]) Method
Removes the elements whose index matches any of the indices.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Exclude<T>(this System.Collections.Generic.IEnumerable<T> source, params int[] indices);
```
#### Type parameters
<a name='KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_T'></a>
`T`  
The datatype of both the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Parameters
<a name='KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__).md#KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_T 'KeepCoding.Helper.Exclude&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to be modified.
  
<a name='KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_indices'></a>
`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The indices to exclude from [source](KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__).md#KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_source 'KeepCoding.Helper.Exclude&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).source').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__).md#KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_T 'KeepCoding.Helper.Exclude&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__).md#KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_source 'KeepCoding.Helper.Exclude&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).source'), but without the element indexing [indices](KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__).md#KeepCoding_Helper_Exclude_T_(System_Collections_Generic_IEnumerable_T__int__)_indices 'KeepCoding.Helper.Exclude&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int[]).indices').
