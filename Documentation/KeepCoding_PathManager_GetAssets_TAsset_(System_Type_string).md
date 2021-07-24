#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssets&lt;TAsset&gt;(Type, string) Method
Retrieves assets of a specific type from a different bundle file.  
```csharp
public static TAsset[] GetAssets<TAsset>(System.Type type, string bundleVideoFileName)
    where TAsset : Object;
```
#### Type parameters
<a name='KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string)_TAsset'></a>
`TAsset`  
  
#### Parameters
<a name='KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string)_bundleVideoFileName'></a>
`bundleVideoFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle that contains videos.
  
#### Returns
[TAsset](KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string).md#KeepCoding_PathManager_GetAssets_TAsset_(System_Type_string)_TAsset 'KeepCoding.PathManager.GetAssets&lt;TAsset&gt;(System.Type, string).TAsset')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [UnityEngine.AssetBundleCreateRequest](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AssetBundleCreateRequest 'UnityEngine.AssetBundleCreateRequest') needed to load the files, followed by the [UnityEngine.Video.VideoClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Video.VideoClip 'UnityEngine.Video.VideoClip')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
