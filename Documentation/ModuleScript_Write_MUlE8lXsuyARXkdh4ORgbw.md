#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Write&lt;T&gt;(string, T) Method
Sends information to a static variable such that other modules can access it.  
```csharp
public void Write<T>(string key, T value);
```
#### Type parameters
<a name='KeepCoding_ModuleScript_Write_T_(string_T)_T'></a>
`T`  
The type of the expected input.
  
#### Parameters
<a name='KeepCoding_ModuleScript_Write_T_(string_T)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The key of the variable, a lot like a variable name.
  
<a name='KeepCoding_ModuleScript_Write_T_(string_T)_value'></a>
`value` [T](ModuleScript_Write_MUlE8lXsuyARXkdh4ORgbw.md#KeepCoding_ModuleScript_Write_T_(string_T)_T 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T).T')  
The value to store in the key.
  
### Remarks
To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.  
