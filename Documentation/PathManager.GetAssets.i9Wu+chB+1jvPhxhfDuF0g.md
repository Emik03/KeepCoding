#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetAssets&lt;T&gt;(string) Method
Retrieves assets of a specific type from a bundle file within the mod caller.  
```csharp
public static T[] GetAssets<T>(string file)
    where T : Object;
```
#### Type parameters
<a name='KeepCoding.PathManager.GetAssets.T.(string).T'></a>
`T`  
The type of asset to retrieve.
  
#### Parameters
<a name='KeepCoding.PathManager.GetAssets.T.(string).file'></a>
`file` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file to grab the assets from.
  
#### Returns
[T](PathManager.GetAssets.i9Wu+chB+1jvPhxhfDuF0g.md#KeepCoding.PathManager.GetAssets.T.(string).T 'KeepCoding.PathManager.GetAssets&lt;T&gt;(string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The assets retrieved from the mod caller.
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
