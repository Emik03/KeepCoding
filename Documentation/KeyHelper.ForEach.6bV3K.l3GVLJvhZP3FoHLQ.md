#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, Action&lt;TCurrent,int&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static TEnumerable ForEach<TEnumerable,TCurrent>(this TEnumerable iterator, System.Action<TCurrent,int> action)
    where TEnumerable : System.Collections.Generic.IEnumerable<TCurrent>
    where TCurrent : TEnumerable;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).TEnumerable'></a>
`TEnumerable`  
The type of iterator.
  
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).TCurrent'></a>
`TCurrent`  
The type of each item in the iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).iterator'></a>
`iterator` [TEnumerable](KeyHelper.ForEach.6bV3K.l3GVLJvhZP3FoHLQ.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).TEnumerable 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent,int&gt;).TEnumerable')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TCurrent](KeyHelper.ForEach.6bV3K.l3GVLJvhZP3FoHLQ.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).TCurrent 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent,int&gt;).TCurrent')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to do on each item in [iterator](KeyHelper.ForEach.6bV3K.l3GVLJvhZP3FoHLQ.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent,int&gt;).iterator').
  
#### Returns
[TEnumerable](KeyHelper.ForEach.6bV3K.l3GVLJvhZP3FoHLQ.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).TEnumerable 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent,int&gt;).TEnumerable')  
[iterator](KeyHelper.ForEach.6bV3K.l3GVLJvhZP3FoHLQ.md#KeepCoding.KeyHelper.ForEach.TEnumerable.TCurrent.(TEnumerable.System.Action.TCurrent.int.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TEnumerable,TCurrent&gt;(TEnumerable, System.Action&lt;TCurrent,int&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
