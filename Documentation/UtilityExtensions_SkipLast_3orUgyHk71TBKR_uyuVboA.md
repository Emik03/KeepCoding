#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SkipLast&lt;T&gt;(IEnumerable&lt;T&gt;, int, bool) Method
Enumerates the items of this collection, skipping the last [count](UtilityExtensions_SkipLast_3orUgyHk71TBKR_uyuVboA.md#KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_count 'KeepCoding.UtilityExtensions.SkipLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, bool).count') items. Note that the  
memory usage of this method is proportional to [count](UtilityExtensions_SkipLast_3orUgyHk71TBKR_uyuVboA.md#KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_count 'KeepCoding.UtilityExtensions.SkipLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, bool).count'), but the source collection is only  
enumerated once, and in a lazy fashion. Also, enumerating the first item will take longer than enumerating  
subsequent items.
```csharp
public static System.Collections.Generic.IEnumerable<T> SkipLast<T>(this System.Collections.Generic.IEnumerable<T> source, int count, bool throwIfNotEnough=false);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SkipLast_3orUgyHk71TBKR_uyuVboA.md#KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_T 'KeepCoding.UtilityExtensions.SkipLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Source collection.
  
<a name='KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Number of items to skip from the end of the collection.
  
<a name='KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_throwIfNotEnough'></a>
`throwIfNotEnough` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If `true`, the enumerator throws at the end of the enumeration if the source collection contained fewer  
than [count](UtilityExtensions_SkipLast_3orUgyHk71TBKR_uyuVboA.md#KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_count 'KeepCoding.UtilityExtensions.SkipLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, bool).count') elements.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SkipLast_3orUgyHk71TBKR_uyuVboA.md#KeepCoding_UtilityExtensions_SkipLast_T_(System_Collections_Generic_IEnumerable_T__int_bool)_T 'KeepCoding.UtilityExtensions.SkipLast&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
