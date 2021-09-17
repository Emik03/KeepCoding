#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.ModuleContainer(Component) Constructor
Encapsulates either a modded solvable or modded needy module by using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1'). An exception is thrown if [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') and [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public ModuleContainer(Component component);
```
#### Parameters
<a name='KeepCoding.ModuleContainer.ModuleContainer(Component).component'></a>
`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The component to get the module from.
  
#### Exceptions
[ConstructorArgumentException](ConstructorArgumentException.md 'KeepCoding.Internal.ConstructorArgumentException')  
