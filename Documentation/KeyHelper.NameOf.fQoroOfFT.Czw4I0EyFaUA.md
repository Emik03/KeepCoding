#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.NameOf&lt;T&gt;(Expression&lt;Func&lt;T&gt;&gt;) Method
A [nameof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/nameof 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/nameof') expression produces the name of a variable, type, or member as the string constant.  
```csharp
public static string NameOf<T>(this System.Linq.Expressions.Expression<System.Func<T>> expression);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.NameOf.T.(System.Linq.Expressions.Expression.System.Func.T..).T'></a>
`T`  
The type of item.
  
#### Parameters
<a name='KeepCoding.KeyHelper.NameOf.T.(System.Linq.Expressions.Expression.System.Func.T..).expression'></a>
`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.NameOf.fQoroOfFT.Czw4I0EyFaUA.md#KeepCoding.KeyHelper.NameOf.T.(System.Linq.Expressions.Expression.System.Func.T..).T 'KeepCoding.KeyHelper.NameOf&lt;T&gt;(System.Linq.Expressions.Expression&lt;System.Func&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')  
The expression to get the name from.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the expression.
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof')
