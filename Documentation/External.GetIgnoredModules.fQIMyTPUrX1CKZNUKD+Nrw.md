#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[External](External.md 'KeepCoding.External')
## External.GetIgnoredModules(ModuleContainer) Method
Retrieves the ignore list from the Boss Module Manager mod used primarily by boss modules.  
```csharp
public static string[] GetIgnoredModules(KeepCoding.ModuleContainer module);
```
#### Parameters
<a name='KeepCoding.External.GetIgnoredModules(KeepCoding.ModuleContainer).module'></a>
`module` [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')  
The module to retrieve the name from.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
If successful, the boss module's ignore list, otherwise a new empty string array.
