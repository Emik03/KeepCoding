#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager')
## PathManager.LoadLibrary(Type, string) Method
Loads a library by searching for the bundle.  
```csharp
public static void LoadLibrary(System.Type type, string libraryFileName);
```
#### Parameters
<a name='KeepCoding_PathManager_LoadLibrary(System_Type_string)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Any data from the assembly, which is used to get the name.
  
<a name='KeepCoding_PathManager_LoadLibrary(System_Type_string)_libraryFileName'></a>
`libraryFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The library's name, excluding the extension.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
If the library has already been loaded, then this method will prematurely halt.  
