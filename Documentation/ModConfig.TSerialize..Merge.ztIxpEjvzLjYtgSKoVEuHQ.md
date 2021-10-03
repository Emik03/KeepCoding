#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Merge(TSerialize, bool) Method
Reads, merges, and writes the settings to the settings file. To protect the user settings, this does nothing if the read isn't successful.  
```csharp
public void Merge(TSerialize value, bool isDiscarding=false);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Merge(TSerialize.bool).value'></a>
`value` [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize')  
The value to merge the file with.
  
<a name='KeepCoding.ModConfig.TSerialize..Merge(TSerialize.bool).isDiscarding'></a>
`isDiscarding` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should remove values from the original file that isn't contained within the type, or has the incorrect type.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
In the editor, this method does nothing.  
