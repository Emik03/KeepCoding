#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2) Method
The conditional operator `?:`, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static object If<T1,T2>(this bool condition, T1 consequent, T2 alternative);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).T1'></a>
`T1`  
The type for the return if [condition](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).T2'></a>
`T2`  
The type for the return if [condition](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Parameters
<a name='KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') to either return [consequent](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).consequent 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).consequent') or [alternative](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).alternative 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).alternative').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).consequent'></a>
`consequent` [T1](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).T1 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).T1')  
The item to return if [condition](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).alternative'></a>
`alternative` [T2](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).T2 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).T2')  
The item to return if [condition](KeyHelper.If.tQi.TZfnNHr3wngBAtndCg.md#KeepCoding.KeyHelper.If.T1.T2.(bool.T1.T2).condition 'KeepCoding.KeyHelper.If&lt;T1,T2&gt;(bool, T1, T2).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
` ?  : `
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator')
