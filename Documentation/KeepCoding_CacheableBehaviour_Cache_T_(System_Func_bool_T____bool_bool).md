### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.Cache&lt;T&gt;(Func&lt;bool,T[]&gt;, bool, bool) Method
Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.  
```csharp
public T[] Cache<T>(System.Func<bool,T[]> func, bool parameter=false, bool allowNull=false)
    where T : Component;
```
#### Type parameters
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_T'></a>
`T`  
The type of component to search for.
  
#### Parameters
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;bool,T[]&gt;, bool, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The expensive function to call, only if it hasn't ever been called by this method on the current instance before.
  
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_parameter'></a>
`parameter` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The argument to put in the expensive method call.
  
<a name='KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;bool,T[]&gt;, bool, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The components specified by [T](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool).md#KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool)_T 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;bool,T[]&gt;, bool, bool).T').
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
