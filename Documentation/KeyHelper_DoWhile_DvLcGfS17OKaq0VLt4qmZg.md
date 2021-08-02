#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.DoWhile(Action, Func&lt;bool&gt;) Method
The [do](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do') statement executes a statement or a block of statements while a specified Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). Because that expression is evaluated after each execution of the loop, a [do](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do') loop executes one or more times. This differs from a [while](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while') loop, which executes zero or more times.  
```csharp
public static void DoWhile(this System.Action action, System.Func<bool> condition);
```
#### Parameters
<a name='KeepCoding_KeyHelper_DoWhile(System_Action_System_Func_bool_)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run in the loop.
  
<a name='KeepCoding_KeyHelper_DoWhile(System_Action_System_Func_bool_)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition to determine whether the loop should keep going.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement')
