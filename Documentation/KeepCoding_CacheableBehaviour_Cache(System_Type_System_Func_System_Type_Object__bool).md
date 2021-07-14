#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour')
## CacheableBehaviour.Cache(Type, Func&lt;Type,Object&gt;, bool) Method
Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.  
```csharp
public Object Cache(System.Type type, System.Func<System.Type,Object> func, bool allowNull=false);
```
#### Parameters
<a name='KeepCoding_CacheableBehaviour_Cache(System_Type_System_Func_System_Type_Object__bool)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of component to search for.
  
<a name='KeepCoding_CacheableBehaviour_Cache(System_Type_System_Func_System_Type_Object__bool)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The expensive function to call, only if it hasn't ever been called by this method on the current instance before.
  
<a name='KeepCoding_CacheableBehaviour_Cache(System_Type_System_Func_System_Type_Object__bool)_allowNull'></a>
`allowNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if it sees [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), if not it will return the default value. (Likely [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'))
  
#### Returns
[UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object')  
The components specified by [type](KeepCoding_CacheableBehaviour_Cache(System_Type_System_Func_System_Type_Object__bool).md#KeepCoding_CacheableBehaviour_Cache(System_Type_System_Func_System_Type_Object__bool)_type 'KeepCoding.CacheableBehaviour.Cache(System.Type, System.Func&lt;System.Type,Object&gt;, bool).type').
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  