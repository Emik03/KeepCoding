#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.SubarrayEquals&lt;T&gt;(T[], int, T[], IEqualityComparer&lt;T&gt;) Method
Determines whether a subarray within the current array is equal to the specified other array.
```csharp
public static bool SubarrayEquals<T>(this T[] sourceArray, int sourceStartIndex, T[] otherArray, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).sourceArray'></a>
`sourceArray` [T](UtilityHelper.SubarrayEquals.HEFBBsOzPgdh0fzoJGhIag.md#KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.SubarrayEquals&lt;T&gt;(T[], int, T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
First array to examine.
  
<a name='KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).sourceStartIndex'></a>
`sourceStartIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Start index of the subarray within the first array to compare.
  
<a name='KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).otherArray'></a>
`otherArray` [T](UtilityHelper.SubarrayEquals.HEFBBsOzPgdh0fzoJGhIag.md#KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.SubarrayEquals&lt;T&gt;(T[], int, T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array to compare the subarray against.
  
<a name='KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityHelper.SubarrayEquals.HEFBBsOzPgdh0fzoJGhIag.md#KeepCoding.UtilityHelper.SubarrayEquals.T.(T...int.T...System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityHelper.SubarrayEquals&lt;T&gt;(T[], int, T[], System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the current array contains the specified subarray at the specified index; false otherwise.
