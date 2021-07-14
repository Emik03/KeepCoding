#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.NameOf&lt;T&gt;(Expression&lt;Func&lt;T&gt;&gt;) Method
A [nameof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/nameof 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/nameof') expression produces the name of a variable, type, or member as the string constant.  
```csharp
public static string NameOf<T>(this System.Linq.Expressions.Expression<System.Func<T>> expression);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_NameOf_T_(System_Linq_Expressions_Expression_System_Func_T__)_T'></a>
`T`  
The type of item.
  
#### Parameters
<a name='KeepCoding_KeyHelper_NameOf_T_(System_Linq_Expressions_Expression_System_Func_T__)_expression'></a>
`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_KeyHelper_NameOf_T_(System_Linq_Expressions_Expression_System_Func_T__).md#KeepCoding_KeyHelper_NameOf_T_(System_Linq_Expressions_Expression_System_Func_T__)_T 'KeepCoding.KeyHelper.NameOf&lt;T&gt;(System.Linq.Expressions.Expression&lt;System.Func&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')  
The expression to get the name from.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the expression.
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof')
