#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Using&lt;T&gt;(Func&lt;T,T&gt;) Method
Provides a convenient syntax that ensures the correct use of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') objects.  
```csharp
public static T Using<T>(this System.Func<T,T> func)
    where T : System.IDisposable, new();
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).T'></a>
`T`  
The type of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
  
#### Parameters
<a name='KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Using.AeGBXDBgNDZZkE6QZCaSBw.md#KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Using.AeGBXDBgNDZZkE6QZCaSBw.md#KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to use a new instance of [T](KeyHelper.Using.AeGBXDBgNDZZkE6QZCaSBw.md#KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Func&lt;T,T&gt;).T') on.
  
#### Returns
[T](KeyHelper.Using.AeGBXDBgNDZZkE6QZCaSBw.md#KeepCoding.KeyHelper.Using.T.(System.Func.T.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Func&lt;T,T&gt;).T')  
` item = (); (item)`
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement')
