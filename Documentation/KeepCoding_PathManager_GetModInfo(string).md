#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo(string) Method
Gets the path and deserializes the modInfo.json located at every mod's root folder.  
```csharp
public static KeepCoding.ModInfo GetModInfo(string bundleFileName);
```
#### Parameters
<a name='KeepCoding_PathManager_GetModInfo(string)_bundleFileName'></a>
`bundleFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle assembly.
  
#### Returns
[ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo') of the mod info json file located in the mod.
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
