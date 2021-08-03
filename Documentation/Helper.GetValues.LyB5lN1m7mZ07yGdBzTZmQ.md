#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.GetValues&lt;T&gt;(T) Method
Gets all the values of an [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') as an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T[] GetValues<T>(this T _)
    where T : struct, System.Enum;
```
#### Type parameters
<a name='KeepCoding.Helper.GetValues.T.(T).T'></a>
`T`  
The type of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum').
  
#### Parameters
<a name='KeepCoding.Helper.GetValues.T.(T)._'></a>
`_` [T](Helper.GetValues.LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding.Helper.GetValues.T.(T).T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T')  
A discard value, which can implicitly let the method know the type.
  
#### Returns
[T](Helper.GetValues.LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding.Helper.GetValues.T.(T).T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [T](Helper.GetValues.LyB5lN1m7mZ07yGdBzTZmQ.md#KeepCoding.Helper.GetValues.T.(T).T 'KeepCoding.Helper.GetValues&lt;T&gt;(T).T') containing all the values of that enum.
