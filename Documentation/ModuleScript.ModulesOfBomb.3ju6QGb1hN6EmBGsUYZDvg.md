#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.ModulesOfBomb(KMBomb) Method
Allows you to get the collection of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') from a [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb').  
```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<KeepCoding.ModuleContainer> ModulesOfBomb(KMBomb bomb);
```
#### Parameters
<a name='KeepCoding.ModuleScript.ModulesOfBomb(KMBomb).bomb'></a>
`bomb` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')  
The instance of [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') that has modules.
  
#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
All modules within [bomb](ModuleScript.ModulesOfBomb.3ju6QGb1hN6EmBGsUYZDvg.md#KeepCoding.ModuleScript.ModulesOfBomb(KMBomb).bomb 'KeepCoding.ModuleScript.ModulesOfBomb(KMBomb).bomb').
### Remarks
This collection also includes vanilla modules, including [Empty](ComponentPool.ComponentTypeEnum.md#KeepCoding.ComponentPool.ComponentTypeEnum.Empty 'KeepCoding.ComponentPool.ComponentTypeEnum.Empty') components and [Timer](ComponentPool.ComponentTypeEnum.md#KeepCoding.ComponentPool.ComponentTypeEnum.Timer 'KeepCoding.ComponentPool.ComponentTypeEnum.Timer'). You can filter the collection with [IsVanilla](ModuleContainer.IsVanilla.md 'KeepCoding.ModuleContainer.IsVanilla'), [IsModded](ModuleContainer.IsModded.md 'KeepCoding.ModuleContainer.IsModded'), [IsSolvable](ModuleContainer.IsSolvable.md 'KeepCoding.ModuleContainer.IsSolvable'), or [IsNeedy](ModuleContainer.IsNeedy.md 'KeepCoding.ModuleContainer.IsNeedy'), [IsEmptyOrTimer](ModuleContainer.IsEmptyOrTimer.md 'KeepCoding.ModuleContainer.IsEmptyOrTimer'), or [IsModule](ModuleContainer.IsModule.md 'KeepCoding.ModuleContainer.IsModule').  
