#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(Func&lt;TResult&gt;, Func&lt;Exception,TResult&gt;) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static System.Func<TResult> Catch<T1,T2,T3,T4,TResult>(this System.Func<TResult> func, System.Func<System.Exception,TResult> caught)
    where T1 : System.Exception
    where T2 : System.Exception
    where T3 : System.Exception
    where T4 : System.Exception;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).T1'></a>
`T1`  
The first type to catch.
  
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).T2'></a>
`T2`  
The second type to catch.
  
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).T3'></a>
`T3`  
The third type to catch.
  
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).T4'></a>
`T4`  
The fourth type to catch.
  
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).TResult'></a>
`TResult`  
The return type.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeyHelper.Catch.mXHUEc15+UPgxR5wZboKkA.md#KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to try.
  
<a name='KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).caught'></a>
`caught` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeyHelper.Catch.mXHUEc15+UPgxR5wZboKkA.md#KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when an exception is caught.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeyHelper.Catch.mXHUEc15+UPgxR5wZboKkA.md#KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
[func](KeyHelper.Catch.mXHUEc15+UPgxR5wZboKkA.md#KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).func 'KeepCoding.KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).func') with [caught](KeyHelper.Catch.mXHUEc15+UPgxR5wZboKkA.md#KeepCoding.KeyHelper.Catch.T1.T2.T3.T4.TResult.(System.Func.TResult..System.Func.System.Exception.TResult.).caught 'KeepCoding.KeyHelper.Catch&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;System.Exception,TResult&gt;).caught') if the specified [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')s are caught.
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
