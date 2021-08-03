#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.GetDefaultValue(Type) Method
Returns the equivalent of `default(T)` for a `Type` object. For reference or nullable types, this is  
`null`, while for value types, it is the default value (e.g. `false`, `0`, etc.).
```csharp
public static object GetDefaultValue(this System.Type type);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.GetDefaultValue(System.Type).type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type to retrieve the default value for.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
