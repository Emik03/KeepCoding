#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssetsAsync&lt;T&gt;(string, string) Method
Retrieves assets of a specific type from a different bundle file.  
```csharp
public static KeepCoding.Work<T[]> GetAssetsAsync<T>(string file, string assembly)
    where T : Object;
```
#### Type parameters
<a name='KeepCoding.PathManager.GetAssetsAsync.T.(string.string).T'></a>
`T`  
The type of asset to retrieve.
  
#### Parameters
<a name='KeepCoding.PathManager.GetAssetsAsync.T.(string.string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file to grab the assets from.
  
<a name='KeepCoding.PathManager.GetAssetsAsync.T.(string.string).assembly'></a>
`assembly` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The mod assembly's name.
  
#### Returns
[KeepCoding.Work&lt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')[T](PathManager.GetAssetsAsync.+ryqIco9rTf03pyC1WZgjQ.md#KeepCoding.PathManager.GetAssetsAsync.T.(string.string).T 'KeepCoding.PathManager.GetAssetsAsync&lt;T&gt;(string, string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')  
A [Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;') instance that can retrieve the assets from [assembly](PathManager.GetAssetsAsync.+ryqIco9rTf03pyC1WZgjQ.md#KeepCoding.PathManager.GetAssetsAsync.T.(string.string).assembly 'KeepCoding.PathManager.GetAssetsAsync&lt;T&gt;(string, string).assembly').
