#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.GetModInfo&lt;T&gt;(T) Method
Gets the path and deserializes the modInfo.json located at every mod's root folder.  
```csharp
public static KeepCoding.ModInfo GetModInfo<T>(T _);
```
#### Type parameters
<a name='KeepCoding_PathManager_GetModInfo_T_(T)_T'></a>
`T`  
The type to get the assembly from, which is used to get the name.
  
#### Parameters
<a name='KeepCoding_PathManager_GetModInfo_T_(T)__'></a>
`_` [T](KeepCoding_PathManager_GetModInfo_T_(T).md#KeepCoding_PathManager_GetModInfo_T_(T)_T 'KeepCoding.PathManager.GetModInfo&lt;T&gt;(T).T')  
Any data from the assembly, which is used to get the name.
  
#### Returns
[ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo')  
A [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo') of the mod info json file located in the mod.
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
