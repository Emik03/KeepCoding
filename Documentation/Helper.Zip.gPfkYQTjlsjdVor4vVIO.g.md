#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Zip&lt;T1,T2,TResult&gt;(IEnumerable&lt;T1&gt;, IEnumerable&lt;T2&gt;, Func&lt;T1,T2,TResult&gt;) Method
Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.  
```csharp
public static System.Collections.Generic.IEnumerable<TResult> Zip<T1,T2,TResult>(this System.Collections.Generic.IEnumerable<T1> first, System.Collections.Generic.IEnumerable<T2> second, System.Func<T1,T2,TResult> selector);
```
#### Type parameters
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T1'></a>
`T1`  
The type of the elements of the first input sequence.
  
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T2'></a>
`T2`  
The type of the elements of the second input sequence.
  
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).TResult'></a>
`TResult`  
The type of the elements of the result sequence.
  
#### Parameters
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).first'></a>
`first` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T1](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T1 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The first sequence to merge.
  
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).second'></a>
`second` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T2](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T2 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The second sequence to merge.
  
<a name='KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T1 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).T2 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).TResult 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
A function that specifies how to merge the elements from the two sequences.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TResult](Helper.Zip.gPfkYQTjlsjdVor4vVIO.g.md#KeepCoding.Helper.Zip.T1.T2.TResult.(System.Collections.Generic.IEnumerable.T1..System.Collections.Generic.IEnumerable.T2..System.Func.T1.T2.TResult.).TResult 'KeepCoding.Helper.Zip&lt;T1,T2,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T1&gt;, System.Collections.Generic.IEnumerable&lt;T2&gt;, System.Func&lt;T1,T2,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') that contains merged elements of two input sequences.
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
