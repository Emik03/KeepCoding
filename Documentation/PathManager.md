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
| [AssemblyName](PathManager.AssemblyName.md 'KeepCoding.PathManager.AssemblyName') | Gets this library's [AssemblyName](PathManager.AssemblyName.md 'KeepCoding.PathManager.AssemblyName').<br/> |
| [Version](PathManager.Version.md 'KeepCoding.PathManager.Version') | Gets this library's version number. Currently used by [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript') to log the version number of this library.<br/> |

| Methods | |
| :--- | :--- |
| [CombineMultiple(string[])](PathManager.CombineMultiple.YuwHR8+ZviySdaFBbEepiQ.md 'KeepCoding.PathManager.CombineMultiple(string[])') | Combines multiple paths together.<br/> |
| [GetAssets&lt;T,TAsset&gt;(T, string)](PathManager.GetAssets.c2fHwuyOEHatq5hScVdKOg.md 'KeepCoding.PathManager.GetAssets&lt;T,TAsset&gt;(T, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetAssets&lt;TAsset&gt;(string, string)](PathManager.GetAssets.uXpKvqa+Ry.ck6FJmDvMFA.md 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(string, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetAssets&lt;TAsset&gt;(Type, string)](PathManager.GetAssets.G77e0SahD.nTdTU638gMrA.md 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(System.Type, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetModInfo&lt;T&gt;(T)](PathManager.GetModInfo.e3z5Sk9DBgt1y0w8ZBsnlw.md 'KeepCoding.PathManager.GetModInfo&lt;T&gt;(T)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetModInfo(string)](PathManager.GetModInfo.yasiGDRIL0pHGpi56k7gSg.md 'KeepCoding.PathManager.GetModInfo(string)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetModInfo(Type)](PathManager.GetModInfo.DEUmnHMIodQgjMjKDZ4cWg.md 'KeepCoding.PathManager.GetModInfo(System.Type)') | Gets the path and deserializes the modInfo.json located at every mod's root folder.<br/> |
| [GetPath&lt;T&gt;(T)](PathManager.GetPath.9.6TDVlpOu0OAEPaiWS0fw.md 'KeepCoding.PathManager.GetPath&lt;T&gt;(T)') | Finds the path of the mod.<br/> |
| [GetPath(string)](PathManager.GetPath.g+hbdyae81kNmq6jUuelvg.md 'KeepCoding.PathManager.GetPath(string)') | Finds the path of a given file within each mod.<br/> |
| [GetPath(Type)](PathManager.GetPath.gEINYgODgEj5HAD4lhcKuQ.md 'KeepCoding.PathManager.GetPath(System.Type)') | Finds the path of the mod.<br/> |
| [LoadLibrary&lt;T&gt;(T, string)](PathManager.LoadLibrary.Uaj1ofaVTz.PItqMS6Eoeg.md 'KeepCoding.PathManager.LoadLibrary&lt;T&gt;(T, string)') | Loads a library by searching for the bundle.<br/> |
| [LoadLibrary(string, string)](PathManager.LoadLibrary.A3UAFyv.TBm8PGx1od8xCQ.md 'KeepCoding.PathManager.LoadLibrary(string, string)') | Loads a library by searching for the bundle.<br/> |
| [LoadLibrary(Type, string)](PathManager.LoadLibrary.JdDALpJM78A79nvBhgxLPw.md 'KeepCoding.PathManager.LoadLibrary(System.Type, string)') | Loads a library by searching for the bundle.<br/> |
| [NameOfAssembly&lt;T&gt;()](PathManager.NameOfAssembly.T.().md 'KeepCoding.PathManager.NameOfAssembly&lt;T&gt;()') | Gets the assembly's directory where the type [T](PathManager.NameOfAssembly.T.().md#KeepCoding.PathManager.NameOfAssembly.T.().T 'KeepCoding.PathManager.NameOfAssembly&lt;T&gt;().T') exists.<br/> |
| [NameOfAssembly(Type)](PathManager.NameOfAssembly.i4+Ql+giMkLthEL5bf7DJQ.md 'KeepCoding.PathManager.NameOfAssembly(System.Type)') | Gets the assembly's directory where the type [type](PathManager.NameOfAssembly.i4+Ql+giMkLthEL5bf7DJQ.md#KeepCoding.PathManager.NameOfAssembly(System.Type).type 'KeepCoding.PathManager.NameOfAssembly(System.Type).type') exists.<br/> |
| [PrintHierarchy(GameObject, ushort, ushort)](PathManager.PrintHierarchy.lL2ZGJXa8vHtABWUTFeEow.md 'KeepCoding.PathManager.PrintHierarchy(GameObject, ushort, ushort)') | Prints the hierarchy from the game object specified.<br/> |
| [PrintHierarchy(ushort)](PathManager.PrintHierarchy.c.clrPM8MQX.D9F3V0Eu6A.md 'KeepCoding.PathManager.PrintHierarchy(ushort)') | Prints a hierarchy of all game objects.<br/> |
