#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullCheck&lt;T&gt;(T, string) Method
Throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException') or [NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException') if the parameter provided is null.  
```csharp
public static T NullCheck<T>(this T item, string message="While asserting for null, the variable ended up null.");
```
#### Type parameters
<a name='KeepCoding.Helper.NullCheck.T.(T.string).T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='KeepCoding.Helper.NullCheck.T.(T.string).item'></a>
`item` [T](Helper.NullCheck.4RnIXBSYVoTN2snJQWKk4A.md#KeepCoding.Helper.NullCheck.T.(T.string).T 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).T')  
The parameter to check null for.
  
<a name='KeepCoding.Helper.NullCheck.T.(T.string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null.
  
#### Returns
[T](Helper.NullCheck.4RnIXBSYVoTN2snJQWKk4A.md#KeepCoding.Helper.NullCheck.T.(T.string).T 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).T')  
[item](Helper.NullCheck.4RnIXBSYVoTN2snJQWKk4A.md#KeepCoding.Helper.NullCheck.T.(T.string).item 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).item')
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
