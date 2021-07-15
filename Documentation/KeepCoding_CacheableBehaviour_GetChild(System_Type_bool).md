#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.GetChild(Type, bool) Method
Similar to [UnityEngine.Component.GetComponentInChildren(System.Type)](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponentInChildren#UnityEngine_Component_GetComponentInChildren_System_Type_ 'UnityEngine.Component.GetComponentInChildren(System.Type)'), however it caches the result in a dictionary, and will return the cached result if called again.  
```csharp
public Component GetChild(System.Type type, bool allowNull=false);
```
#### Parameters
<a name='KeepCoding_CacheableBehaviour_GetChild(System_Type_bool)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of component to search for.
  
<a name='KeepCoding_CacheableBehaviour_GetChild(System_Type_bool)_allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The component specified by [type](KeepCoding_CacheableBehaviour_GetChild(System_Type_bool).md#KeepCoding_CacheableBehaviour_GetChild(System_Type_bool)_type 'KeepCoding.CacheableBehaviour.GetChild(System.Type, bool).type').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
