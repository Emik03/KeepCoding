### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Using&lt;T&gt;(T, Func&lt;T,T&gt;) Method
Provides a convenient syntax that ensures the correct use of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') objects.  
```csharp
public static T Using<T>(this T item, System.Func<T,T> func)
    where T : System.IDisposable;
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_T'></a>
`T`  
The type of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
  
#### Parameters
<a name='KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_item'></a>
`item` [T](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
The item to use.
  
<a name='KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to use [item](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_item 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).item') on.
  
#### Returns
[T](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
The output of [func](KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Using_T_(T_System_Func_T_T_)_func 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Func&lt;T,T&gt;).func').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement')
