#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.GetChildren(Type, bool) Method
Similar to [UnityEngine.GameObject.GetComponentsInChildren(System.Type)](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponentsInChildren#UnityEngine_GameObject_GetComponentsInChildren_System_Type_ 'UnityEngine.GameObject.GetComponentsInChildren(System.Type)'), however it caches the result in a dictionary, and will return the cached result if called again.  
```csharp
public Component[] GetChildren(System.Type type, bool allowNull=false);
```
#### Parameters
<a name='KeepCoding.CacheableBehaviour.GetChildren(System.Type.bool).type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of component to search for.
  
<a name='KeepCoding.CacheableBehaviour.GetChildren(System.Type.bool).allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The component specified by [type](CacheableBehaviour.GetChildren.J.nFy.M5rmQVdBaGk3VUGg.md#KeepCoding.CacheableBehaviour.GetChildren(System.Type.bool).type 'KeepCoding.CacheableBehaviour.GetChildren(System.Type, bool).type').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
