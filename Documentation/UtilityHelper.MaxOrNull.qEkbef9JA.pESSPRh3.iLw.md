#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MaxOrNull&lt;TSource&gt;(IEnumerable&lt;TSource&gt;) Method
Returns the maximum resulting value in a sequence, or `null` if the sequence is empty.
```csharp
public static System.Nullable<TSource> MaxOrNull<TSource>(this System.Collections.Generic.IEnumerable<TSource> source)
    where TSource : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.(System.Collections.Generic.IEnumerable.TSource.).TSource'></a>
`TSource`  
The type of the elements of [source](UtilityHelper.MaxOrNull.qEkbef9JA.pESSPRh3.iLw.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.(System.Collections.Generic.IEnumerable.TSource.).source 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MaxOrNull.TSource.(System.Collections.Generic.IEnumerable.TSource.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityHelper.MaxOrNull.qEkbef9JA.pESSPRh3.iLw.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.(System.Collections.Generic.IEnumerable.TSource.).TSource 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the maximum value of.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TSource](UtilityHelper.MaxOrNull.qEkbef9JA.pESSPRh3.iLw.md#KeepCoding.UtilityHelper.MaxOrNull.TSource.(System.Collections.Generic.IEnumerable.TSource.).TSource 'KeepCoding.UtilityHelper.MaxOrNull&lt;TSource&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum value in the sequence, or `null` if the sequence is empty.
