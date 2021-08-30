#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.As&lt;T&gt;(object) Method
The [as](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as') operator explicitly converts the result of an expression to a given reference or nullable value type. If the conversion is not possible, the [as](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as') operator returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). Unlike a cast expression, the [as](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/as') operator never throws an exception.  
```csharp
public static T As<T>(this object obj)
    where T : class;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.As.T.(object).T'></a>
`T`  
The type to cast the object into.
  
#### Parameters
<a name='KeepCoding.KeyHelper.As.T.(object).obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast into.
  
#### Returns
[T](KeyHelper.As.y9UYP1eMHEdhlkfiRCk8rA.md#KeepCoding.KeyHelper.As.T.(object).T 'KeepCoding.KeyHelper.As&lt;T&gt;(object).T')  
``
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator')
