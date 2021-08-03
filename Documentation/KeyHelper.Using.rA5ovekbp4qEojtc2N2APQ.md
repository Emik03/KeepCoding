#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Using&lt;T&gt;(T, Action&lt;T&gt;) Method
Provides a convenient syntax that ensures the correct use of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') objects.  
```csharp
public static T Using<T>(this T item, System.Action<T> action)
    where T : System.IDisposable;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).T'></a>
`T`  
The type of [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
  
#### Parameters
<a name='KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).item'></a>
`item` [T](KeyHelper.Using.rA5ovekbp4qEojtc2N2APQ.md#KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item to use.
  
<a name='KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.Using.rA5ovekbp4qEojtc2N2APQ.md#KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to use [item](KeyHelper.Using.rA5ovekbp4qEojtc2N2APQ.md#KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).item 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Action&lt;T&gt;).item') on.
  
#### Returns
[T](KeyHelper.Using.rA5ovekbp4qEojtc2N2APQ.md#KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
[item](KeyHelper.Using.rA5ovekbp4qEojtc2N2APQ.md#KeepCoding.KeyHelper.Using.T.(T.System.Action.T.).item 'KeepCoding.KeyHelper.Using&lt;T&gt;(T, System.Action&lt;T&gt;).item')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement')
