#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(string, string) Method
Finds the path of a given file within a specified mod's assembly name. You need to specify the extensions of the file too, otherwise the file cannot be found.  
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
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
Default: An empty [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
