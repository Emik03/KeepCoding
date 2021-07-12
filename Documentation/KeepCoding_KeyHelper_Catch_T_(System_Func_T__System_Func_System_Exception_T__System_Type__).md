### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T&gt;(Func&lt;T&gt;, Func&lt;Exception,T&gt;, Type[]) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static T Catch<T>(this System.Func<T> action, System.Func<System.Exception,T> caught, params System.Type[] exceptions);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_T'></a>
`T`  
The return type.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__).md#KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;System.Exception,T&gt;, System.Type[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to try.
  
<a name='KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_caught'></a>
`caught` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__).md#KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;System.Exception,T&gt;, System.Type[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when an exception is caught.
  
<a name='KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_exceptions'></a>
`exceptions` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The types of exceptions to catch.
  
#### Returns
[T](KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__).md#KeepCoding_KeyHelper_Catch_T_(System_Func_T__System_Func_System_Exception_T__System_Type__)_T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Func&lt;System.Exception,T&gt;, System.Type[]).T')  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
