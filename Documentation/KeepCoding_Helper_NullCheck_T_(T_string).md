#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.NullCheck&lt;T&gt;(T, string) Method
Throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException') or [NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException') if the parameter provided is null.  
```csharp
public static T NullCheck<T>(this T item, string message="While asserting for null, the variable ended up null.");
```
#### Type parameters
<a name='KeepCoding_Helper_NullCheck_T_(T_string)_T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='KeepCoding_Helper_NullCheck_T_(T_string)_item'></a>
`item` [T](KeepCoding_Helper_NullCheck_T_(T_string).md#KeepCoding_Helper_NullCheck_T_(T_string)_T 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).T')  
The parameter to check null for.
  
<a name='KeepCoding_Helper_NullCheck_T_(T_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null.
  
#### Returns
[T](KeepCoding_Helper_NullCheck_T_(T_string).md#KeepCoding_Helper_NullCheck_T_(T_string)_T 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).T')  
[item](KeepCoding_Helper_NullCheck_T_(T_string).md#KeepCoding_Helper_NullCheck_T_(T_string)_item 'KeepCoding.Helper.NullCheck&lt;T&gt;(T, string).item')
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
