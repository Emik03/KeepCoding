#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.GetValues&lt;T&gt;() Method
Gets all the values of an [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') as an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T[] GetValues<T>()
    where T : struct, System.Enum;
```
#### Type parameters
<a name='KeepCoding_Helper_GetValues_T_()_T'></a>
`T`  
The type of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum').
  
#### Returns
[T](KeepCoding_Helper_GetValues_T_().md#KeepCoding_Helper_GetValues_T_()_T 'KeepCoding.Helper.GetValues&lt;T&gt;().T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [T](KeepCoding_Helper_GetValues_T_().md#KeepCoding_Helper_GetValues_T_()_T 'KeepCoding.Helper.GetValues&lt;T&gt;().T') containing all the values of that enum.
