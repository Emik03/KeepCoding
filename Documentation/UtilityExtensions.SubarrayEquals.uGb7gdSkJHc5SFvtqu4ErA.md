#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SubarrayEquals&lt;T&gt;(T[], int, T[], int, int, IEqualityComparer&lt;T&gt;) Method
Determines whether the two arrays contain the same content in the specified location.
```csharp
public static bool SubarrayEquals<T>(this T[] sourceArray, int sourceStartIndex, T[] otherArray, int otherStartIndex, int length, System.Collections.Generic.IEqualityComparer<T> comparer=null);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).sourceArray'></a>
`sourceArray` [T](UtilityExtensions.SubarrayEquals.uGb7gdSkJHc5SFvtqu4ErA.md#KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.SubarrayEquals&lt;T&gt;(T[], int, T[], int, int, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
First array to examine.
  
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).sourceStartIndex'></a>
`sourceStartIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Start index of the subarray within the first array to compare.
  
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).otherArray'></a>
`otherArray` [T](UtilityExtensions.SubarrayEquals.uGb7gdSkJHc5SFvtqu4ErA.md#KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.SubarrayEquals&lt;T&gt;(T[], int, T[], int, int, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Second array to examine.
  
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).otherStartIndex'></a>
`otherStartIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Start index of the subarray within the second array to compare.
  
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Length of the subarrays to compare.
  
<a name='KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](UtilityExtensions.SubarrayEquals.uGb7gdSkJHc5SFvtqu4ErA.md#KeepCoding.UtilityExtensions.SubarrayEquals.T.(T...int.T...int.int.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.UtilityExtensions.SubarrayEquals&lt;T&gt;(T[], int, T[], int, int, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Optional equality comparer.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the two arrays contain the same subarrays at the specified indexes; false otherwise.
