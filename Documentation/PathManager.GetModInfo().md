#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo() Method
Deserializes the modInfo.json of the mod caller.  
```csharp
public static KeepCoding.ModInfo GetModInfo();
```
#### Returns
[ModInfo](ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](ModInfo.md 'KeepCoding.ModInfo') from the mod caller's modInfo.json file.
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[Newtonsoft.Json.JsonException](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonException 'Newtonsoft.Json.JsonException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
Default: A new instance of [ModInfo](ModInfo.md 'KeepCoding.ModInfo') with  values.  
