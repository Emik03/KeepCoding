#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FirstOrNull&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Returns the first element of a sequence, or `null` if the sequence contains no elements.
```csharp
public static System.Nullable<T> FirstOrNull<T>(this System.Collections.Generic.IEnumerable<T> source)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_T'></a>
`T`  
The type of the elements of [source](UtilityExtensions_FirstOrNull_dTEypeTjVWcwTqE_FDR0+w.md#KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source').
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_FirstOrNull_dTEypeTjVWcwTqE_FDR0+w.md#KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_T 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](UtilityExtensions_FirstOrNull_dTEypeTjVWcwTqE_FDR0+w.md#KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_T 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
`null` if [source](UtilityExtensions_FirstOrNull_dTEypeTjVWcwTqE_FDR0+w.md#KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source') is empty; otherwise, the first element in [source](UtilityExtensions_FirstOrNull_dTEypeTjVWcwTqE_FDR0+w.md#KeepCoding_UtilityExtensions_FirstOrNull_T_(System_Collections_Generic_IEnumerable_T_)_source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source').
