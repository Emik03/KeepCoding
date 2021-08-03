#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]) Method
Similar to [System.String.Insert(System.Int32,System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.String.Insert#System_String_Insert_System_Int32,System_String_ 'System.String.Insert(System.Int32,System.String)'), but for arrays. Returns a new array with the [values](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).values 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).values') inserted starting from the specified [startIndex](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).startIndex 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).startIndex').
```csharp
public static T[] Insert<T>(this T[] array, int startIndex, params T[] values);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).array'></a>
`array` [T](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).T 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
<a name='KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).values'></a>
`values` [T](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).T 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
#### Returns
[T](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).T 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
### Remarks
Returns a new copy of the array even if [values](UtilityExtensions.Insert.NnlWr6Kb91eKD2vbl2liFQ.md#KeepCoding.UtilityExtensions.Insert.T.(T...int.T..).values 'KeepCoding.UtilityExtensions.Insert&lt;T&gt;(T[], int, T[]).values') is empty.
