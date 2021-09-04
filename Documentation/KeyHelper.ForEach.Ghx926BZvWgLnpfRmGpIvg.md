#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, Action&lt;TKey,TValue,int&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static TDictionary ForEach<TDictionary,TKey,TValue>(this TDictionary iterator, System.Action<TKey,TValue,int> action)
    where TDictionary : System.Collections.Generic.IDictionary<TKey, TValue>;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TDictionary'></a>
`TDictionary`  
The type of iterator.
  
<a name='KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TKey'></a>
`TKey`  
The type of each key in the iterator.
  
<a name='KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TValue'></a>
`TValue`  
The type of each value in the iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).iterator'></a>
`iterator` [TDictionary](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TDictionary 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).TDictionary')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TKey](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TKey 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TValue](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TValue 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')  
The action to do on each item in [iterator](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).iterator').
  
#### Returns
[TDictionary](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).TDictionary 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).TDictionary')  
[iterator](KeyHelper.ForEach.Ghx926BZvWgLnpfRmGpIvg.md#KeepCoding.KeyHelper.ForEach.TDictionary.TKey.TValue.(TDictionary.System.Action.TKey.TValue.int.).iterator 'KeepCoding.KeyHelper.ForEach&lt;TDictionary,TKey,TValue&gt;(TDictionary, System.Action&lt;TKey,TValue,int&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
