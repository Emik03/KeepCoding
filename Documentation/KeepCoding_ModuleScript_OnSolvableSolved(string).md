### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnSolvableSolved(string) Method
Called when any [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') on the current bomb has been solved.  
```csharp
public virtual void OnSolvableSolved(string moduleName);
```
#### Parameters
<a name='KeepCoding_ModuleScript_OnSolvableSolved(string)_moduleName'></a>
`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The sender's module name, which was solved.
  
### Remarks
Vanilla modules are an exception, they will not invoke this method.  
