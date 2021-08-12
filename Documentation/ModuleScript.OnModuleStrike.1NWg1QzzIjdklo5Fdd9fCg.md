#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnModuleStrike(ModuleContainer) Method
Called when any module on the current bomb has issued a strike.  
```csharp
public virtual void OnModuleStrike(KeepCoding.ModuleContainer module);
```
#### Parameters
<a name='KeepCoding.ModuleScript.OnModuleStrike(KeepCoding.ModuleContainer).module'></a>
`module` [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')  
The sender encapsulated as [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer'), which caused a strike.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
