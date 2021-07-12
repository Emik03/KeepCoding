### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.Cache&lt;T&gt;(Func&lt;T[]&gt;, bool) Method
Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.  
```csharp
public T[] Cache<T>(System.Func<T[]> func, bool allowNull=false)
    where T : Component;
```
#### Type parameters
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_T'></a>
`T`  
The type of component to search for.
  
#### Parameters
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;T[]&gt;, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The expensive function to call, only if it hasn't ever been called by this method on the current instance before.
  
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;T[]&gt;, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The components specified by [T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;T[]&gt;, bool).T').
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
