#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Remove&lt;T&gt;(T[], int, int) Method
Similar to [System.String.Remove(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Remove#System_String_Remove_System_Int32,System_Int32_ 'System.String.Remove(System.Int32,System.Int32)'), but for arrays. Returns a new array containing everything  
except the [length](UtilityExtensions_Remove_hMqTtqCb4JbORObAkXV4WA.md#KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_length 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).length') items starting from the specified [startIndex](UtilityExtensions_Remove_hMqTtqCb4JbORObAkXV4WA.md#KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_startIndex 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).startIndex').
```csharp
public static T[] Remove<T>(this T[] array, int startIndex, int length);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_array'></a>
`array` [T](UtilityExtensions_Remove_hMqTtqCb4JbORObAkXV4WA.md#KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityExtensions_Remove_hMqTtqCb4JbORObAkXV4WA.md#KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [length](UtilityExtensions_Remove_hMqTtqCb4JbORObAkXV4WA.md#KeepCoding_UtilityExtensions_Remove_T_(T___int_int)_length 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int, int).length') is 0.
