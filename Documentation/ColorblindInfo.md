#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ColorblindInfo Class
Contains information about the colorblind mod's info, this class can be used to deserialize "ColorblindMode.json".  
```csharp
public sealed class ColorblindInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ColorblindInfo  

| Constructors | |
| :--- | :--- |
| [ColorblindInfo(string)](ColorblindInfo..ctor.cYbL8gpqabBb6u.woaQCvA.md 'KeepCoding.ColorblindInfo.ColorblindInfo(string)') | Creates a [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo') while read/writing the file.<br/> |

| Properties | |
| :--- | :--- |
| [File](ColorblindInfo.File.md 'KeepCoding.ColorblindInfo.File') | The directory of the mod settings file.<br/> |
| [IsEnabled](ColorblindInfo.IsEnabled.md 'KeepCoding.ColorblindInfo.IsEnabled') | Determines whether colorblind mode is on.<br/> |
| [IsModuleEnabled](ColorblindInfo.IsModuleEnabled.md 'KeepCoding.ColorblindInfo.IsModuleEnabled') | Determines whether colorblind mode for the module is on.<br/> |
| [Modules](ColorblindInfo.Modules.md 'KeepCoding.ColorblindInfo.Modules') | Contains module ids and their colorblind states.<br/> |

| Methods | |
| :--- | :--- |
| [Deserialize(string, JsonSerializerSettings)](ColorblindInfo.Deserialize.+QhNzkebVf+Ed0xzieVMkQ.md 'KeepCoding.ColorblindInfo.Deserialize(string, JsonSerializerSettings)') | Deserializes a ColorblindMode.json file.<br/> |
| [Equals(object)](ColorblindInfo.Equals.BBUadRh8kcdRKUeyBpD39w.md 'KeepCoding.ColorblindInfo.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](ColorblindInfo.GetHashCode().md 'KeepCoding.ColorblindInfo.GetHashCode()') | Gets the hash code.<br/> |
| [ToString()](ColorblindInfo.ToString().md 'KeepCoding.ColorblindInfo.ToString()') | Converts the object to a string.<br/> |
