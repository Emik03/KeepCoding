#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssetsAsync&lt;T&gt;(string) Method
Retrieves assets of a specific type from a different bundle file.  
```csharp
public static KeepCoding.Work<T[]> GetAssetsAsync<T>(string file)
    where T : Object;
```
#### Type parameters
<a name='KeepCoding.PathManager.GetAssetsAsync.T.(string).T'></a>
`T`  
The type of asset to retrieve.
  
#### Parameters
<a name='KeepCoding.PathManager.GetAssetsAsync.T.(string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file to grab the assets from.
  
#### Returns
[KeepCoding.Work&lt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')[T](PathManager.GetAssetsAsync.BxhS.llN3lNDphUWv0QCag.md#KeepCoding.PathManager.GetAssetsAsync.T.(string).T 'KeepCoding.PathManager.GetAssetsAsync&lt;T&gt;(string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')  
A [Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;') instance that can retrieve the assets from the mod caller.
