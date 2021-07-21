#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ColorblindInfo Class
Contains information about the colorblind mod's info, this class can be used to deserialize every mod's "modInfo.json".  
```csharp
public sealed class ColorblindInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ColorblindInfo  

| Constructors | |
| :--- | :--- |
| [ColorblindInfo(ModuleScript)](KeepCoding_ColorblindInfo_ColorblindInfo(KeepCoding_ModuleScript).md 'KeepCoding.ColorblindInfo.ColorblindInfo(KeepCoding.ModuleScript)') | Creates a [ColorblindInfo](KeepCoding_ColorblindInfo.md 'KeepCoding.ColorblindInfo') while modifying [IsColorblind](KeepCoding_ModuleScript_IsColorblind.md 'KeepCoding.ModuleScript.IsColorblind').<br/> |
| [ColorblindInfo(string)](KeepCoding_ColorblindInfo_ColorblindInfo(string).md 'KeepCoding.ColorblindInfo.ColorblindInfo(string)') | Default constructor. Deserializes with the default directory.<br/> |

| Properties | |
| :--- | :--- |
| [Directory](KeepCoding_ColorblindInfo_Directory.md 'KeepCoding.ColorblindInfo.Directory') | The directory of the mod settings file.<br/> |
| [IsEnabled](KeepCoding_ColorblindInfo_IsEnabled.md 'KeepCoding.ColorblindInfo.IsEnabled') | Determines whether colorblind mode is on.<br/> |
| [Modules](KeepCoding_ColorblindInfo_Modules.md 'KeepCoding.ColorblindInfo.Modules') | Contains module ids and their colorblind states.<br/> |

| Methods | |
| :--- | :--- |
| [Deserialize(string, JsonSerializerSettings)](KeepCoding_ColorblindInfo_Deserialize(string_Newtonsoft_Json_JsonSerializerSettings).md 'KeepCoding.ColorblindInfo.Deserialize(string, Newtonsoft.Json.JsonSerializerSettings)') | Deserializes a ColorblindMode.json file.<br/> |
| [Equals(object)](KeepCoding_ColorblindInfo_Equals(object).md 'KeepCoding.ColorblindInfo.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](KeepCoding_ColorblindInfo_GetHashCode().md 'KeepCoding.ColorblindInfo.GetHashCode()') | Gets the hash code.<br/> |
| [ToString()](KeepCoding_ColorblindInfo_ToString().md 'KeepCoding.ColorblindInfo.ToString()') | Converts the object to a string.<br/> |
