#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.IsDefined&lt;T&gt;(ParameterInfo) Method
Indicates whether one or more instance of the specified attribute type is applied to this parameter.
```csharp
public static bool IsDefined<T>(this System.Reflection.ParameterInfo parameter);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_IsDefined_T_(System_Reflection_ParameterInfo)_T'></a>
`T`  
The type of attribute to search for.
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_IsDefined_T_(System_Reflection_ParameterInfo)_parameter'></a>
`parameter` [System.Reflection.ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo 'System.Reflection.ParameterInfo')  
Parameter whose custom attributes to search.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
