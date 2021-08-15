#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssets&lt;T&gt;(string, string) Method
Retrieves assets of a specific type from a bundle file within a specified mod's assembly name.  
```csharp
public static T[] GetAssets<T>(string file, string assembly)
    where T : Object;
```
#### Type parameters
<a name='KeepCoding.PathManager.GetAssets.T.(string.string).T'></a>
`T`  
The type of asset to retrieve.
  
#### Parameters
<a name='KeepCoding.PathManager.GetAssets.T.(string.string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file to grab the assets from.
  
<a name='KeepCoding.PathManager.GetAssets.T.(string.string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name.
  
#### Returns
[T](PathManager.GetAssets.LQGVQfWTw2pRP+dH8Kg0gg.md#KeepCoding.PathManager.GetAssets.T.(string.string).T 'KeepCoding.PathManager.GetAssets&lt;T&gt;(string, string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The assets retrieved from [assembly](PathManager.GetAssets.LQGVQfWTw2pRP+dH8Kg0gg.md#KeepCoding.PathManager.GetAssets.T.(string.string).assembly 'KeepCoding.PathManager.GetAssets&lt;T&gt;(string, string).assembly').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
