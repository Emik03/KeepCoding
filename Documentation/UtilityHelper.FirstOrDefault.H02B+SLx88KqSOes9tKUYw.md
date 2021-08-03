#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.FirstOrDefault&lt;T&gt;(IEnumerable&lt;T&gt;, T) Method
Returns the first element of a sequence, or a default value if the sequence contains no elements.
```csharp
public static T FirstOrDefault<T>(this System.Collections.Generic.IEnumerable<T> source, T @default);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).T'></a>
`T`  
The type of the elements of [source](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
<a name='KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).default'></a>
`default` [T](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
The default value to return if the sequence contains no elements.
  
#### Returns
[T](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).T 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
[default](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).default 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).default') if [source](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source') is empty; otherwise, the first element in [source](UtilityHelper.FirstOrDefault.H02B+SLx88KqSOes9tKUYw.md#KeepCoding.UtilityHelper.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..T).source 'KeepCoding.UtilityHelper.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source').
