#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;) Method
Invokes a selector on each element of a collection and returns the maximum resulting value, or `null` if  
the sequence is empty.
```csharp
public static System.Nullable<TResult> MaxOrNull<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector)
    where TResult : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).source 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).source').
  
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult'></a>
`TResult`  
The type of the value returned by [selector](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).selector 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).selector').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the maximum value of.
  
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A transform function to apply to each element.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TResult](UtilityHelper.MaxOrNull.5II8qvYHQHCDAwO3cOqCDg.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum value in the sequence, or `null` if the sequence is empty.
