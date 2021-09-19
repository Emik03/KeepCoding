#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEachBoxed&lt;TEnumerator&gt;(TEnumerator, Action&lt;object,int&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static TEnumerator ForEachBoxed<TEnumerator>(this TEnumerator iterator, System.Action<object,int> action)
    where TEnumerator : System.Collections.IEnumerable;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).TEnumerator'></a>
`TEnumerator`  
The type of iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).iterator'></a>
`iterator` [TEnumerator](KeyHelper.ForEachBoxed.z97VrXIFDD4PLnKZqiAagA.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).TEnumerator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerator&gt;(TEnumerator, System.Action&lt;object,int&gt;).TEnumerator')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to do on each item in [iterator](KeyHelper.ForEachBoxed.z97VrXIFDD4PLnKZqiAagA.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).iterator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerator&gt;(TEnumerator, System.Action&lt;object,int&gt;).iterator').
  
#### Returns
[TEnumerator](KeyHelper.ForEachBoxed.z97VrXIFDD4PLnKZqiAagA.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).TEnumerator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerator&gt;(TEnumerator, System.Action&lt;object,int&gt;).TEnumerator')  
[iterator](KeyHelper.ForEachBoxed.z97VrXIFDD4PLnKZqiAagA.md#KeepCoding.KeyHelper.ForEachBoxed.TEnumerator.(TEnumerator.System.Action.object.int.).iterator 'KeepCoding.KeyHelper.ForEachBoxed&lt;TEnumerator&gt;(TEnumerator, System.Action&lt;object,int&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
