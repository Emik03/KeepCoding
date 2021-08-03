#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(IEnumerable&lt;T&gt;, bool, Func&lt;T,T,TResult&gt;) Method
Enumerates all consecutive pairs of the elements.
```csharp
public static System.Collections.Generic.IEnumerable<TResult> SelectConsecutivePairs<T,TResult>(this System.Collections.Generic.IEnumerable<T> source, bool closed, System.Func<T,T,TResult> selector);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).T'></a>
`T`  
  
<a name='KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).T 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input enumerable.
  
<a name='KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).closed'></a>
`closed` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true, an additional pair containing the last and first element is included. For example, if the source  
collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if [closed](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).closed 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).closed') is `false`, and { (1, 2), (2, 3), (3, 4), (4, 1) } if [closed](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).closed 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).closed') is  
`true`.
  
<a name='KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).T 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).T 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).TResult 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The selector function to run each consecutive pair through.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TResult](UtilityHelper.SelectConsecutivePairs.inZC9uX2njTIhrQxFVJbjw.md#KeepCoding.UtilityHelper.SelectConsecutivePairs.T.TResult.(System.Collections.Generic.IEnumerable.T..bool.System.Func.T.T.TResult.).TResult 'KeepCoding.UtilityHelper.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
