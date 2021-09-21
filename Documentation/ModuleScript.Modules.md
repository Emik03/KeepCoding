#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Modules Property
Contains every module in the [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') that this module is in.  
```csharp
public System.Collections.ObjectModel.ReadOnlyCollection<KeepCoding.ModuleContainer> Modules { get; }
```
#### Property Value
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')
### Remarks
This collection also includes vanilla modules, including [Empty](ComponentPool.ComponentTypeEnum.md#KeepCoding.ComponentPool.ComponentTypeEnum.Empty 'KeepCoding.ComponentPool.ComponentTypeEnum.Empty') components and [Timer](ComponentPool.ComponentTypeEnum.md#KeepCoding.ComponentPool.ComponentTypeEnum.Timer 'KeepCoding.ComponentPool.ComponentTypeEnum.Timer'). You can filter the collection with [IsVanilla](ModuleContainer.IsVanilla.md 'KeepCoding.ModuleContainer.IsVanilla'), [IsModded](ModuleContainer.IsModded.md 'KeepCoding.ModuleContainer.IsModded'), [IsSolvable](ModuleContainer.IsSolvable.md 'KeepCoding.ModuleContainer.IsSolvable'), or [IsNeedy](ModuleContainer.IsNeedy.md 'KeepCoding.ModuleContainer.IsNeedy'), [IsEmptyOrTimer](ModuleContainer.IsEmptyOrTimer.md 'KeepCoding.ModuleContainer.IsEmptyOrTimer'), or [IsModule](ModuleContainer.IsModule.md 'KeepCoding.ModuleContainer.IsModule').  
