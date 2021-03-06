#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.If(bool, Action, Action) Method
An [if](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if') statement identifies which statement to run based on the value of a Boolean expression.  
```csharp
public static bool If(this bool condition, System.Action consequent, System.Action otherwise=null);
```
#### Parameters
<a name='KeepCoding.KeyHelper.If(bool.System.Action.System.Action).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The condition to check.
  
<a name='KeepCoding.KeyHelper.If(bool.System.Action.System.Action).consequent'></a>
`consequent` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when [condition](KeyHelper.If.XSIP6wZ3SVxqZulat33yIQ.md#KeepCoding.KeyHelper.If(bool.System.Action.System.Action).condition 'KeepCoding.KeyHelper.If(bool, System.Action, System.Action).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.KeyHelper.If(bool.System.Action.System.Action).otherwise'></a>
`otherwise` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when [condition](KeyHelper.If.XSIP6wZ3SVxqZulat33yIQ.md#KeepCoding.KeyHelper.If(bool.System.Action.System.Action).condition 'KeepCoding.KeyHelper.If(bool, System.Action, System.Action).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[condition](KeyHelper.If.XSIP6wZ3SVxqZulat33yIQ.md#KeepCoding.KeyHelper.If(bool.System.Action.System.Action).condition 'KeepCoding.KeyHelper.If(bool, System.Action, System.Action).condition')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else')
