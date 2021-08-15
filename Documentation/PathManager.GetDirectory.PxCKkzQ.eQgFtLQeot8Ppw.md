#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetDirectory(string) Method
Finds the path of a mod.  
```csharp
public static string GetDirectory(string modAssembly);
```
#### Parameters
<a name='KeepCoding.PathManager.GetDirectory(string).modAssembly'></a>
`modAssembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name. This is used to get the mod in question.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to [modAssembly](PathManager.GetDirectory.PxCKkzQ.eQgFtLQeot8Ppw.md#KeepCoding.PathManager.GetDirectory(string).modAssembly 'KeepCoding.PathManager.GetDirectory(string).modAssembly').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
