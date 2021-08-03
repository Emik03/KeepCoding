#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MinOrDefault&lt;TSource&gt;(IEnumerable&lt;TSource&gt;, TSource) Method
Returns the minimum resulting value in a sequence, or a default value if the sequence is empty.
```csharp
public static TSource MinOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource @default=default(TSource));
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityHelper.MinOrDefault.FiWASck6kYOOgizcpqd3ig.md#KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).source 'KeepCoding.UtilityHelper.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.MinOrDefault.FiWASck6kYOOgizcpqd3ig.md#KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityHelper.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the minimum value of.
  
<a name='KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).default'></a>
`default` [TSource](UtilityHelper.MinOrDefault.FiWASck6kYOOgizcpqd3ig.md#KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityHelper.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
A default value to return in case the sequence is empty.
  
#### Returns
[TSource](UtilityHelper.MinOrDefault.FiWASck6kYOOgizcpqd3ig.md#KeepCoding.UtilityHelper.MinOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityHelper.MinOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
The minimum value in the sequence, or the specified default value if the sequence is empty.
