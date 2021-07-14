#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnNeedySolved(string) Method
Called when any [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') on the current bomb has been solved.  
```csharp
public virtual void OnNeedySolved(string moduleName);
```
#### Parameters
<a name='KeepCoding_ModuleScript_OnNeedySolved(string)_moduleName'></a>
`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The sender's module name, which was solved.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
