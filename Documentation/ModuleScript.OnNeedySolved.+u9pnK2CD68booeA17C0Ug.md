#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnNeedySolved(ModuleContainer) Method
Called when any [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') on the current bomb has been solved.  
```csharp
public virtual void OnNeedySolved(KeepCoding.ModuleContainer module);
```
#### Parameters
<a name='KeepCoding.ModuleScript.OnNeedySolved(KeepCoding.ModuleContainer).module'></a>
`module` [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')  
The sender encapsulated as [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer'), which was solved.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
