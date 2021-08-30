#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, Action&lt;TCurrent&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static TEnumerable ForEach<TEnumerable,TCurrent>(this TEnumerable iterator, System.Action<TCurrent> action)
    where TEnumerable : System.Collections.Generic.IEnumerable<TCurrent>;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).TEnumerable'></a>
`TEnumerable`  
The type of iterator.
  
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).TCurrent'></a>
`TCurrent`  
The type of each item in the iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).iterator'></a>
`iterator` [TEnumerable](KeyHelper.ForEach.m0WV5PGc4QYAuWlBWHo9iA.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).TEnumerable 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent&gt;).TEnumerable')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TCurrent](KeyHelper.ForEach.m0WV5PGc4QYAuWlBWHo9iA.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).TCurrent 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent&gt;).TCurrent')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to do on each item in [iterator](KeyHelper.ForEach.m0WV5PGc4QYAuWlBWHo9iA.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent&gt;).iterator').
  
#### Returns
[TEnumerable](KeyHelper.ForEach.m0WV5PGc4QYAuWlBWHo9iA.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).TEnumerable 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent&gt;).TEnumerable')  
[iterator](KeyHelper.ForEach.m0WV5PGc4QYAuWlBWHo9iA.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
