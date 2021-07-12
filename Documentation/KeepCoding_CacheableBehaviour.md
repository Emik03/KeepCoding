### [KeepCoding](KeepCoding.md 'KeepCoding')
## CacheableBehaviour Class
A [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') with additional caching capabilities. Written by Emik.  
```csharp
public class CacheableBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; CacheableBehaviour  

Derived  
&#8627; [AudioScript](KeepCoding_AudioScript.md 'KeepCoding.AudioScript')  
&#8627; [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')  
&#8627; [TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')  

| Methods | |
| :--- | :--- |
| [Cache&lt;T&gt;(Func&lt;bool,T[]&gt;, bool, bool)](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_bool_T____bool_bool).md 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;bool,T[]&gt;, bool, bool)') | Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.<br/> |
| [Cache&lt;T&gt;(Func&lt;T[]&gt;, bool)](KeepCoding_CacheableBehaviour_Cache_T_(System_Func_T____bool).md 'KeepCoding.CacheableBehaviour.Cache&lt;T&gt;(System.Func&lt;T[]&gt;, bool)') | Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.<br/> |
| [Find&lt;T&gt;(bool)](KeepCoding_CacheableBehaviour_Find_T_(bool).md 'KeepCoding.CacheableBehaviour.Find&lt;T&gt;(bool)') | Similar to [UnityEngine.Object.FindObjectsOfType&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object.FindObjectsOfType--1 'UnityEngine.Object.FindObjectsOfType``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [FindAll&lt;T&gt;(bool)](KeepCoding_CacheableBehaviour_FindAll_T_(bool).md 'KeepCoding.CacheableBehaviour.FindAll&lt;T&gt;(bool)') | Similar to [UnityEngine.Object.FindObjectsOfType&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object.FindObjectsOfType--1 'UnityEngine.Object.FindObjectsOfType``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [Get&lt;T&gt;(bool)](KeepCoding_CacheableBehaviour_Get_T_(bool).md 'KeepCoding.CacheableBehaviour.Get&lt;T&gt;(bool)') | Similar to [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [GetChild&lt;T&gt;(bool, bool)](KeepCoding_CacheableBehaviour_GetChild_T_(bool_bool).md 'KeepCoding.CacheableBehaviour.GetChild&lt;T&gt;(bool, bool)') | Similar to [UnityEngine.Component.GetComponentInChildren&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponentInChildren--1 'UnityEngine.Component.GetComponentInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [GetChildren&lt;T&gt;(bool, bool)](KeepCoding_CacheableBehaviour_GetChildren_T_(bool_bool).md 'KeepCoding.CacheableBehaviour.GetChildren&lt;T&gt;(bool, bool)') | Similar to [UnityEngine.GameObject.GetComponentsInChildren&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponentsInChildren--1 'UnityEngine.GameObject.GetComponentsInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [GetParent&lt;T&gt;(bool, bool)](KeepCoding_CacheableBehaviour_GetParent_T_(bool_bool).md 'KeepCoding.CacheableBehaviour.GetParent&lt;T&gt;(bool, bool)') | Similar to [UnityEngine.Component.GetComponentInChildren&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponentInChildren--1 'UnityEngine.Component.GetComponentInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [GetParents&lt;T&gt;(bool, bool)](KeepCoding_CacheableBehaviour_GetParents_T_(bool_bool).md 'KeepCoding.CacheableBehaviour.GetParents&lt;T&gt;(bool, bool)') | Similar to [UnityEngine.GameObject.GetComponentsInParent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponentsInParent--1 'UnityEngine.GameObject.GetComponentsInParent``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
| [Gets&lt;T&gt;(bool)](KeepCoding_CacheableBehaviour_Gets_T_(bool).md 'KeepCoding.CacheableBehaviour.Gets&lt;T&gt;(bool)') | Similar to [UnityEngine.GameObject.GetComponents&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponents--1 'UnityEngine.GameObject.GetComponents``1'), however it caches the result in a dictionary, and will return the cached result if called again.<br/> |
