#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Using&lt;T&gt;(Action&lt;T&gt;) Method
Provides a convenient syntax that ensures the correct use of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') objects.  
```csharp
public static T Using<T>(this System.Action<T> action)
    where T : System.IDisposable, new();
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Using.T.(System.Action.T.).T'></a>
`T`  
The type of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
  
#### Parameters
<a name='KeepCoding.KeyHelper.Using.T.(System.Action.T.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.Using.FkEJF.KcIXQ.cWOjKDN6PA.md#KeepCoding.KeyHelper.Using.T.(System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to use a new instance of [T](KeyHelper.Using.FkEJF.KcIXQ.cWOjKDN6PA.md#KeepCoding.KeyHelper.Using.T.(System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Action&lt;T&gt;).T') on.
  
#### Returns
[T](KeyHelper.Using.FkEJF.KcIXQ.cWOjKDN6PA.md#KeepCoding.KeyHelper.Using.T.(System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(System.Action&lt;T&gt;).T')  
` item = (); (item)`
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement')
