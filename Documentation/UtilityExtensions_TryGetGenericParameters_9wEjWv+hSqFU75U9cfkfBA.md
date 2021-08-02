#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.TryGetGenericParameters(Type, Type, Type[]) Method
Determines whether the current type is, derives from, or implements the specified generic type, and determines  
that type’s generic type parameters.
```csharp
public static bool TryGetGenericParameters(this System.Type type, System.Type typeToFind, out System.Type[] typeParameters);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_TryGetGenericParameters(System_Type_System_Type_System_Type__)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The current type.
  
<a name='KeepCoding_UtilityExtensions_TryGetGenericParameters(System_Type_System_Type_System_Type__)_typeToFind'></a>
`typeToFind` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
A generic type definition for a base type of interface, e.g. `typeof(ICollection<>)` or  
`typeof(IDictionary<,>)`.
  
<a name='KeepCoding_UtilityExtensions_TryGetGenericParameters(System_Type_System_Type_System_Type__)_typeParameters'></a>
`typeParameters` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Receives an array containing the generic type parameters of the generic type.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the current type is, derives from or implements the specified generic type.
