#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssets&lt;TAsset&gt;(string, string) Method
Retrieves assets of a specific type from a different bundle file.  
```csharp
public static TAsset[] GetAssets<TAsset>(string bundleFileName, string bundleAssetFileName)
    where TAsset : Object;
```
#### Type parameters
<a name='KeepCoding.PathManager.GetAssets.TAsset.(string.string).TAsset'></a>
`TAsset`  
The type of asset to retrieve.
  
#### Parameters
<a name='KeepCoding.PathManager.GetAssets.TAsset.(string.string).bundleFileName'></a>
`bundleFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file.
  
<a name='KeepCoding.PathManager.GetAssets.TAsset.(string.string).bundleAssetFileName'></a>
`bundleAssetFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file to grab the assets from.
  
#### Returns
[TAsset](PathManager.GetAssets.uXpKvqa+Ry.ck6FJmDvMFA.md#KeepCoding.PathManager.GetAssets.TAsset.(string.string).TAsset 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(string, string).TAsset')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The assets retrieved from the file.
