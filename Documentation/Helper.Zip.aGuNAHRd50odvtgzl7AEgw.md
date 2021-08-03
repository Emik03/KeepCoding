#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Zip&lt;T1,T2&gt;(IEnumerable&lt;T1&gt;, IEnumerable&lt;T2&gt;) Method
Produces a sequence of tuples with elements from the two specified sequences.  
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.Tuple<T1,T2>> Zip<T1,T2>(this System.Collections.Generic.IEnumerable<T1> first, System.Collections.Generic.IEnumerable<T2> second);
```
#### Type parameters
<a name='KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T1'></a>
`T1`  
The type of the elements of the first input sequence.
  
<a name='KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T2'></a>
`T2`  
The type of the elements of the second input sequence.
  
#### Parameters
<a name='KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).first'></a>
`first` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T1](Helper.Zip.aGuNAHRd50odvtgzl7AEgw.md#KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T1 'KeepCoding.Helper.Zip&lt;T1,T2&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The first sequence to merge.
  
<a name='KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).second'></a>
`second` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T2](Helper.Zip.aGuNAHRd50odvtgzl7AEgw.md#KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T2 'KeepCoding.Helper.Zip&lt;T1,T2&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The second sequence to merge.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T1](Helper.Zip.aGuNAHRd50odvtgzl7AEgw.md#KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T1 'KeepCoding.Helper.Zip&lt;T1,T2&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;).T1')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T2](Helper.Zip.aGuNAHRd50odvtgzl7AEgw.md#KeepCoding.Helper.Zip.T1.T2.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2.).T2 'KeepCoding.Helper.Zip&lt;T1,T2&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;).T2')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of tuples with elements taken from the first and second sequences, in that order.
