#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo&lt;T&gt;(T) Method
Gets the path and deserializes the modInfo.json located at every mod's root folder.  
```csharp
public static KeepCoding.ModInfo GetModInfo<T>(T _);
```
#### Type parameters
<a name='KeepCoding.PathManager.GetModInfo.T.(T).T'></a>
`T`  
The type to get the assembly from, which is used to get the name.
  
#### Parameters
<a name='KeepCoding.PathManager.GetModInfo.T.(T)._'></a>
`_` [T](PathManager.GetModInfo.e3z5Sk9DBgt1y0w8ZBsnlw.md#KeepCoding.PathManager.GetModInfo.T.(T).T 'KeepCoding.PathManager.GetModInfo&lt;T&gt;(T).T')  
Any data from the assembly, which is used to get the name.
  
#### Returns
[ModInfo](ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](ModInfo.md 'KeepCoding.ModInfo') of the mod info json file located in the mod.
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
