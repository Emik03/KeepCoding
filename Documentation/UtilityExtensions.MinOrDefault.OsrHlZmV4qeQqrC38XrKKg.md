#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;, TResult) Method
Invokes a selector on each element of a collection and returns the minimum resulting value, or a default value  
if the sequence is empty.
```csharp
public static TResult MinOrDefault<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector, TResult @default=default(TResult));
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).source 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).source').
  
<a name='KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult'></a>
`TResult`  
The type of the value returned by [selector](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).selector 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).selector').
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the minimum value of.
  
<a name='KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TSource 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A transform function to apply to each element.
  
<a name='KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).default'></a>
`default` [TResult](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')  
A default value to return in case the sequence is empty.
  
#### Returns
[TResult](UtilityExtensions.MinOrDefault.OsrHlZmV4qeQqrC38XrKKg.md#KeepCoding.UtilityExtensions.MinOrDefault.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..TResult).TResult 'KeepCoding.UtilityExtensions.MinOrDefault&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, TResult).TResult')  
The minimum value in the sequence, or the specified default value if the sequence is empty.
