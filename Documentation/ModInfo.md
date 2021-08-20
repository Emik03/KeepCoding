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
| [Author](ModInfo.Author.md 'KeepCoding.ModInfo.Author') | Contains the author of the mod.<br/> |
| [Description](ModInfo.Description.md 'KeepCoding.ModInfo.Description') | Contains the description of the mod.<br/> |
| [Id](ModInfo.Id.md 'KeepCoding.ModInfo.Id') | Contains the ID of the mod, not to be mistaken with [Id](ModuleScript.Id.md 'KeepCoding.ModuleScript.Id').<br/> |
| [Title](ModInfo.Title.md 'KeepCoding.ModInfo.Title') | Contains the title of the mod.<br/> |
| [UnityVersion](ModInfo.UnityVersion.md 'KeepCoding.ModInfo.UnityVersion') | Contains the current unity version of the mod.<br/> |
| [Values](ModInfo.Values.md 'KeepCoding.ModInfo.Values') | Returns the current values of this [ModInfo](ModInfo.md 'KeepCoding.ModInfo') as a dictionary, where the key is the variable name and the value is the variable value.<br/> |
| [Version](ModInfo.Version.md 'KeepCoding.ModInfo.Version') | Contains the current version of the mod.<br/> |

| Methods | |
| :--- | :--- |
| [Deserialize(string, JsonSerializerSettings)](ModInfo.Deserialize.iLomEbg0vXYDgT7i1vCH.Q.md 'KeepCoding.ModInfo.Deserialize(string, JsonSerializerSettings)') | Deserializes a modInfo.json file. An [System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException') will make it return a new [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo') instance with no arguments.<br/> |
| [Equals(object)](ModInfo.Equals.VmqNgo3G7LzdjS2MD8geZg.md 'KeepCoding.ModInfo.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](ModInfo.GetHashCode().md 'KeepCoding.ModInfo.GetHashCode()') | Gets the hash code.<br/> |
| [ToString()](ModInfo.ToString().md 'KeepCoding.ModInfo.ToString()') | Converts the object to a string.<br/> |
