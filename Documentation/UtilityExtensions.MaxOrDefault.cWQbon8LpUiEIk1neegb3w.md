#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MaxOrDefault&lt;TSource&gt;(IEnumerable&lt;TSource&gt;, TSource) Method
Returns the maximum resulting value in a sequence, or a default value if the sequence is empty.
```csharp
public static TSource MaxOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource @default=default(TSource));
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityExtensions.MaxOrDefault.cWQbon8LpUiEIk1neegb3w.md#KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).source 'KeepCoding.UtilityExtensions.MaxOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).source').
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityExtensions.MaxOrDefault.cWQbon8LpUiEIk1neegb3w.md#KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityExtensions.MaxOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the maximum value of.
  
<a name='KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).default'></a>
`default` [TSource](UtilityExtensions.MaxOrDefault.cWQbon8LpUiEIk1neegb3w.md#KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityExtensions.MaxOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
A default value to return in case the sequence is empty.
  
#### Returns
[TSource](UtilityExtensions.MaxOrDefault.cWQbon8LpUiEIk1neegb3w.md#KeepCoding.UtilityExtensions.MaxOrDefault.TSource.(System.Collections.Generic.IEnumerable.TSource..TSource).TSource 'KeepCoding.UtilityExtensions.MaxOrDefault&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, TSource).TSource')  
The maximum value in the sequence, or the specified default value if the sequence is empty.
