#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.ModuleContainer(CacheableBehaviour) Constructor
Encapsulates either a modded solvable or modded needy module by using [Get&lt;T&gt;(bool)](CacheableBehaviour.Get.BCvpnMdzS10TWkqsNXOG8g.md 'KeepCoding.CacheableBehaviour.Get&lt;T&gt;(bool)'). An exception is thrown if [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') and [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public ModuleContainer(KeepCoding.CacheableBehaviour behaviour);
```
#### Parameters
<a name='KeepCoding.ModuleContainer.ModuleContainer(KeepCoding.CacheableBehaviour).behaviour'></a>
`behaviour` [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')  
The component to get the module from.
  
#### Exceptions
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
