#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Is&lt;T&gt;(object, T) Method
The [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is') operator checks if the result of an expression is compatible with a given type.  
```csharp
public static bool Is<T>(this object obj, out T item)
    where T : class;
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Is_T_(object_T)_T'></a>
`T`  
The type to cast into.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Is_T_(object_T)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast.
  
<a name='KeepCoding_KeyHelper_Is_T_(object_T)_item'></a>
`item` [T](KeepCoding_KeyHelper_Is_T_(object_T).md#KeepCoding_KeyHelper_Is_T_(object_T)_T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, T).T')  
The object casted into the type.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[obj](KeepCoding_KeyHelper_Is_T_(object_T).md#KeepCoding_KeyHelper_Is_T_(object_T)_obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, T).obj')[is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is')[T](KeepCoding_KeyHelper_Is_T_(object_T).md#KeepCoding_KeyHelper_Is_T_(object_T)_T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, T).T')[item](KeepCoding_KeyHelper_Is_T_(object_T).md#KeepCoding_KeyHelper_Is_T_(object_T)_item 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, T).item')
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is')
