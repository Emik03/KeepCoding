#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Subarray&lt;T&gt;(T[], int, int) Method
Similar to [System.String.Substring(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Substring#System_String_Substring_System_Int32,System_Int32_ 'System.String.Substring(System.Int32,System.Int32)'), but for arrays. Returns a new array containing [length](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).length 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).length') items from the specified [startIndex](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).startIndex 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).startIndex') onwards.
```csharp
public static T[] Subarray<T>(this T[] array, int startIndex, int length);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Subarray.T.(T...int.int).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Subarray.T.(T...int.int).array'></a>
`array` [T](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).T 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding.UtilityHelper.Subarray.T.(T...int.int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding.UtilityHelper.Subarray.T.(T...int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).T 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [startIndex](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).startIndex 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).startIndex') is 0 and [length](UtilityHelper.Subarray.GjXBs512a4vuVI+Y5zzA0A.md#KeepCoding.UtilityHelper.Subarray.T.(T...int.int).length 'KeepCoding.UtilityHelper.Subarray&lt;T&gt;(T[], int, int).length') is  
the length of the input array.
