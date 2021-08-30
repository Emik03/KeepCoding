#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Is&lt;T&gt;(object, T) Method
The [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is') operator checks if the result of an expression is compatible with a given type.  
```csharp
public static bool Is<T>(this object obj, out T item)
    where T : class;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.T).T'></a>
`T`  
The type to cast into.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.T).obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast.
  
<a name='KeepCoding.KeyHelper.Is.T.(object.T).item'></a>
`item` [T](KeyHelper.Is.AmhheFFRM3eHKjsU8Q+IWQ.md#KeepCoding.KeyHelper.Is.T.(object.T).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, T).T')  
The object casted into the type.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
``
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is')
