#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If&lt;T&gt;(bool, Func&lt;T&gt;, Func&lt;T&gt;) Method
An [if](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if') statement identifies which statement to run based on the value of a Boolean expression.  
```csharp
public static T If<T>(this bool condition, System.Func<T> action, System.Func<T> otherwise);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The condition to check.
  
<a name='KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_).md#KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when [condition](KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_).md#KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_otherwise'></a>
`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_).md#KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when [condition](KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_).md#KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_condition 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[T](KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_).md#KeepCoding_KeyHelper_If_T_(bool_System_Func_T__System_Func_T_)_T 'KeepCoding.KeyHelper.If&lt;T&gt;(bool, System.Func&lt;T&gt;, System.Func&lt;T&gt;).T')  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else')
