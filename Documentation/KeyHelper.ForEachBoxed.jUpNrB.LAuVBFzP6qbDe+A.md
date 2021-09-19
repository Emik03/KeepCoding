#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEachBoxed&lt;TEnumerable&gt;(TEnumerable, Action&lt;object&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static TEnumerable ForEachBoxed<TEnumerable>(this TEnumerable iterator, System.Action<object> action)
    where TEnumerable : System.Collections.IEnumerable;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).TEnumerable'></a>
`TEnumerable`  
The type of iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).iterator'></a>
`iterator` [TEnumerable](KeyHelper.ForEachBoxed.jUpNrB.LAuVBFzP6qbDe+A.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).TEnumerable 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerable&gt;(TEnumerable, System.Action&lt;object&gt;).TEnumerable')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to do on each item in [iterator](KeyHelper.ForEachBoxed.jUpNrB.LAuVBFzP6qbDe+A.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).iterator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerable&gt;(TEnumerable, System.Action&lt;object&gt;).iterator').
  
#### Returns
[TEnumerable](KeyHelper.ForEachBoxed.jUpNrB.LAuVBFzP6qbDe+A.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).TEnumerable 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerable&gt;(TEnumerable, System.Action&lt;object&gt;).TEnumerable')  
[iterator](KeyHelper.ForEachBoxed.jUpNrB.LAuVBFzP6qbDe+A.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerable.(TEnumerable.System.Action.object.).iterator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerable&gt;(TEnumerable, System.Action&lt;object&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
