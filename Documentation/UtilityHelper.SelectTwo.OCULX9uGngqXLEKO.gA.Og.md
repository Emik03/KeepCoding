#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;, Func&lt;TSource,TResult&gt;) Method
Transforms every element of an input collection using two selector functions and returns a collection  
containing all the results.
```csharp
public static System.Collections.Generic.IEnumerable<TResult> SelectTwo<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector1, System.Func<TSource,TResult> selector2);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TSource'></a>
`TSource`  
Type of the elements in the source collection.
  
<a name='KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TResult'></a>
`TResult`  
Type of the results of the selector functions.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Input collection to transform.
  
<a name='KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).selector1'></a>
`selector1` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
First selector function.
  
<a name='KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).selector2'></a>
`selector2` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TSource 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Second selector function.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TResult](UtilityHelper.SelectTwo.OCULX9uGngqXLEKO.gA.Og.md#KeepCoding.UtilityHelper.SelectTwo.TSource.TResult.(System.Collections.Generic.IEnumerable.TSource..System.Func.TSource.TResult..System.Func.TSource.TResult.).TResult 'KeepCoding.UtilityHelper.SelectTwo&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the transformed elements from both selectors, thus containing twice as many elements  
as the original collection.
