#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Or&lt;T&gt;(T, Func&lt;T&gt;) Method
The null-coalescing operator `??` returns the value of its left-hand operand if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'); otherwise, it evaluates the right-hand operand and returns its result. The `??` operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.  
```csharp
public static T Or<T>(this T item, System.Func<T> alternative);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).T'></a>
`T`  
The type of the item and return.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).item'></a>
`item` [T](KeyHelper.Or.POjvQ.iR8QwjhLW4RdkY+g.md#KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, System.Func&lt;T&gt;).T')  
The item to check [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') for.
  
<a name='KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).alternative'></a>
`alternative` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Or.POjvQ.iR8QwjhLW4RdkY+g.md#KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The variable to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') if [item](KeyHelper.Or.POjvQ.iR8QwjhLW4RdkY+g.md#KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).item 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, System.Func&lt;T&gt;).item') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Returns
[T](KeyHelper.Or.POjvQ.iR8QwjhLW4RdkY+g.md#KeepCoding.KeyHelper.Or.T.(T.System.Func.T.).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(T, System.Func&lt;T&gt;).T')  
` ?? `
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator')
