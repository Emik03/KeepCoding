#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Remove&lt;T&gt;(T[], int) Method
Similar to [System.String.Remove(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Remove#System_String_Remove_System_Int32_ 'System.String.Remove(System.Int32)'), but for arrays. Returns a new array containing only the items  
before the specified [startIndex](UtilityExtensions_Remove_n4lSLQ3KbfCsLyE9Hf9nkg.md#KeepCoding_UtilityExtensions_Remove_T_(T___int)_startIndex 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int).startIndex').
```csharp
public static T[] Remove<T>(this T[] array, int startIndex);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int)_array'></a>
`array` [T](UtilityExtensions_Remove_n4lSLQ3KbfCsLyE9Hf9nkg.md#KeepCoding_UtilityExtensions_Remove_T_(T___int)_T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding_UtilityExtensions_Remove_T_(T___int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityExtensions_Remove_n4lSLQ3KbfCsLyE9Hf9nkg.md#KeepCoding_UtilityExtensions_Remove_T_(T___int)_T 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [startIndex](UtilityExtensions_Remove_n4lSLQ3KbfCsLyE9Hf9nkg.md#KeepCoding_UtilityExtensions_Remove_T_(T___int)_startIndex 'KeepCoding.UtilityExtensions.Remove&lt;T&gt;(T[], int).startIndex') is the length of the array.
