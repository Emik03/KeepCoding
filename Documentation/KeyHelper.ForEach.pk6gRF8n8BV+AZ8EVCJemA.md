#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;T&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static System.Collections.Generic.IEnumerable<T> ForEach<T>(this System.Collections.Generic.IEnumerable<T> iterator, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).T'></a>
`T`  
The type of iterator.
  
#### Parameters
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).iterator'></a>
`iterator` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper.ForEach.pk6gRF8n8BV+AZ8EVCJemA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.ForEach.pk6gRF8n8BV+AZ8EVCJemA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to do on each item in [iterator](KeyHelper.ForEach.pk6gRF8n8BV+AZ8EVCJemA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).iterator 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T&gt;).iterator').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper.ForEach.pk6gRF8n8BV+AZ8EVCJemA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[iterator](KeyHelper.ForEach.pk6gRF8n8BV+AZ8EVCJemA.md#KeepCoding.KeyHelper.ForEach.T.(System.Collections.Generic.IEnumerable.T..System.Action.T.).iterator 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;T&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
