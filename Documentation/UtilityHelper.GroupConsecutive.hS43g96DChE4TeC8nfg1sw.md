#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.GroupConsecutive&lt;TItem&gt;(IEnumerable&lt;TItem&gt;, IEqualityComparer&lt;TItem&gt;) Method
Accumulates consecutive equal elements.
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.ConsecutiveGroup<TItem,TItem>> GroupConsecutive<TItem>(this System.Collections.Generic.IEnumerable<TItem> source, System.Collections.Generic.IEqualityComparer<TItem> itemComparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).TItem'></a>
`TItem`  
The type of items in the input sequence.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TItem](UtilityHelper.GroupConsecutive.hS43g96DChE4TeC8nfg1sw.md#KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).TItem 'KeepCoding.UtilityHelper.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Collections.Generic.IEqualityComparer&lt;TItem&gt;).TItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input sequence from which to accumulate groups of consecutive elements.
  
<a name='KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).itemComparer'></a>
`itemComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TItem](UtilityHelper.GroupConsecutive.hS43g96DChE4TeC8nfg1sw.md#KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).TItem 'KeepCoding.UtilityHelper.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Collections.Generic.IEqualityComparer&lt;TItem&gt;).TItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
An optional equality comparer to determine item equality by.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.ConsecutiveGroup&lt;](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TItem](UtilityHelper.GroupConsecutive.hS43g96DChE4TeC8nfg1sw.md#KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).TItem 'KeepCoding.UtilityHelper.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Collections.Generic.IEqualityComparer&lt;TItem&gt;).TItem')[,](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TItem](UtilityHelper.GroupConsecutive.hS43g96DChE4TeC8nfg1sw.md#KeepCoding.UtilityHelper.GroupConsecutive.TItem.(System.Collections.Generic.IEnumerable.TItem..System.Collections.Generic.IEqualityComparer.TItem.).TItem 'KeepCoding.UtilityHelper.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Collections.Generic.IEqualityComparer&lt;TItem&gt;).TItem')[&gt;](ConsecutiveGroup.TItem.TKey..md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing each sequence of consecutive equal elements.
