#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Write(TSerialize) Method
Writes the settings to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.  
```csharp
public void Write(TSerialize value);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Write(TSerialize).value'></a>
`value` [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize')  
The value to overwrite the settings file with.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
