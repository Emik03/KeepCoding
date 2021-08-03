#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;, TResult) Method
Invokes a selector on each element of a collection and returns the maximum resulting value, or a default value  
if the sequence is empty.
```csharp
public static TResult MaxOrDefault<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector, TResult @default=default(TResult));
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).source 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).source').
  
<a name='KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult'></a>
`TResult`  
The type of the value returned by [selector](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).selector 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).selector').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the maximum value of.
  
<a name='KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A transform function to apply to each element.
  
<a name='KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).default'></a>
`default` [TResult](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')  
A default value to return in case the sequence is empty.
  
#### Returns
[TResult](UtilityHelper.MaxOrDefault.eN3WP950TlXLad712CaFwQ.md#KeepCoding.UtilityHelper.MaxOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityHelper.MaxOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')  
The maximum value in the sequence, or the specified default value if the sequence is empty.
