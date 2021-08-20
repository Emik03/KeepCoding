#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.LoadLibrary(string, string) Method
Loads a library from the directory of the specified mod's assembly name.  
```csharp
public static void LoadLibrary(string name, string assembly);
```
#### Parameters
<a name='KeepCoding.PathManager.LoadLibrary(string.string).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The library's name, excluding the extension.
  
<a name='KeepCoding.PathManager.LoadLibrary(string.string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod's assembly name.
  
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
