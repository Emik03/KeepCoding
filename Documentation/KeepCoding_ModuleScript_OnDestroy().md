### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.OnDestroy() Method
This removed the exception catcher. If you have an OnDestroy method, be sure to call `base.OnDestroy()` as the first statement.  
```csharp
protected void OnDestroy();
```
