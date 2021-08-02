#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer_T_.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IEqualityComparer&lt;TBy&gt;) Method
Creates and returns an equality comparer that compares the equality of objects by comparing the equality of  
the result of a selector function.
```csharp
public static KeepCoding.CustomEqualityComparer<T> By<TBy>(System.Func<T,TBy> selector, System.Collections.Generic.IEqualityComparer<TBy> comparer);
```
#### Type parameters
<a name='KeepCoding_CustomEqualityComparer_T__By_TBy_(System_Func_T_TBy__System_Collections_Generic_IEqualityComparer_TBy_)_TBy'></a>
`TBy`  
  
#### Parameters
<a name='KeepCoding_CustomEqualityComparer_T__By_TBy_(System_Func_T_TBy__System_Collections_Generic_IEqualityComparer_TBy_)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomEqualityComparer_T__By_BvAhc9LvZ8DD6tupa_e_1w.md#KeepCoding_CustomEqualityComparer_T__By_TBy_(System_Func_T_TBy__System_Collections_Generic_IEqualityComparer_TBy_)_TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding_CustomEqualityComparer_T__By_TBy_(System_Func_T_TBy__System_Collections_Generic_IEqualityComparer_TBy_)_comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TBy](CustomEqualityComparer_T__By_BvAhc9LvZ8DD6tupa_e_1w.md#KeepCoding_CustomEqualityComparer_T__By_TBy_(System_Func_T_TBy__System_Collections_Generic_IEqualityComparer_TBy_)_TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Comparer to use for comparing the results of the selector function.
  
#### Returns
[KeepCoding.CustomEqualityComparer&lt;](CustomEqualityComparer_T_.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](CustomEqualityComparer_T_.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')  
