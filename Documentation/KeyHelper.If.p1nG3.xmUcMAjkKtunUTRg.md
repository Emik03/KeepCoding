#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2) Method
The conditional operator `?:`, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static TResult If<T1,T2,TResult>(this bool condition, T1 consequent, T2 alternative)
    where TResult : T1, T2;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T1'></a>
`T1`  
The type for the return if [condition](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T2'></a>
`T2`  
The type for the return if [condition](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).TResult'></a>
`TResult`  
The return type that is shared for both [T1](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T1 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).T1') and [T2](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T2 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).T2').
  
#### Parameters
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') to either return [consequent](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).consequent 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).consequent') or [alternative](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).alternative 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).alternative').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).consequent'></a>
`consequent` [T1](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T1 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).T1')  
The item to return if [condition](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).alternative'></a>
`alternative` [T2](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).T2 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).T2')  
The item to return if [condition](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[TResult](KeyHelper.If.p1nG3.xmUcMAjkKtunUTRg.md#KeepCoding.KeyHelper.If.T1.T2.TResult.(bool.T1.T2).TResult 'KeepCoding.KeyHelper.If&lt;T1,T2,TResult&gt;(bool, T1, T2).TResult')  
` ?  : `
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator')
