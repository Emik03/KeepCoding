#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Write(string) Method
Writes the string to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.  
```csharp
public void Write(string value);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Write(string).value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The contents to write.
  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
