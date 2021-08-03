#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Insert&lt;T&gt;(T[], int, T[]) Method
Similar to [System.String.Insert(System.Int32,System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Insert#System_String_Insert_System_Int32,System_String_ 'System.String.Insert(System.Int32,System.String)'), but for arrays. Returns a new array with the [values](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).values 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).values') inserted starting from the specified [startIndex](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).startIndex 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).startIndex').
```csharp
public static T[] Insert<T>(this T[] array, int startIndex, params T[] values);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Insert.T.(T...int.T..).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Insert.T.(T...int.T..).array'></a>
`array` [T](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).T 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding.UtilityHelper.Insert.T.(T...int.T..).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding.UtilityHelper.Insert.T.(T...int.T..).values'></a>
`values` [T](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).T 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
#### Returns
[T](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).T 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [values](UtilityHelper.Insert.ZSLZgtMoa6orWxz2NdYWrQ.md#KeepCoding.UtilityHelper.Insert.T.(T...int.T..).values 'KeepCoding.UtilityHelper.Insert&lt;T&gt;(T[], int, T[]).values') is empty.
