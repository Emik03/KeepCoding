#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.DoWhile&lt;T&gt;(Func&lt;T&gt;, Func&lt;bool&gt;) Method
The [do](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do') statement executes a statement or a block of statements while a specified Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). Because that expression is evaluated after each execution of the loop, a [do](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do') loop executes one or more times. This differs from a [while](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while') loop, which executes zero or more times.  
```csharp
public static System.Collections.Generic.IEnumerable<T> DoWhile<T>(this System.Func<T> func, System.Func<bool> condition);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper_DoWhile_DQPANploMKKcAKdcrhpvHg.md#KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_T 'KeepCoding.KeyHelper.DoWhile&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to run in the loop.
  
<a name='KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition to determine whether the loop should keep going.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper_DoWhile_DQPANploMKKcAKdcrhpvHg.md#KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_T 'KeepCoding.KeyHelper.DoWhile&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
All instances that [func](KeyHelper_DoWhile_DQPANploMKKcAKdcrhpvHg.md#KeepCoding_KeyHelper_DoWhile_T_(System_Func_T__System_Func_bool_)_func 'KeepCoding.KeyHelper.DoWhile&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;bool&gt;).func') used in an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement')
