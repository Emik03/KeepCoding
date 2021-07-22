#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.LoadLibrary(string, string) Method
Loads a library by searching for the bundle. Do not run this on the Editor.  
```csharp
public static void LoadLibrary(string bundleFileName, string libraryFileName);
```
#### Parameters
<a name='KeepCoding_PathManager_LoadLibrary(string_string)_bundleFileName'></a>
`bundleFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the bundle file.
  
<a name='KeepCoding_PathManager_LoadLibrary(string_string)_libraryFileName'></a>
`libraryFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The library's name, excluding the extension.
  
#### Exceptions
[EmptyIteratorException](https://docs.microsoft.com/en-us/dotnet/api/EmptyIteratorException 'EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](https://docs.microsoft.com/en-us/dotnet/api/NullIteratorException 'NullIteratorException')  
### Remarks
If the library has already been loaded, then this method will prematurely halt.  
