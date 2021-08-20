#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo')
## ColorblindInfo.Deserialize(string, JsonSerializerSettings) Method
Deserializes a ColorblindMode.json file. An [System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException') will make it return a new [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo') instance with no arguments.  
```csharp
public static KeepCoding.ColorblindInfo Deserialize(string path, JsonSerializerSettings settings=null);
```
#### Parameters
<a name='KeepCoding.ColorblindInfo.Deserialize(string.JsonSerializerSettings).path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the file to deserialize.
  
<a name='KeepCoding.ColorblindInfo.Deserialize(string.JsonSerializerSettings).settings'></a>
`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The settings for the serialization.
  
#### Returns
[ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo')  
[path](ColorblindInfo.Deserialize.+QhNzkebVf+Ed0xzieVMkQ.md#KeepCoding.ColorblindInfo.Deserialize(string.JsonSerializerSettings).path 'KeepCoding.ColorblindInfo.Deserialize(string, JsonSerializerSettings).path') deserialized as [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo').
#### Exceptions
[Newtonsoft.Json.JsonException](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonException 'Newtonsoft.Json.JsonException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
