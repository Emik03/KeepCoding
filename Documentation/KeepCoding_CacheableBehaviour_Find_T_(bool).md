#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.Find&lt;T&gt;(bool) Method
Similar to [UnityEngine.Object.FindObjectsOfType&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object.FindObjectsOfType--1 'UnityEngine.Object.FindObjectsOfType``1'), however it caches the result in a dictionary, and will return the cached result if called again.  
```csharp
public T Find<T>(bool allowNull=false)
    where T : Component;
```
#### Type parameters
<a name='KeepCoding_CacheableBehaviour_Find_T_(bool)_T'></a>
`T`  
The type of component to search for.
  
#### Parameters
<a name='KeepCoding_CacheableBehaviour_Find_T_(bool)_allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[T](KeepCoding_CacheableBehaviour_Find_T_(bool).md#KeepCoding_CacheableBehaviour_Find_T_(bool)_T 'KeepCoding.CacheableBehaviour.Find&lt;T&gt;(bool).T')  
The component specified by [T](KeepCoding_CacheableBehaviour_Find_T_(bool).md#KeepCoding_CacheableBehaviour_Find_T_(bool)_T 'KeepCoding.CacheableBehaviour.Find&lt;T&gt;(bool).T').
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
