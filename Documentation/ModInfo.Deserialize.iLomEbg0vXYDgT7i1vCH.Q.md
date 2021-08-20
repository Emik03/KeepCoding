#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModInfo](ModInfo.md 'KeepCoding.ModInfo')
## ModInfo.Deserialize(string, JsonSerializerSettings) Method
Deserializes a modInfo.json file. An [System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException') will make it return a new [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo') instance with no arguments.  
```csharp
public static KeepCoding.ModInfo Deserialize(string path, JsonSerializerSettings settings=null);
```
#### Parameters
<a name='KeepCoding.ModInfo.Deserialize(string.JsonSerializerSettings).path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the file to deserialize.
  
<a name='KeepCoding.ModInfo.Deserialize(string.JsonSerializerSettings).settings'></a>
`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The settings for the serialization.
  
#### Returns
[ModInfo](ModInfo.md 'KeepCoding.ModInfo')  
[path](ModInfo.Deserialize.iLomEbg0vXYDgT7i1vCH.Q.md#KeepCoding.ModInfo.Deserialize(string.JsonSerializerSettings).path 'KeepCoding.ModInfo.Deserialize(string, JsonSerializerSettings).path') deserialized as [ModInfo](ModInfo.md 'KeepCoding.ModInfo').
#### Exceptions
[Newtonsoft.Json.JsonException](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonException 'Newtonsoft.Json.JsonException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
