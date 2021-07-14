#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnModuleStrike(string) Method
Called when any module on the current bomb has issued a strike.  
```csharp
public virtual void OnModuleStrike(string moduleName);
```
#### Parameters
<a name='KeepCoding_ModuleScript_OnModuleStrike(string)_moduleName'></a>
`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The sender's module name, which caused a strike.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
