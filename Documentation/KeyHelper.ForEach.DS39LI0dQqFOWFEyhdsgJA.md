#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;T,int&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static void ForEach<T>(this System.Collections.Generic.IEnumerable<T> iterator, System.Action<T,int> action);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).T'></a>
`T`  
The type of iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).iterator'></a>
`iterator` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper.ForEach.DS39LI0dQqFOWFEyhdsgJA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](KeyHelper.ForEach.DS39LI0dQqFOWFEyhdsgJA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to do on each item in [iterator](KeyHelper.ForEach.DS39LI0dQqFOWFEyhdsgJA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.int.).iterator 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T,int&gt;).iterator').
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
