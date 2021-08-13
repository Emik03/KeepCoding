#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T&gt;(Action, Action&lt;T&gt;, Action) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static System.Action Catch<T>(this System.Action action, System.Action<T> caught=null, System.Action final=null)
    where T : System.Exception;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).T'></a>
`T`  
The type to catch.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to try.
  
<a name='KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).caught'></a>
`caught` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.Catch.23.ZquLjkR+wnV2yX.sCNA.md#KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Action, System.Action&lt;T&gt;, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when an exception is caught.
  
<a name='KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).final'></a>
`final` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run on either clause.
  
#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
[action](KeyHelper.Catch.23.ZquLjkR+wnV2yX.sCNA.md#KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).action 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Action, System.Action&lt;T&gt;, System.Action).action') with [caught](KeyHelper.Catch.23.ZquLjkR+wnV2yX.sCNA.md#KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).caught 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Action, System.Action&lt;T&gt;, System.Action).caught') if [T](KeyHelper.Catch.23.ZquLjkR+wnV2yX.sCNA.md#KeepCoding.KeyHelper.Catch.T.(System.Action.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Action, System.Action&lt;T&gt;, System.Action).T') is caught.
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
