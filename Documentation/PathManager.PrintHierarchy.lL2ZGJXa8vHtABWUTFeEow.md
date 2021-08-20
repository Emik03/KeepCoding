#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.PrintHierarchy(GameObject, ushort, ushort) Method
Prints the hierarchy from the game object specified.  
```csharp
public static void PrintHierarchy(GameObject obj, ushort indent=4, ushort depth=0);
```
#### Parameters
<a name='KeepCoding.PathManager.PrintHierarchy(GameObject.ushort.ushort).obj'></a>
`obj` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The game object to search the hierarchy.
  
<a name='KeepCoding.PathManager.PrintHierarchy(GameObject.ushort.ushort).indent'></a>
`indent` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The amount of spaces used for indenting children of game objects.
  
<a name='KeepCoding.PathManager.PrintHierarchy(GameObject.ushort.ushort).depth'></a>
`depth` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The level of depth which determines level of indentation. Leave this variable as 0.
  
#### Exceptions
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
