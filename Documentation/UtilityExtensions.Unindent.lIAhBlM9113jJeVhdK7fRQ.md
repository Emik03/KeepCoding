#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Unindent(string) Method
Removes the overall indentation of the specified string while maintaining the relative indentation of each  
line.
```csharp
public static string Unindent(this string str);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.Unindent(string).str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to remove indentation from.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string in which every line that isn’t all whitespace has had spaces removed from the beginning equal to the  
least amount of spaces at the beginning of any line.
