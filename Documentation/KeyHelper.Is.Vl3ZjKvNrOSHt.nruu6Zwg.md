#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Is&lt;T&gt;(object, Nullable&lt;T&gt;) Method
The [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is') operator checks if the result of an expression is compatible with a given type.  
```csharp
public static bool Is<T>(this object obj, out System.Nullable<T> item)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Nullable.T.).T'></a>
`T`  
The type to cast into.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Nullable.T.).obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast.
  
<a name='KeepCoding.KeyHelper.Is.T.(object.System.Nullable.T.).item'></a>
`item` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](KeyHelper.Is.Vl3ZjKvNrOSHt.nruu6Zwg.md#KeepCoding.KeyHelper.Is.T.(object.System.Nullable.T.).T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Nullable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The object casted into the type.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
``
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is')
