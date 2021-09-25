#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')
## MonoRandom.Shuffle&lt;T&gt;(T, bool) Method
Shuffles a list using an in-place algorithm; the original list is modified.  
```csharp
public T Shuffle<T>(T list, bool isLogging=false)
    where T : System.Collections.IList;
```
#### Type parameters
<a name='KeepCoding.MonoRandom.Shuffle.T.(T.bool).T'></a>
`T`  
The type of list to shuffle.
  
#### Parameters
<a name='KeepCoding.MonoRandom.Shuffle.T.(T.bool).list'></a>
`list` [T](MonoRandom.Shuffle.LhQwPIlVk4SxjAclm9nODQ.md#KeepCoding.MonoRandom.Shuffle.T.(T.bool).T 'KeepCoding.MonoRandom.Shuffle&lt;T&gt;(T, bool).T')  
The list to shuffle.
  
<a name='KeepCoding.MonoRandom.Shuffle.T.(T.bool).isLogging'></a>
`isLogging` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should log the result.
  
#### Returns
[T](MonoRandom.Shuffle.LhQwPIlVk4SxjAclm9nODQ.md#KeepCoding.MonoRandom.Shuffle.T.(T.bool).T 'KeepCoding.MonoRandom.Shuffle&lt;T&gt;(T, bool).T')  
[list](MonoRandom.Shuffle.LhQwPIlVk4SxjAclm9nODQ.md#KeepCoding.MonoRandom.Shuffle.T.(T.bool).list 'KeepCoding.MonoRandom.Shuffle&lt;T&gt;(T, bool).list') shuffled using Fisher-Yates shuffle.
