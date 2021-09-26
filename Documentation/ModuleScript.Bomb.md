#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Bomb Property
The bomb that this module is in.  
```csharp
public KMBomb Bomb { get; }
```
#### Property Value
[KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')
### Remarks
Note that this variable is not available instantly. [OnActivate()](ModuleScript.OnActivate().md 'KeepCoding.ModuleScript.OnActivate()') is recommended, or a [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') that waits for this value to be set.  
