#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullOrEmptyCheck(string, string) Method
Throws an exception if the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') is null or empty.  
```csharp
public static string NullOrEmptyCheck(this string source, string message=null);
```
#### Parameters
<a name='KeepCoding_Helper_NullOrEmptyCheck(string_string)_source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to check for null and empty.
  
<a name='KeepCoding_Helper_NullOrEmptyCheck(string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null or empty. Leaving it default will throw a default message.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
