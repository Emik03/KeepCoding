#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Split(string, string[]) Method
Returns a string array that contains the substrings in this string that are delimited by elements of a  
specified string array.
```csharp
public static string[] Split(this string str, params string[] separator);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_Split(string_string__)_str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to be split.
  
<a name='KeepCoding_UtilityExtensions_Split(string_string__)_separator'></a>
`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Strings that delimit the substrings in this string.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array whose elements contain the substrings in this string that are delimited by one or more strings in  
separator. For more information, see the Remarks section.
