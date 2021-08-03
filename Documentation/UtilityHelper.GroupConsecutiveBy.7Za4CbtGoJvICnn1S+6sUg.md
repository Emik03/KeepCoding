#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(IEnumerable&lt;TItem&gt;, Func&lt;TItem,TKey&gt;, IEqualityComparer&lt;TKey&gt;) Method
Accumulates consecutive elements that are equal when processed by a selector.
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.ConsecutiveGroup<TItem,TKey>> GroupConsecutiveBy<TItem,TKey>(this System.Collections.Generic.IEnumerable<TItem> source, System.Func<TItem,TKey> selector, System.Collections.Generic.IEqualityComparer<TKey> keyComparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TItem'></a>
`TItem`  
The type of items in the input sequence.
  
<a name='KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TKey'></a>
`TKey`  
The return type of the [selector](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).selector 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).selector') function.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TItem](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TItem 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input sequence from which to accumulate groups of consecutive elements.
  
<a name='KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TItem](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TItem 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TItem')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TKey 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A function to transform each item into a key which is compared for equality.
  
<a name='KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).keyComparer'></a>
`keyComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TKey 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
An optional equality comparer for the keys returned by [selector](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).selector 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).selector').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.ConsecutiveGroup&lt;](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TItem](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TItem 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TItem')[,](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TKey](UtilityHelper.GroupConsecutiveBy.7Za4CbtGoJvICnn1S+6sUg.md#KeepCoding.UtilityHelper.GroupConsecutiveBy.TItem.TKey.(System.Collections.Generic.IEnumerable.TItem..System.Func.TItem.TKey..System.Collections.Generic.IEqualityComparer.TKey.).TKey 'KeepCoding.UtilityHelper.GroupConsecutiveBy&lt;TItem,TKey&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing each sequence of consecutive equal elements.