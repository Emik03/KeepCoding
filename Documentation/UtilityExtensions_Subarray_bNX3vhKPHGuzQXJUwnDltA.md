#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Subarray&lt;T&gt;(T[], int, int) Method
Similar to [System.String.Substring(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Substring#System_String_Substring_System_Int32,System_Int32_ 'System.String.Substring(System.Int32,System.Int32)'), but for arrays. Returns a new array containing [length](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_length 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).length') items from the specified [startIndex](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_startIndex 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).startIndex') onwards.
```csharp
public static T[] Subarray<T>(this T[] array, int startIndex, int length);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_array'></a>
`array` [T](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_T 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_T 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [startIndex](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_startIndex 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).startIndex') is 0 and [length](UtilityExtensions_Subarray_bNX3vhKPHGuzQXJUwnDltA.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int_int)_length 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int, int).length') is  
the length of the input array.
