#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Write&lt;T&gt;(string, T) Method
Sends information to a static variable such that other modules can access it.  
```csharp
public void Write<T>(string key, T value);
```
#### Type parameters
<a name='KeepCoding.ModuleScript.Write.T.(string.T).T'></a>
`T`  
The type of the expected input.
  
#### Parameters
<a name='KeepCoding.ModuleScript.Write.T.(string.T).key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The key of the variable, a lot like a variable name.
  
<a name='KeepCoding.ModuleScript.Write.T.(string.T).value'></a>
`value` [T](ModuleScript.Write.MUlE8lXsuyARXkdh4ORgbw.md#KeepCoding.ModuleScript.Write.T.(string.T).T 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T).T')  
The value to store in the key.
  
### Remarks
To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.  
