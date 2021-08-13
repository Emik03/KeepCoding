#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T,TResult&gt;(Func&lt;TResult&gt;, Func&lt;T,TResult&gt;) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static System.Func<TResult> Catch<T,TResult>(this System.Func<TResult> action, System.Func<T,TResult> caught)
    where T : System.Exception;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).T'></a>
`T`  
The type to catch.
  
<a name='KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).TResult'></a>
`TResult`  
The return type.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to try.
  
<a name='KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).caught'></a>
`caught` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).T 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run when an exception is caught.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).TResult 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
[action](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).action 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).action') with [caught](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).caught 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).caught') if [T](KeyHelper.Catch.xgnoQlqNbUtr.uT8Cw6WUw.md#KeepCoding.KeyHelper.Catch.T.TResult.(System.Func.TResult..System.Func.T.TResult.).T 'KeepCoding.KeyHelper.Catch&lt;T,TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;T,TResult&gt;).T') is caught.
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
