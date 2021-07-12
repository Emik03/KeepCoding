### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(string) Method
Finds the path of a given file within each mod.  
```csharp
public static string GetPath(string search);
```
#### Parameters
<a name='KeepCoding_PathManager_GetPath(string)_search'></a>
`search` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to [search](KeepCoding_PathManager_GetPath(string).md#KeepCoding_PathManager_GetPath(string)_search 'KeepCoding.PathManager.GetPath(string).search').
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
### Remarks
You need to specify the extensions of the file too, otherwise the file cannot be found.  
