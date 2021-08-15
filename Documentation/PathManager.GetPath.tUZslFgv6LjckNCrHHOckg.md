#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(string, string) Method
Finds the path of a given file within each mod.  
```csharp
public static string GetPath(string modAssembly, string search);
```
#### Parameters
<a name='KeepCoding.PathManager.GetPath(string.string).modAssembly'></a>
`modAssembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name. This is used to get the mod in question.
  
<a name='KeepCoding.PathManager.GetPath(string.string).search'></a>
`search` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to [search](PathManager.GetPath.tUZslFgv6LjckNCrHHOckg.md#KeepCoding.PathManager.GetPath(string.string).search 'KeepCoding.PathManager.GetPath(string, string).search').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
You need to specify the extensions of the file too, otherwise the file cannot be found.  
