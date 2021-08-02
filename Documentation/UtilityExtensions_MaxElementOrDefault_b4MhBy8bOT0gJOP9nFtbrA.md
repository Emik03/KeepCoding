#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;, T) Method
Returns the first element from the input sequence for which the value selector returns the largest value, or a  
default value if the collection is empty.
```csharp
public static T MaxElementOrDefault<T,TValue>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,TValue> valueSelector, T defaultValue=default(T))
    where TValue : System.IComparable<TValue>;
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_T'></a>
`T`  
  
<a name='KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_MaxElementOrDefault_b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_valueSelector'></a>
`valueSelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions_MaxElementOrDefault_b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](UtilityExtensions_MaxElementOrDefault_b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_TValue 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_defaultValue'></a>
`defaultValue` [T](UtilityExtensions_MaxElementOrDefault_b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')  
  
#### Returns
[T](UtilityExtensions_MaxElementOrDefault_b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding_UtilityExtensions_MaxElementOrDefault_T_TValue_(System_Collections_Generic_IEnumerable_T__System_Func_T_TValue__T)_T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')  
