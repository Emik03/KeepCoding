#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.SumUnchecked&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,int&gt;) Method
Returns the sum of the values in the specified collection projected by the specified selector function,  
truncated to a 32-bit integer.
```csharp
public static int SumUnchecked<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,int> selector);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_SumUnchecked_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_SumUnchecked_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_SumUnchecked_ua4WWda6IWzNTXYX5sUEAw.md#KeepCoding_UtilityExtensions_SumUnchecked_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_)_T 'KeepCoding.UtilityExtensions.SumUnchecked&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_SumUnchecked_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_SumUnchecked_ua4WWda6IWzNTXYX5sUEAw.md#KeepCoding_UtilityExtensions_SumUnchecked_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_int_)_T 'KeepCoding.UtilityExtensions.SumUnchecked&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
