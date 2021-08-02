#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(IEnumerable&lt;TSource&gt;, Func&lt;TSource,TResult&gt;) Method
Invokes a selector on each element of a collection and returns the minimum resulting value, or `null` if  
the sequence is empty.
```csharp
public static System.Nullable<TResult> MinOrNull<TSource,TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector)
    where TResult : struct;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TSource'></a>
`TSource`  
The type of the elements of [source](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_source 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).source').
  
<a name='KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TResult'></a>
`TResult`  
The type of the value returned by [selector](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_selector 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).selector').
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TSource](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TSource 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of values to determine the minimum value of.
  
<a name='KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TSource 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TResult 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A transform function to apply to each element.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TResult](UtilityExtensions_MinOrNull_KUZMYHCtIAE37_7OGr7pEg.md#KeepCoding_UtilityExtensions_MinOrNull_TSource_TResult_(System_Collections_Generic_IEnumerable_TSource__System_Func_TSource_TResult_)_TResult 'KeepCoding.UtilityExtensions.MinOrNull&lt;TSource,TResult&gt;(System.Collections.Generic.IEnumerable&lt;TSource&gt;, System.Func&lt;TSource,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum value in the sequence, or `null` if the sequence is empty.
