#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.GetChildren&lt;T&gt;(bool, bool) Method
Similar to [UnityEngine.GameObject.GetComponentsInChildren&lt;&gt;.Boolean)](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponentsInChildren--1#UnityEngine_GameObject_GetComponentsInChildren__1_System_Boolean_ 'UnityEngine.GameObject.GetComponentsInChildren``1(System.Boolean)'), however it caches the result in a dictionary, and will return the cached result if called again.  
```csharp
public T[] GetChildren<T>(bool includeInactive=false, bool allowNull=false)
    where T : Component;
```
#### Type parameters
<a name='KeepCoding.CacheableBehaviour.GetChildren.T.(bool.bool).T'></a>
`T`  
The type of component to search for.
  
#### Parameters
<a name='KeepCoding.CacheableBehaviour.GetChildren.T.(bool.bool).includeInactive'></a>
`includeInactive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should include inactive components.
  
<a name='KeepCoding.CacheableBehaviour.GetChildren.T.(bool.bool).allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[T](CacheableBehaviour.GetChildren.Dd6aGB0wGMoXjvTUzuMAjQ.md#KeepCoding.CacheableBehaviour.GetChildren.T.(bool.bool).T 'KeepCoding.CacheableBehaviour.GetChildren&lt;T&gt;(bool, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The component specified by [T](CacheableBehaviour.GetChildren.Dd6aGB0wGMoXjvTUzuMAjQ.md#KeepCoding.CacheableBehaviour.GetChildren.T.(bool.bool).T 'KeepCoding.CacheableBehaviour.GetChildren&lt;T&gt;(bool, bool).T').
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
