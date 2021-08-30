#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Cast&lt;E,T&gt;(E) Method
A cast expression of the form `()` performs an explicit conversion of the result of expression `` to type ``. If no explicit conversion exists from the type of `` to type ``, a compile-time error occurs. At run time, an explicit conversion might not succeed and a cast expression might throw an exception.  
```csharp
public static T Cast<E,T>(this E item)
    where T : E;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Cast.E.T.(E).E'></a>
`E`  
The initial type.
  
<a name='KeepCoding.KeyHelper.Cast.E.T.(E).T'></a>
`T`  
The type to convert to.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Cast.E.T.(E).item'></a>
`item` [E](KeyHelper.Cast.SMNbW4bP9Au0RVTinNbQ1A.md#KeepCoding.KeyHelper.Cast.E.T.(E).E 'KeepCoding.KeyHelper.Cast&lt;E,T&gt;(E).E')  
The item to cast.
  
#### Returns
[T](KeyHelper.Cast.SMNbW4bP9Au0RVTinNbQ1A.md#KeepCoding.KeyHelper.Cast.E.T.(E).T 'KeepCoding.KeyHelper.Cast&lt;E,T&gt;(E).T')  
`()`
#### Exceptions
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression')
