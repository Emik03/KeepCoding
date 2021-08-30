#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T&gt;(Func&lt;T&gt;, Predicate&lt;Exception&gt;, Func&lt;Exception,T&gt;) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static System.Func<T> Catch<T>(this System.Func<T> func, System.Predicate<System.Exception> when, System.Func<System.Exception,T> caught);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).T'></a>
`T`  
The return type.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to try.
  
<a name='KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).when'></a>
`when` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The condition for catching the exception.
  
<a name='KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).caught'></a>
`caught` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when an exception is caught.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).T 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
[func](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).func 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).func') with [caught](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).caught 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).caught') if an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') caught passed in [when](KeyHelper.Catch.LFbc.DHD2Oumx+h3A7ViNA.md#KeepCoding.KeyHelper.Catch.T.(System.Func.T..System.Predicate.System.Exception..System.Func.System.Exception.T.).when 'KeepCoding.KeyHelper.Catch&lt;T&gt;(System.Func&lt;T&gt;, System.Predicate&lt;System.Exception&gt;, System.Func&lt;System.Exception,T&gt;).when') returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
