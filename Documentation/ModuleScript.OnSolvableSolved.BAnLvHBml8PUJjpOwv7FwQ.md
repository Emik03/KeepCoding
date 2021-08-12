#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnSolvableSolved(ModuleContainer) Method
Called when any [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') on the current bomb has been solved.  
```csharp
public virtual void OnSolvableSolved(KeepCoding.ModuleContainer module);
```
#### Parameters
<a name='KeepCoding.ModuleScript.OnSolvableSolved(KeepCoding.ModuleContainer).module'></a>
`module` [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')  
The sender encapsulated as [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer'), which was solved.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
