#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Remove&lt;T&gt;(T[], int, int) Method
Similar to [System.String.Remove(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Remove#System_String_Remove_System_Int32,System_Int32_ 'System.String.Remove(System.Int32,System.Int32)'), but for arrays. Returns a new array containing everything  
except the [length](UtilityExtensions.Remove.hMqTtqCb4JbORObAkXV4WA.md#KeepCoding.UtilityExtensions.Remove.T.(T...int.int).length 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).length') items starting from the specified [startIndex](UtilityExtensions.Remove.hMqTtqCb4JbORObAkXV4WA.md#KeepCoding.UtilityExtensions.Remove.T.(T...int.int).startIndex 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).startIndex').
```csharp
public static T[] Remove<T>(this T[] array, int startIndex, int length);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.Remove.T.(T...int.int).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.Remove.T.(T...int.int).array'></a>
`array` [T](UtilityExtensions.Remove.hMqTtqCb4JbORObAkXV4WA.md#KeepCoding.UtilityExtensions.Remove.T.(T...int.int).T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding.UtilityExtensions.Remove.T.(T...int.int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding.UtilityExtensions.Remove.T.(T...int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityExtensions.Remove.hMqTtqCb4JbORObAkXV4WA.md#KeepCoding.UtilityExtensions.Remove.T.(T...int.int).T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [length](UtilityExtensions.Remove.hMqTtqCb4JbORObAkXV4WA.md#KeepCoding.UtilityExtensions.Remove.T.(T...int.int).length 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).length') is 0.
