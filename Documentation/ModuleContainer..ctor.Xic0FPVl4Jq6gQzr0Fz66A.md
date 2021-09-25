#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.ModuleContainer(KMBombModule, KMNeedyModule) Constructor
Encapsulates either a modded solvable or modded needy module. An exception is thrown if [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') and [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public ModuleContainer(KMBombModule solvable, KMNeedyModule needy);
```
#### Parameters
<a name='KeepCoding.ModuleContainer.ModuleContainer(KMBombModule.KMNeedyModule).solvable'></a>
`solvable` [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')  
The instance of a normal module.
  
<a name='KeepCoding.ModuleContainer.ModuleContainer(KMBombModule.KMNeedyModule).needy'></a>
`needy` [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule')  
The instance of a needy module.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
