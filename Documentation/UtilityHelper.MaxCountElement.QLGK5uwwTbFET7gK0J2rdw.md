#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MaxCountElement&lt;T&gt;(IEnumerable&lt;T&gt;, IEqualityComparer&lt;T&gt;) Method
Determines which element occurs the most often in the specified input sequence.
```csharp
public static T MaxCountElement<T>(this System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
Type of elements in the input sequence.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.MaxCountElement.QLGK5uwwTbFET7gK0J2rdw.md#KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.MaxCountElement&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Sequence to find most common element in.
  
<a name='KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityHelper.MaxCountElement.QLGK5uwwTbFET7gK0J2rdw.md#KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.MaxCountElement&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer to compare elements by.
  
#### Returns
[T](UtilityHelper.MaxCountElement.QLGK5uwwTbFET7gK0J2rdw.md#KeepCoding.UtilityHelper.MaxCountElement.T.(System.Collections.Generic.IEnumerable.T..System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.MaxCountElement&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')  
Of all elements that occur the most number of times, the one whose last instance occurs soonest in the  
sequence.
