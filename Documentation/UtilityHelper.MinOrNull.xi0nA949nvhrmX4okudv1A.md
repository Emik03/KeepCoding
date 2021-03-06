#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;) Method
Invokes a selector on each element of a collection and returns the minimum resulting value, or `null` if  
the sequence is empty.
```csharp
public static System.Nullable<TResult> MinOrNull<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector)
    where TResult : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).source 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).source').
  
<a name='KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult'></a>
`TResult`  
The type of the value returned by [selector](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).selector 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).selector').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the minimum value of.
  
<a name='KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A transform function to apply to each element.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TResult](UtilityHelper.MinOrNull.xi0nA949nvhrmX4okudv1A.md#KeepCoding.UtilityHelper.MinOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum value in the sequence, or `null` if the sequence is empty.
