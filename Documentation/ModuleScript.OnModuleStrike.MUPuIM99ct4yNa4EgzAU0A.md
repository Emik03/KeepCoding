#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnModuleStrike(string) Method
Called when any module on the current bomb has issued a strike.  
```csharp
public virtual void OnModuleStrike(string moduleName);
```
#### Parameters
<a name='KeepCoding.ModuleScript.OnModuleStrike(string).moduleName'></a>
`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The sender's module name, which caused a strike.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  