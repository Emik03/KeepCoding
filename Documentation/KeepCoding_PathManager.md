#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## PathManager Class
Allows loading external information stored on the module.   
```csharp
public static class PathManager
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PathManager  

| Properties | |
| :--- | :--- |
| [AssemblyName](KeepCoding_PathManager_AssemblyName.md 'KeepCoding.PathManager.AssemblyName') |  |
| [Version](KeepCoding_PathManager_Version.md 'KeepCoding.PathManager.Version') |  |

| Methods | |
| :--- | :--- |
| [CombineMultiple(string[])](KeepCoding_PathManager_CombineMultiple(string__).md 'KeepCoding.PathManager.CombineMultiple(string[])') | Combines multiple paths together.<br/> |
| [GetAssets&lt;T,TAsset&gt;(T, string)](KeepCoding_PathManager_GetAssets_T_TAsset_(T_string).md 'KeepCoding.PathManager.GetAssets&lt;T,TAsset&gt;(T, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetAssets&lt;TAsset&gt;(string, string)](KeepCoding_PathManager_GetAssets_TAsset_(string_string).md 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(string, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetAssets&lt;TAsset&gt;(Type, string)](KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string).md 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(System.Type, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetModInfo&lt;T&gt;(T)](KeepCoding_PathManager_GetModInfo_T_(T).md 'KeepCoding.PathManager.GetModInfo&lt;T&gt;(T)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetModInfo(string)](KeepCoding_PathManager_GetModInfo(string).md 'KeepCoding.PathManager.GetModInfo(string)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetModInfo(Type)](KeepCoding_PathManager_GetModInfo(System_Type).md 'KeepCoding.PathManager.GetModInfo(System.Type)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetPath&lt;T&gt;(T)](KeepCoding_PathManager_GetPath_T_(T).md 'KeepCoding.PathManager.GetPath&lt;T&gt;(T)') | Finds the path of the mod.<br/> |
| [GetPath(string)](KeepCoding_PathManager_GetPath(string).md 'KeepCoding.PathManager.GetPath(string)') | Finds the path of a given file within each mod.<br/> |
| [GetPath(Type)](KeepCoding_PathManager_GetPath(System_Type).md 'KeepCoding.PathManager.GetPath(System.Type)') | Finds the path of the mod.<br/> |
| [LoadLibrary&lt;T&gt;(T, string)](KeepCoding_PathManager_LoadLibrary_T_(T_string).md 'KeepCoding.PathManager.LoadLibrary&lt;T&gt;(T, string)') | Loads a library by searching for the bundle. Do not run this on the Editor.<br/> |
| [LoadLibrary(string, string)](KeepCoding_PathManager_LoadLibrary(string_string).md 'KeepCoding.PathManager.LoadLibrary(string, string)') | Loads a library by searching for the bundle. Do not run this on the Editor.<br/> |
| [LoadLibrary(Type, string)](KeepCoding_PathManager_LoadLibrary(System_Type_string).md 'KeepCoding.PathManager.LoadLibrary(System.Type, string)') | Loads a library by searching for the bundle. Do not run this on the Editor.<br/> |
| [NameOfAssembly&lt;T&gt;()](KeepCoding_PathManager_NameOfAssembly_T_().md 'KeepCoding.PathManager.NameOfAssembly&lt;T&gt;()') | Gets the assembly's directory where the type [T](KeepCoding_PathManager_NameOfAssembly_T_().md#KeepCoding_PathManager_NameOfAssembly_T_()_T 'KeepCoding.PathManager.NameOfAssembly&lt;T&gt;().T') exists.<br/> |
| [NameOfAssembly(Type)](KeepCoding_PathManager_NameOfAssembly(System_Type).md 'KeepCoding.PathManager.NameOfAssembly(System.Type)') | Gets the assembly's directory where the type [type](KeepCoding_PathManager_NameOfAssembly(System_Type).md#KeepCoding_PathManager_NameOfAssembly(System_Type)_type 'KeepCoding.PathManager.NameOfAssembly(System.Type).type') exists.<br/> |
| [PrintHierarchy(GameObject, ushort, ushort)](KeepCoding_PathManager_PrintHierarchy(GameObject_ushort_ushort).md 'KeepCoding.PathManager.PrintHierarchy(GameObject, ushort, ushort)') | Prints the hierarchy from the game object specified.<br/> |
| [PrintHierarchy(ushort)](KeepCoding_PathManager_PrintHierarchy(ushort).md 'KeepCoding.PathManager.PrintHierarchy(ushort)') | Prints a hierarchy of all game objects.<br/> |
