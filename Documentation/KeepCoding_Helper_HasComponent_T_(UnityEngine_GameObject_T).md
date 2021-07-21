#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.HasComponent&lt;T&gt;(GameObject, T) Method
Determines if the current game object has a component of a specific type.  
```csharp
public static bool HasComponent<T>(this UnityEngine.GameObject obj, out T component)
    where T : UnityEngine.Component;
```
#### Type parameters
<a name='KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_T'></a>
`T`  
The type of component to find.
  
#### Parameters
<a name='KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_obj'></a>
`obj` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The game object to search with.
  
<a name='KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_component'></a>
`component` [T](KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T).md#KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_T 'KeepCoding.Helper.HasComponent&lt;T&gt;(UnityEngine.GameObject, T).T')  
The variable to store the component in.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if a component has been found of type [T](KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T).md#KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_T 'KeepCoding.Helper.HasComponent&lt;T&gt;(UnityEngine.GameObject, T).T') from [obj](KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T).md#KeepCoding_Helper_HasComponent_T_(UnityEngine_GameObject_T)_obj 'KeepCoding.Helper.HasComponent&lt;T&gt;(UnityEngine.GameObject, T).obj').
### Remarks
This uses [UnityEngine.GameObject.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponent--1 'UnityEngine.GameObject.GetComponent``1'), meaning that the component must be part of the same game object for this to return true.  
