#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo(Type) Method
Gets the path and deserializes the modInfo.json located at every mod's root folder.  
```csharp
public static KeepCoding.ModInfo GetModInfo(System.Type type);
```
#### Parameters
<a name='KeepCoding_PathManager_GetModInfo(System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Any data from the assembly, which is used to get the name.
  
#### Returns
[ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo') of the mod info json file located in the mod.
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
