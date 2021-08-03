#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Is&lt;T&gt;(object, Action&lt;T&gt;, Action) Method
The [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is') operator checks if the result of an expression is compatible with a given type.  
```csharp
public static bool Is<T>(this object obj, System.Action<T> action, System.Action otherwise=null)
    where T : class;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).T'></a>
`T`  
The type to cast into.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast.
  
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when [obj](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj') is [T](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T').
  
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).otherwise'></a>
`otherwise` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when [obj](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj') is not [T](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[obj](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj')[is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is')[T](KeyHelper.Is.9jftaMIgOLtwRoX6Bz.S8Q.md#KeepCoding.KeyHelper.Is.T.(object.System.Action.T..System.Action).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T') item
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is')
