#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnException(string) Method
Called when an unhandled exception relating to this module has been thrown.  
```csharp
public virtual void OnException(string message);
```
#### Parameters
<a name='KeepCoding.ModuleScript.OnException(string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message of the exception.
  
### Remarks
Unlike other virtual methods, this one has implementation. You may choose to invoke `base.OnException()` if you want the module to automatically log and solve.  
