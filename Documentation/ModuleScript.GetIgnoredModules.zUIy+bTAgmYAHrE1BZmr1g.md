#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.GetIgnoredModules(string) Method
Retrieves the ignore list from the Boss Module Manager mod used primarily by boss modules.  
```csharp
public string[] GetIgnoredModules(string moduleName);
```
#### Parameters
<a name='KeepCoding.ModuleScript.GetIgnoredModules(string).moduleName'></a>
`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the module to retrieve from.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
If successful, the boss module's ignore list, otherwise a new empty string array.
