#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo(string) Method
Deserializes the modInfo.json of a specified mod's assembly name.  
```csharp
public static KeepCoding.ModInfo GetModInfo(string assembly);
```
#### Parameters
<a name='KeepCoding.PathManager.GetModInfo(string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name.
  
#### Returns
[ModInfo](ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](ModInfo.md 'KeepCoding.ModInfo') from [assembly](PathManager.GetModInfo.yasiGDRIL0pHGpi56k7gSg.md#KeepCoding.PathManager.GetModInfo(string).assembly 'KeepCoding.PathManager.GetModInfo(string).assembly').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[Newtonsoft.Json.JsonException](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonException 'Newtonsoft.Json.JsonException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
Default: A new instance of [ModInfo](ModInfo.md 'KeepCoding.ModInfo') with  values.  
