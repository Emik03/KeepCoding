#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo')
## ModInfo.Deserialize(string, JsonSerializerSettings) Method
Deserializes a modInfo.json file.  
```csharp
public static KeepCoding.ModInfo Deserialize(string path, JsonSerializerSettings settings=null);
```
#### Parameters
<a name='KeepCoding_ModInfo_Deserialize(string_JsonSerializerSettings)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the file to deserialize.
  
<a name='KeepCoding_ModInfo_Deserialize(string_JsonSerializerSettings)_settings'></a>
`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The settings for the serialization.
  
#### Returns
[ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo')  
[path](KeepCoding_ModInfo_Deserialize(string_JsonSerializerSettings).md#KeepCoding_ModInfo_Deserialize(string_JsonSerializerSettings)_path 'KeepCoding.ModInfo.Deserialize(string, JsonSerializerSettings).path') deserialized as [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.IO.DirectoryNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException')  
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
[System.IO.PathTooLongException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.PathTooLongException 'System.IO.PathTooLongException')  
[System.Security.SecurityException](https://docs.microsoft.com/en-us/dotnet/api/System.Security.SecurityException 'System.Security.SecurityException')  
[System.UnauthorizedAccessException](https://docs.microsoft.com/en-us/dotnet/api/System.UnauthorizedAccessException 'System.UnauthorizedAccessException')  
