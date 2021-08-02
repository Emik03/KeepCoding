#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.RemoveCommonIndentation(string) Method
Removes spaces from the beginning of every line in such a way that the smallest indentation is reduced to  
zero. Lines which contain only whitespace are not considered in the calculation and may therefore become  
empty.
```csharp
public static string RemoveCommonIndentation(this string str);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_RemoveCommonIndentation(string)_str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to transform.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
