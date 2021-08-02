#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MinOrDefault&lt;TSource&gt;(IEnumerable&lt;TSource&gt;, TSource) Method
Returns the minimum resulting value in a sequence, or a default value if the sequence is empty.
```csharp
public static TSource MinOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource @default=default(TSource));
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_TSource'></a>
`TSource`  
The type of the elements of [source](UtilityExtensions_MinOrDefault_cKWxN3Zlumgbv_iHd6COYQ.md#KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_source 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).source').
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityExtensions_MinOrDefault_cKWxN3Zlumgbv_iHd6COYQ.md#KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_TSource 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the minimum value of.
  
<a name='KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_default'></a>
`default` [TSource](UtilityExtensions_MinOrDefault_cKWxN3Zlumgbv_iHd6COYQ.md#KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_TSource 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
A default value to return in case the sequence is empty.
  
#### Returns
[TSource](UtilityExtensions_MinOrDefault_cKWxN3Zlumgbv_iHd6COYQ.md#KeepCoding_UtilityExtensions_MinOrDefault_TSource_(System_Collections_Generic_IEnumerable_TSource__TSource)_TSource 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
The minimum value in the sequence, or the specified default value if the sequence is empty.
