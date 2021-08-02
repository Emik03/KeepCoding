#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.GetValues&lt;T&gt;(T) Method
Gets all the values of an [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') as an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T[] GetValues<T>(this T _)
    where T : struct, System.Enum;
```
#### Type parameters
<a name='KeepCoding_Helper_GetValues_T_(T)_T'></a>
`T`  
The type of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum').
  
#### Parameters
<a name='KeepCoding_Helper_GetValues_T_(T)__'></a>
`_` [T](Helper_GetValues_LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding_Helper_GetValues_T_(T)_T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T')  
A discard value, which can implicitly let the method know the type.
  
#### Returns
[T](Helper_GetValues_LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding_Helper_GetValues_T_(T)_T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [T](Helper_GetValues_LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding_Helper_GetValues_T_(T)_T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T') containing all the values of that enum.
