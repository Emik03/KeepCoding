#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(IEnumerable&lt;T&gt;, bool, Func&lt;T,T,TResult&gt;) Method
Enumerates all consecutive pairs of the elements.
```csharp
public static System.Collections.Generic.IEnumerable<TResult> SelectConsecutivePairs<T,TResult>(this System.Collections.Generic.IEnumerable<T> source, bool closed, System.Func<T,T,TResult> selector);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_T'></a>
`T`  
  
<a name='KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_T 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input enumerable.
  
<a name='KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_closed'></a>
`closed` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If true, an additional pair containing the last and first element is included. For example, if the source  
collection contains { 1, 2, 3, 4 } then the enumeration contains { (1, 2), (2, 3), (3, 4) } if [closed](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_closed 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).closed') is `false`, and { (1, 2), (2, 3), (3, 4), (4, 1) } if [closed](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_closed 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).closed') is  
`true`.
  
<a name='KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_T 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_T 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_TResult 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The selector function to run each consecutive pair through.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TResult](UtilityExtensions_SelectConsecutivePairs_LBYEhGX8pPN2+ytfLS6VPQ.md#KeepCoding_UtilityExtensions_SelectConsecutivePairs_T_TResult_(System_Collections_Generic_IEnumerable_T__bool_System_Func_T_T_TResult_)_TResult 'KeepCoding.UtilityExtensions.SelectConsecutivePairs&lt;T,TResult&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, bool, System.Func&lt;T,T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
