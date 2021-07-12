### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Read&lt;T&gt;(string, string, bool) Method
Allows you to read a module's data that uses [Write&lt;T&gt;(string, T)](KeepCoding_ModuleScript_Write_T_(string_T).md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)'), even from a different assembly.  
```csharp
public static T[] Read<T>(string module, string key, bool allowDefault=false);
```
#### Type parameters
<a name='KeepCoding_ModuleScript_Read_T_(string_string_bool)_T'></a>
`T`  
The type of the expected output.
  
#### Parameters
<a name='KeepCoding_ModuleScript_Read_T_(string_string_bool)_module'></a>
`module` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The module to look into.
  
<a name='KeepCoding_ModuleScript_Read_T_(string_string_bool)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The key of the variable, a lot like a variable name.
  
<a name='KeepCoding_ModuleScript_Read_T_(string_string_bool)_allowDefault'></a>
`allowDefault` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should throw an exception if no value is found, or provide the default value instead.
  
#### Returns
[T](KeepCoding_ModuleScript_Read_T_(string_string_bool).md#KeepCoding_ModuleScript_Read_T_(string_string_bool)_T 'KeepCoding.ModuleScript.Read&lt;T&gt;(string, string, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Every instance of the value from the every instance of the module specified.
#### Exceptions
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[WrongDatatypeException](KeepCoding_WrongDatatypeException.md 'KeepCoding.WrongDatatypeException')  
### Remarks
To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.  
