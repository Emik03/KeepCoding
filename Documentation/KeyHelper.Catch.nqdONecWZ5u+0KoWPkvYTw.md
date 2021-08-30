#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch(Action, Predicate&lt;Exception&gt;, Action&lt;Exception&gt;, Action) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static System.Action Catch(this System.Action action, System.Predicate<System.Exception> when, System.Action<System.Exception> caught=null, System.Action final=null);
```
#### Parameters
<a name='KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to try.
  
<a name='KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).when'></a>
`when` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The condition for catching the exception.
  
<a name='KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).caught'></a>
`caught` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when an exception is caught.
  
<a name='KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).final'></a>
`final` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run on either clause.
  
#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
[action](KeyHelper.Catch.nqdONecWZ5u+0KoWPkvYTw.md#KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).action 'KeepCoding.KeyHelper.Catch(System.Action, System.Predicate&lt;System.Exception&gt;, System.Action&lt;System.Exception&gt;, System.Action).action') with [caught](KeyHelper.Catch.nqdONecWZ5u+0KoWPkvYTw.md#KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).caught 'KeepCoding.KeyHelper.Catch(System.Action, System.Predicate&lt;System.Exception&gt;, System.Action&lt;System.Exception&gt;, System.Action).caught') if an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') caught passed in [when](KeyHelper.Catch.nqdONecWZ5u+0KoWPkvYTw.md#KeepCoding.KeyHelper.Catch(System.Action.System.Predicate.System.Exception..System.Action.System.Exception..System.Action).when 'KeepCoding.KeyHelper.Catch(System.Action, System.Predicate&lt;System.Exception&gt;, System.Action&lt;System.Exception&gt;, System.Action).when') returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
