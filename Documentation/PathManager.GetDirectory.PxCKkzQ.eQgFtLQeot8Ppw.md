#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetDirectory(string) Method
Finds the directory of the specified mod's assembly name.  
```csharp
public static string GetDirectory(string assembly);
```
#### Parameters
<a name='KeepCoding.PathManager.GetDirectory(string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The directory to [assembly](PathManager.GetDirectory.PxCKkzQ.eQgFtLQeot8Ppw.md#KeepCoding.PathManager.GetDirectory(string).assembly 'KeepCoding.PathManager.GetDirectory(string).assembly').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
Default: An empty [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
