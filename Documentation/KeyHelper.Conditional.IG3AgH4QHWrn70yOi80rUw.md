#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Conditional&lt;T,TResult&gt;(T, Func&lt;T,TResult&gt;) Method
A null-conditional operator applies a member access, `?.`, or element access, `?[]`, operation to its operand only if that operand evaluates to non-null; otherwise, it returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). That is, if `a` evaluates to [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), the result of `a?.x` or `a?[x]` is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), If `a` evaluates to non-null, the result of `a?.x` or `a?[x]` is the same as the result of `a.x` or `a[x]`, respectively.  
```csharp
public static TResult Conditional<T,TResult>(this T item, System.Func<T,TResult> func)
    where T : class;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).T'></a>
`T`  
The type of the item that may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')
  
<a name='KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).TResult'></a>
`TResult`  
The result of the evaluation.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).item'></a>
`item` [T](KeyHelper.Conditional.IG3AgH4QHWrn70yOi80rUw.md#KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).T 'KeepCoding.KeyHelper.Conditional&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')  
The item that may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
<a name='KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Conditional.IG3AgH4QHWrn70yOi80rUw.md#KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).T 'KeepCoding.KeyHelper.Conditional&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeyHelper.Conditional.IG3AgH4QHWrn70yOi80rUw.md#KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).TResult 'KeepCoding.KeyHelper.Conditional&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The return if [item](KeyHelper.Conditional.IG3AgH4QHWrn70yOi80rUw.md#KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).item 'KeepCoding.KeyHelper.Conditional&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item') isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Returns
[TResult](KeyHelper.Conditional.IG3AgH4QHWrn70yOi80rUw.md#KeepCoding.KeyHelper.Conditional.T.TResult.(T.System.Func.T.TResult.).TResult 'KeepCoding.KeyHelper.Conditional&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')  
`?.`
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and- 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-')
