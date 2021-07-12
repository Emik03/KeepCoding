### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.LoadLibrary&lt;T&gt;(T, string) Method
Loads a library by searching for the bundle. Do not run this on the Editor.  
```csharp
public static void LoadLibrary<T>(T _, string libraryFileName);
```
#### Type parameters
<a name='KeepCoding_PathManager_LoadLibrary_T_(T_string)_T'></a>
`T`  
The type to get the assembly from, which is used to get the name.
  
#### Parameters
<a name='KeepCoding_PathManager_LoadLibrary_T_(T_string)__'></a>
`_` [T](KeepCoding_PathManager_LoadLibrary_T_(T_string).md#KeepCoding_PathManager_LoadLibrary_T_(T_string)_T 'KeepCoding.PathManager.LoadLibrary&lt;T&gt;(T, string).T')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding_PathManager_LoadLibrary_T_(T_string)_libraryFileName'></a>
`libraryFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The library's name, excluding the extension.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
### Remarks
If the library has already been loaded, then this method will prematurely halt.  
