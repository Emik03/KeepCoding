#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetPath&lt;T&gt;(T, string) Method
Finds the path of a given file within each mod.  
```csharp
public static string GetPath<T>(T _, string search);
```
#### Type parameters
<a name='KeepCoding.PathManager.GetPath.T.(T.string).T'></a>
`T`  
The type to get the assembly from, which is used to get the name.
  
#### Parameters
<a name='KeepCoding.PathManager.GetPath.T.(T.string)._'></a>
`_` [T](PathManager.GetPath.KyRt8Nr0o5Tz2yxr99WFEg.md#KeepCoding.PathManager.GetPath.T.(T.string).T 'KeepCoding.PathManager.GetPath&lt;T&gt;(T, string).T')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding.PathManager.GetPath.T.(T.string).search'></a>
`search` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The file to search for. Make sure to include extensions!
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to the mod.
