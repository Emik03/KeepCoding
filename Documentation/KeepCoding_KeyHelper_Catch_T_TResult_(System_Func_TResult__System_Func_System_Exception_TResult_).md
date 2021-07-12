### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T,TResult&gt;(Func&lt;TResult&gt;, Func&lt;Exception,TResult&gt;) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static TResult Catch<T,TResult>(this System.Func<TResult> action, System.Func<System.Exception,TResult> caught)
    where T : System.Exception;
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_T'></a>
`T`  
The type to catch.
  
<a name='KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_TResult'></a>
`TResult`  
The return type.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_).md#KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to try.
  
<a name='KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_caught'></a>
`caught` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_).md#KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when an exception is caught.
  
#### Returns
[TResult](KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_).md#KeepCoding_KeyHelper_Catch_T_TResult_(System_Func_TResult__System_Func_System_Exception_TResult_)_TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
