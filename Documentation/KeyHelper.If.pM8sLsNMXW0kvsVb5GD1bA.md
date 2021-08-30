#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If&lt;T&gt;(bool, T, T) Method
The conditional operator `?:`, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static T If<T>(this bool condition, T consequent, T alternative);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.If.T.(bool.T.T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.KeyHelper.If.T.(bool.T.T).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The condition to check.
  
<a name='KeepCoding.KeyHelper.If.T.(bool.T.T).consequent'></a>
`consequent` [T](KeyHelper.If.pM8sLsNMXW0kvsVb5GD1bA.md#KeepCoding.KeyHelper.If.T.(bool.T.T).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, T, T).T')  
The action to run when [condition](KeyHelper.If.pM8sLsNMXW0kvsVb5GD1bA.md#KeepCoding.KeyHelper.If.T.(bool.T.T).condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, T, T).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T.(bool.T.T).alternative'></a>
`alternative` [T](KeyHelper.If.pM8sLsNMXW0kvsVb5GD1bA.md#KeepCoding.KeyHelper.If.T.(bool.T.T).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, T, T).T')  
The action to run when [condition](KeyHelper.If.pM8sLsNMXW0kvsVb5GD1bA.md#KeepCoding.KeyHelper.If.T.(bool.T.T).condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, T, T).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[T](KeyHelper.If.pM8sLsNMXW0kvsVb5GD1bA.md#KeepCoding.KeyHelper.If.T.(bool.T.T).T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, T, T).T')  
` ?  : `
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else')
