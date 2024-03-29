#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ConsecutiveGroup&lt;TItem,TKey&gt; Class
Encapsulates information about a group generated by [GroupConsecutive&lt;TItem&gt;(IEnumerable&lt;TItem&gt;, IEqualityComparer&lt;TItem&gt;)](UtilityHelper.GroupConsecutive.hS43g96DChE4TeC8nfg1sw.md 'KeepCoding.UtilityHelper.GroupConsecutive&lt;TItem&gt;(System.Collections.Generic.IEnumerable&lt;TItem&gt;, System.Collections.Generic.IEqualityComparer&lt;TItem&gt;)') and its overloads.  
```csharp
public sealed class ConsecutiveGroup<TItem,TKey> :
System.Collections.Generic.IEnumerable<TItem>,
System.Collections.IEnumerable
```
#### Type parameters
<a name='KeepCoding.ConsecutiveGroup.TItem.TKey..TItem'></a>
`TItem`  
Type of the elements in the sequence.
  
<a name='KeepCoding.ConsecutiveGroup.TItem.TKey..TKey'></a>
`TKey`  
Type of the key by which elements were compared.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConsecutiveGroup&lt;TItem,TKey&gt;  

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TItem](ConsecutiveGroup.TItem.TKey..md#KeepCoding.ConsecutiveGroup.TItem.TKey..TItem 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.TItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Properties | |
| :--- | :--- |
| [Count](ConsecutiveGroup.TItem.TKey..Count.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.Count') | Size of the group.<br/> |
| [Index](ConsecutiveGroup.TItem.TKey..Index.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.Index') | Index in the original sequence where the group started.<br/> |
| [Key](ConsecutiveGroup.TItem.TKey..Key.md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.Key') | The key by which the items in this group are deemed equal.<br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](ConsecutiveGroup.TItem.TKey..GetEnumerator().md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.GetEnumerator()') | Returns an enumerator that iterates through the collection. |
| [ToString()](ConsecutiveGroup.TItem.TKey..ToString().md 'KeepCoding.ConsecutiveGroup&lt;TItem,TKey&gt;.ToString()') | Returns a string that represents this group’s key and its count.<br/> |
