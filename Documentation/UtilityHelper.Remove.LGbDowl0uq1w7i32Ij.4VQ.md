#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Remove&lt;T&gt;(T[], int) Method
Similar to [System.String.Remove(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Remove#System_String_Remove_System_Int32_ 'System.String.Remove(System.Int32)'), but for arrays. Returns a new array containing only the items  
before the specified [startIndex](UtilityHelper.Remove.LGbDowl0uq1w7i32Ij.4VQ.md#KeepCoding.UtilityHelper.Remove.T.(T...int).startIndex 'KeepCoding.UtilityHelper.Remove&lt;T&gt;(T[], int).startIndex').
```csharp
public static T[] Remove<T>(this T[] array, int startIndex);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Remove.T.(T...int).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Remove.T.(T...int).array'></a>
`array` [T](UtilityHelper.Remove.LGbDowl0uq1w7i32Ij.4VQ.md#KeepCoding.UtilityHelper.Remove.T.(T...int).T 'KeepCoding.UtilityHelper.Remove&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding.UtilityHelper.Remove.T.(T...int).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[T](UtilityHelper.Remove.LGbDowl0uq1w7i32Ij.4VQ.md#KeepCoding.UtilityHelper.Remove.T.(T...int).T 'KeepCoding.UtilityHelper.Remove&lt;T&gt;(T[], int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [startIndex](UtilityHelper.Remove.LGbDowl0uq1w7i32Ij.4VQ.md#KeepCoding.UtilityHelper.Remove.T.(T...int).startIndex 'KeepCoding.UtilityHelper.Remove&lt;T&gt;(T[], int).startIndex') is the length of the array.
