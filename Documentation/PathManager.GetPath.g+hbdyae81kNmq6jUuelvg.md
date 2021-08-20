#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(string) Method
Finds the path of a given file within the mod caller. You need to specify the extensions of the file too, otherwise the file cannot be found.  
```csharp
public static string GetPath(string file);
```
#### Parameters
<a name='KeepCoding.PathManager.GetPath(string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to [file](PathManager.GetPath.g+hbdyae81kNmq6jUuelvg.md#KeepCoding.PathManager.GetPath(string).file 'KeepCoding.PathManager.GetPath(string).file') within the mod caller directory.
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
Default: An empty [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
