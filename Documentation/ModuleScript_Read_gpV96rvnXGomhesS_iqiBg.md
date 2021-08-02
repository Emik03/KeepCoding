#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Read&lt;T&gt;(string, string, bool) Method
Allows you to read a module's data that uses [Write&lt;T&gt;(string, T)](ModuleScript_Write_MUlE8lXsuyARXkdh4ORgbw.md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)'), even from a different assembly.  
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
[T](ModuleScript_Read_gpV96rvnXGomhesS_iqiBg.md#KeepCoding_ModuleScript_Read_T_(string_string_bool)_T 'KeepCoding.ModuleScript.Read&lt;T&gt;(string, string, bool).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Every instance of the value from the every instance of the module specified.
#### Exceptions
[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
[UnrecognizedTypeException](UnrecognizedTypeException.md 'KeepCoding.Internal.UnrecognizedTypeException')  
### Remarks
To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.  
