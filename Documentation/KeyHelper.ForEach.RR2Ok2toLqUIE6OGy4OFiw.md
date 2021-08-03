#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach(IEnumerator, Action&lt;object&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static System.Collections.IEnumerable ForEach(this System.Collections.IEnumerator iterator, System.Action<object> action);
```
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator.System.Action.object.).iterator'></a>
`iterator` [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator.System.Action.object.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to do on each item in [iterator](KeyHelper.ForEach.RR2Ok2toLqUIE6OGy4OFiw.md#KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator.System.Action.object.).iterator 'KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator, System.Action&lt;object&gt;).iterator').
  
#### Returns
[System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
[iterator](KeyHelper.ForEach.RR2Ok2toLqUIE6OGy4OFiw.md#KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator.System.Action.object.).iterator 'KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator, System.Action&lt;object&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
