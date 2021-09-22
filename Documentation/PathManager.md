#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## PathManager Class
Allows loading external information stored on the module. Default values are returned either when run on the editor or when an [System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException') and similar occur. The default values are specified in the remarks of each method.  
```csharp
public static class PathManager
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PathManager  

| Properties | |
| :--- | :--- |
| [Version](PathManager.Version.md 'KeepCoding.PathManager.Version') | Gets this library's version number. Currently used by [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript') to log the version number of this library.<br/> |

| Methods | |
| :--- | :--- |
| [CombineMultiple(string[])](PathManager.CombineMultiple.YuwHR8+ZviySdaFBbEepiQ.md 'KeepCoding.PathManager.CombineMultiple(string[])') | Combines multiple paths together.<br/> |
| [GetAssets&lt;T&gt;(string)](PathManager.GetAssets.i9Wu+chB+1jvPhxhfDuF0g.md 'KeepCoding.PathManager.GetAssets&lt;T&gt;(string)') | Retrieves assets of a specific type from a bundle file within the mod caller.<br/> |
| [GetAssets&lt;T&gt;(string, string)](PathManager.GetAssets.LQGVQfWTw2pRP+dH8Kg0gg.md 'KeepCoding.PathManager.GetAssets&lt;T&gt;(string, string)') | Retrieves assets of a specific type from a bundle file within a specified mod's assembly name.<br/> |
| [GetAssetsAsync&lt;T&gt;(string)](PathManager.GetAssetsAsync.BxhS.llN3lNDphUWv0QCag.md 'KeepCoding.PathManager.GetAssetsAsync&lt;T&gt;(string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetAssetsAsync&lt;T&gt;(string, string)](PathManager.GetAssetsAsync.+ryqIco9rTf03pyC1WZgjQ.md 'KeepCoding.PathManager.GetAssetsAsync&lt;T&gt;(string, string)') | Retrieves assets of a specific type from a different bundle file.<br/> |
| [GetDirectory()](PathManager.GetDirectory().md 'KeepCoding.PathManager.GetDirectory()') | Finds the directory of the mod caller.<br/> |
| [GetDirectory(string)](PathManager.GetDirectory.PxCKkzQ.eQgFtLQeot8Ppw.md 'KeepCoding.PathManager.GetDirectory(string)') | Finds the directory of the specified mod's assembly name.<br/> |
| [GetModInfo()](PathManager.GetModInfo().md 'KeepCoding.PathManager.GetModInfo()') | Deserializes the modInfo.json of the mod caller.<br/> |
| [GetModInfo(string)](PathManager.GetModInfo.yasiGDRIL0pHGpi56k7gSg.md 'KeepCoding.PathManager.GetModInfo(string)') | Deserializes the modInfo.json of a specified mod's assembly name.<br/> |
| [GetPath(string)](PathManager.GetPath.g+hbdyae81kNmq6jUuelvg.md 'KeepCoding.PathManager.GetPath(string)') | Finds the path of a given file within the mod caller. You need to specify the extensions of the file too, otherwise the file cannot be found.<br/> |
| [GetPath(string, string)](PathManager.GetPath.tUZslFgv6LjckNCrHHOckg.md 'KeepCoding.PathManager.GetPath(string, string)') | Finds the path of a given file within a specified mod's assembly name. You need to specify the extensions of the file too, otherwise the file cannot be found.<br/> |
| [LoadLibrary(string)](PathManager.LoadLibrary.fO88Irs5UI7ouBdWtnYpQA.md 'KeepCoding.PathManager.LoadLibrary(string)') | Loads a library from the directory of the mod caller.<br/> |
| [LoadLibrary(string, string)](PathManager.LoadLibrary.A3UAFyv.TBm8PGx1od8xCQ.md 'KeepCoding.PathManager.LoadLibrary(string, string)') | Loads a library from the directory of the specified mod's assembly name.<br/> |
| [PrintHierarchy(GameObject, int, ushort)](PathManager.PrintHierarchy.1LKQvc1VSmFQcIC9E8cNjw.md 'KeepCoding.PathManager.PrintHierarchy(GameObject, int, ushort)') | Prints the hierarchy from the game object specified.<br/> |
| [PrintHierarchy(int)](PathManager.PrintHierarchy.E..n6TOpbP5fx+hdIbmcUg.md 'KeepCoding.PathManager.PrintHierarchy(int)') | Prints a hierarchy of all game objects.<br/> |
