### [KeepCoding](KeepCoding.md 'KeepCoding').[GeneratorSetting](KeepCoding_GeneratorSetting.md 'KeepCoding.GeneratorSetting')
## GeneratorSetting.FrontFaceOnly Property
```csharp
public bool FrontFaceOnly { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.  
