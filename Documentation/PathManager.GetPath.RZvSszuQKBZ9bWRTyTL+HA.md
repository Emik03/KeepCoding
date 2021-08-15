#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath(Type, string) Method
Finds the path of a given file within each mod.  
```csharp
public static string GetPath(System.Type type, string search);
```
#### Parameters
<a name='KeepCoding.PathManager.GetPath(System.Type.string).type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding.PathManager.GetPath(System.Type.string).search'></a>
`search` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to the mod.
