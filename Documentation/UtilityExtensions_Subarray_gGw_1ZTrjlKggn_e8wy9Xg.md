#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Subarray&lt;T&gt;(T[], int) Method
Similar to [System.String.Substring(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Substring#System_String_Substring_System_Int32_ 'System.String.Substring(System.Int32)'), but for arrays. Returns a new array containing all items from  
the specified [startIndex](UtilityExtensions_Subarray_gGw_1ZTrjlKggn_e8wy9Xg.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int)_startIndex 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int).startIndex') onwards.
```csharp
public static T[] Subarray<T>(this T[] array, int startIndex);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int)_array'></a>
`array` [T](UtilityExtensions_Subarray_gGw_1ZTrjlKggn_e8wy9Xg.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int)_T 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding_UtilityExtensions_Subarray_T_(T___int)_startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityExtensions_Subarray_gGw_1ZTrjlKggn_e8wy9Xg.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int)_T 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [startIndex](UtilityExtensions_Subarray_gGw_1ZTrjlKggn_e8wy9Xg.md#KeepCoding_UtilityExtensions_Subarray_T_(T___int)_startIndex 'KeepCoding.UtilityExtensions.Subarray&lt;T&gt;(T[], int).startIndex') is 0.
