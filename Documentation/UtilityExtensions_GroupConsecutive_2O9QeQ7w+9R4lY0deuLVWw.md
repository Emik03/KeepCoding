#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.GroupConsecutive&lt;TItem&gt;(IEnumerable&lt;TItem&gt;, Func&lt;TItem,TItem,bool&gt;) Method
Accumulates consecutive equal elements.
```csharp
public static System.Collections.Generic.IEnumerable<KeepCoding.ConsecutiveGroup<TItem,TItem>> GroupConsecutive<TItem>(this System.Collections.Generic.IEnumerable<TItem> source, System.Func<TItem,TItem,bool> itemEquality);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem'></a>
`TItem`  
The type of items in the input sequence.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TItem](UtilityExtensions_GroupConsecutive_2O9QeQ7w+9R4lY0deuLVWw.md#KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem 'KeepCoding.UtilityExtensions.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TItem,bool&gt;).TItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input sequence from which to accumulate groups of consecutive elements.
  
<a name='KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_itemEquality'></a>
`itemEquality` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TItem](UtilityExtensions_GroupConsecutive_2O9QeQ7w+9R4lY0deuLVWw.md#KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem 'KeepCoding.UtilityExtensions.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TItem,bool&gt;).TItem')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TItem](UtilityExtensions_GroupConsecutive_2O9QeQ7w+9R4lY0deuLVWw.md#KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem 'KeepCoding.UtilityExtensions.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TItem,bool&gt;).TItem')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
An optional function to determine equality of items.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KeepCoding.ConsecutiveGroup&lt;](ConsecutiveGroup_TItem_TKey_.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TItem](UtilityExtensions_GroupConsecutive_2O9QeQ7w+9R4lY0deuLVWw.md#KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem 'KeepCoding.UtilityExtensions.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TItem,bool&gt;).TItem')[,](ConsecutiveGroup_TItem_TKey_.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[TItem](UtilityExtensions_GroupConsecutive_2O9QeQ7w+9R4lY0deuLVWw.md#KeepCoding_UtilityExtensions_GroupConsecutive_TItem_(System_Collections_Generic_IEnumerable_TItem__System_Func_TItem_TItem_bool_)_TItem 'KeepCoding.UtilityExtensions.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Func&lt;TItem,TItem,bool&gt;).TItem')[&gt;](ConsecutiveGroup_TItem_TKey_.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing each sequence of consecutive equal elements.
