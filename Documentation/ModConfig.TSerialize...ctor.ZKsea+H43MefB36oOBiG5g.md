#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.ModConfig(string) Constructor
Creates a new [ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;') with the target file name and an optional event of when the file is read. A file will automatically be made if it doesn't exist. A JSON property defined in the type [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize') that isn't in the file will automatically write to the file with said property.  
```csharp
public ModConfig(string fileName);
```
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..ModConfig(string).fileName'></a>
`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file name to get.
  
#### Exceptions
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
### Remarks
In the editor, the constructor will not merge the default values of the type with the file.  
