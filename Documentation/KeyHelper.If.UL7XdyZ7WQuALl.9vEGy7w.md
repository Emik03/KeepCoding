#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If&lt;T&gt;(bool, Func&lt;T&gt;, Func&lt;T&gt;) Method
An [if](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if') statement identifies which statement to run based on the value of a Boolean expression.  
```csharp
public static T If<T>(this bool condition, System.Func<T> action, System.Func<T> otherwise);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The condition to check.
  
<a name='KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.If.UL7XdyZ7WQuALl.9vEGy7w.md#KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when [condition](KeyHelper.If.UL7XdyZ7WQuALl.9vEGy7w.md#KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).otherwise'></a>
`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.If.UL7XdyZ7WQuALl.9vEGy7w.md#KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when [condition](KeyHelper.If.UL7XdyZ7WQuALl.9vEGy7w.md#KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[T](KeyHelper.If.UL7XdyZ7WQuALl.9vEGy7w.md#KeepCoding.KeyHelper.If.T.(bool.System.Func.T..System.Func.T.).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else')
