#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.GetParents(Type, bool) Method
Similar to [UnityEngine.GameObject.GetComponentsInParent(System.Type)](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponentsInParent#UnityEngine_GameObject_GetComponentsInParent_System_Type_ 'UnityEngine.GameObject.GetComponentsInParent(System.Type)'), however it caches the result in a dictionary, and will return the cached result if called again.  
```csharp
public Component[] GetParents(System.Type type, bool allowNull=false);
```
#### Parameters
<a name='KeepCoding.CacheableBehaviour.GetParents(System.Type.bool).type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of component to search for.
  
<a name='KeepCoding.CacheableBehaviour.GetParents(System.Type.bool).allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The component specified by [type](CacheableBehaviour.GetParents.aUnvkn1vlXWJCLOrTO0NEA.md#KeepCoding.CacheableBehaviour.GetParents(System.Type.bool).type 'KeepCoding.CacheableBehaviour.GetParents(System.Type, bool).type').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
