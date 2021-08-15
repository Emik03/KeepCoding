#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(string, string) Method
Finds the path of a given file within a specified mod's assembly name.  
```csharp
public static string GetPath(string file, string assembly);
```
#### Parameters
<a name='KeepCoding.PathManager.GetPath(string.string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
<a name='KeepCoding.PathManager.GetPath(string.string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to [file](PathManager.GetPath.tUZslFgv6LjckNCrHHOckg.md#KeepCoding.PathManager.GetPath(string.string).file 'KeepCoding.PathManager.GetPath(string, string).file') within [assembly](PathManager.GetPath.tUZslFgv6LjckNCrHHOckg.md#KeepCoding.PathManager.GetPath(string.string).assembly 'KeepCoding.PathManager.GetPath(string, string).assembly').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
