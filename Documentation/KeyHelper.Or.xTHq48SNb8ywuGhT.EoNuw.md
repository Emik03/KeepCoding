#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Or&lt;T&gt;(T, T) Method
The null-coalescing operator `??=` returns the value of its right-hand operand if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'); otherwise, it evaluates the left-hand operand, sets it to the right-hand operand, and returns its result.  
```csharp
public static T Or<T>(this T alternative, ref T item);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Or.T.(T.T).T'></a>
`T`  
The type of the item and return.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Or.T.(T.T).alternative'></a>
`alternative` [T](KeyHelper.Or.xTHq48SNb8ywuGhT.EoNuw.md#KeepCoding.KeyHelper.Or.T.(T.T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, T).T')  
The variable to set and [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') if [alternative](KeyHelper.Or.xTHq48SNb8ywuGhT.EoNuw.md#KeepCoding.KeyHelper.Or.T.(T.T).alternative 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, T).alternative') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
<a name='KeepCoding.KeyHelper.Or.T.(T.T).item'></a>
`item` [T](KeyHelper.Or.xTHq48SNb8ywuGhT.EoNuw.md#KeepCoding.KeyHelper.Or.T.(T.T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, T).T')  
The item to check [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') for.
  
#### Returns
[T](KeyHelper.Or.xTHq48SNb8ywuGhT.EoNuw.md#KeepCoding.KeyHelper.Or.T.(T.T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, T).T')  
` ??= `
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator')
