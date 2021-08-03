#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.HasComponent&lt;T&gt;(GameObject, T) Method
Determines if the current game object has a component of a specific type.  
```csharp
public static bool HasComponent<T>(this GameObject obj, out T component)
    where T : Component;
```
#### Type parameters
<a name='KeepCoding.Helper.HasComponent.T.(GameObject.T).T'></a>
`T`  
The type of component to find.
  
#### Parameters
<a name='KeepCoding.Helper.HasComponent.T.(GameObject.T).obj'></a>
`obj` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The game object to search with.
  
<a name='KeepCoding.Helper.HasComponent.T.(GameObject.T).component'></a>
`component` [T](Helper.HasComponent.zTIa2AQXO2eNRV4pF1BOVw.md#KeepCoding.Helper.HasComponent.T.(GameObject.T).T 'KeepCoding.Helper.HasComponent&lt;T&gt;(GameObject, T).T')  
The variable to store the component in.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if a component has been found of type [T](Helper.HasComponent.zTIa2AQXO2eNRV4pF1BOVw.md#KeepCoding.Helper.HasComponent.T.(GameObject.T).T 'KeepCoding.Helper.HasComponent&lt;T&gt;(GameObject, T).T') from [obj](Helper.HasComponent.zTIa2AQXO2eNRV4pF1BOVw.md#KeepCoding.Helper.HasComponent.T.(GameObject.T).obj 'KeepCoding.Helper.HasComponent&lt;T&gt;(GameObject, T).obj').
### Remarks
This uses [UnityEngine.GameObject.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.GetComponent--1 'UnityEngine.GameObject.GetComponent``1'), meaning that the component must be part of the same game object for this to return true.  
