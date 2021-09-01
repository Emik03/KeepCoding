#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Merge(TSerialize, JsonMergeSettings) Method
Reads, merges, and writes the settings to the settings file. To protect the user settings, this does nothing if the read isn't successful.  
```csharp
public void Merge(TSerialize value, JsonMergeSettings settings=null);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Merge(TSerialize.JsonMergeSettings).value'></a>
`value` [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize')  
The value to merge the file with.
  
<a name='KeepCoding.ModConfig.TSerialize..Merge(TSerialize.JsonMergeSettings).settings'></a>
`settings` [Newtonsoft.Json.Linq.JsonMergeSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.Linq.JsonMergeSettings 'Newtonsoft.Json.Linq.JsonMergeSettings')  
The way that [value](ModConfig.TSerialize..Merge.kcthGuUucresFxGEuSjX4Q.md#KeepCoding.ModConfig.TSerialize..Merge(TSerialize.JsonMergeSettings).value 'KeepCoding.ModConfig&lt;TSerialize&gt;.Merge(TSerialize, JsonMergeSettings).value') and the file merge.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
