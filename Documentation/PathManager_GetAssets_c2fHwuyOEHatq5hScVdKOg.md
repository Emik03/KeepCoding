#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssets&lt;T,TAsset&gt;(T, string) Method
Retrieves assets of a specific type from a different bundle file.  
```csharp
public static TAsset[] GetAssets<T,TAsset>(T _, string bundleVideoFileName)
    where TAsset : Object;
```
#### Type parameters
<a name='KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)_T'></a>
`T`  
The type to get the assembly from, which is used to get the name.
  
<a name='KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)_TAsset'></a>
`TAsset`  
The type of asset to return.
  
#### Parameters
<a name='KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)__'></a>
`_` [T](PathManager_GetAssets_c2fHwuyOEHatq5hScVdKOg.md#KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)_T 'KeepCoding.PathManager.GetAssets&lt;T,TAsset&gt;(T, string).T')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)_bundleVideoFileName'></a>
`bundleVideoFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle that contains videos.
  
#### Returns
[TAsset](PathManager_GetAssets_c2fHwuyOEHatq5hScVdKOg.md#KeepCoding_PathManager_GetAssets_T_TAsset_(T_string)_TAsset 'KeepCoding.PathManager.GetAssets&lt;T,TAsset&gt;(T, string).TAsset')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [UnityEngine.AssetBundleCreateRequest](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AssetBundleCreateRequest 'UnityEngine.AssetBundleCreateRequest') needed to load the files, followed by the [UnityEngine.Video.VideoClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Video.VideoClip 'UnityEngine.Video.VideoClip')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
