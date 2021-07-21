#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModInfo Class
Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".  
```csharp
public sealed class ModInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModInfo  

| Properties | |
| :--- | :--- |
| [Author](KeepCoding_ModInfo_Author.md 'KeepCoding.ModInfo.Author') | Contains the author of the mod.<br/> |
| [Description](KeepCoding_ModInfo_Description.md 'KeepCoding.ModInfo.Description') | Contains the description of the mod.<br/> |
| [Id](KeepCoding_ModInfo_Id.md 'KeepCoding.ModInfo.Id') | Contains the ID of the mod, not to be mistaken with [Id](KeepCoding_ModuleScript_Id.md 'KeepCoding.ModuleScript.Id').<br/> |
| [Title](KeepCoding_ModInfo_Title.md 'KeepCoding.ModInfo.Title') | Contains the title of the mod.<br/> |
| [UnityVersion](KeepCoding_ModInfo_UnityVersion.md 'KeepCoding.ModInfo.UnityVersion') | Contains the current unity version of the mod.<br/> |
| [Values](KeepCoding_ModInfo_Values.md 'KeepCoding.ModInfo.Values') | Returns the current values of this [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo') as a dictionary, where the key is the variable name and the value is the variable value.<br/> |
| [Version](KeepCoding_ModInfo_Version.md 'KeepCoding.ModInfo.Version') | Contains the current version of the mod.<br/> |

| Methods | |
| :--- | :--- |
| [Deserialize(string, JsonSerializerSettings)](KeepCoding_ModInfo_Deserialize(string_Newtonsoft_Json_JsonSerializerSettings).md 'KeepCoding.ModInfo.Deserialize(string, Newtonsoft.Json.JsonSerializerSettings)') | Deserializes a modInfo.json file.<br/> |
| [Equals(object)](KeepCoding_ModInfo_Equals(object).md 'KeepCoding.ModInfo.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](KeepCoding_ModInfo_GetHashCode().md 'KeepCoding.ModInfo.GetHashCode()') | Gets the hash code.<br/> |
| [ToString()](KeepCoding_ModInfo_ToString().md 'KeepCoding.ModInfo.ToString()') | Converts the object to a string.<br/> |
