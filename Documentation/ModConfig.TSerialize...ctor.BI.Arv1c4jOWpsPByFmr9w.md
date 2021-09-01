#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.ModConfig(string, JsonMergeSettings) Constructor
Creates a new [ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;') with the target file name and an optional event of when the file is read.  
```csharp
public ModConfig(string fileName, JsonMergeSettings settings=null);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..ModConfig(string.JsonMergeSettings).fileName'></a>
`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file name to get.
  
<a name='KeepCoding.ModConfig.TSerialize..ModConfig(string.JsonMergeSettings).settings'></a>
`settings` [Newtonsoft.Json.Linq.JsonMergeSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Linq.JsonMergeSettings 'Newtonsoft.Json.Linq.JsonMergeSettings')  
The way that the default value and the file merge.
  
#### Exceptions
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
