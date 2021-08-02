#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch(Action, Action&lt;Exception&gt;, Action, Type[]) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static void Catch(this System.Action action, System.Action<System.Exception> caught=null, System.Action final=null, params System.Type[] exceptions);
```
#### Parameters
<a name='KeepCoding_KeyHelper_Catch(System_Action_System_Action_System_Exception__System_Action_System_Type__)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to try.
  
<a name='KeepCoding_KeyHelper_Catch(System_Action_System_Action_System_Exception__System_Action_System_Type__)_caught'></a>
`caught` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when an exception is caught.
  
<a name='KeepCoding_KeyHelper_Catch(System_Action_System_Action_System_Exception__System_Action_System_Type__)_final'></a>
`final` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run on either clause.
  
<a name='KeepCoding_KeyHelper_Catch(System_Action_System_Action_System_Exception__System_Action_System_Type__)_exceptions'></a>
`exceptions` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The types of exceptions to catch.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
