#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomComparer&lt;T&gt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')
## CustomComparer&lt;T&gt;.By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Comparison&lt;TBy&gt;) Method
Creates and returns a CustomComparer which compares items by comparing the results of a selector function.
```csharp
public static KeepCoding.CustomComparer<T> By<TBy>(System.Func<T,TBy> selector, System.Comparison<TBy> comparison);
```
#### Type parameters
<a name='KeepCoding_CustomComparer_T__By_TBy_(System_Func_T_TBy__System_Comparison_TBy_)_TBy'></a>
`TBy`  
  
#### Parameters
<a name='KeepCoding_CustomComparer_T__By_TBy_(System_Func_T_TBy__System_Comparison_TBy_)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomComparer_T_.md#KeepCoding_CustomComparer_T__T 'KeepCoding.CustomComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomComparer_T__By_iYGSrtC0eXv+W3ldR5Ffjw.md#KeepCoding_CustomComparer_T__By_TBy_(System_Func_T_TBy__System_Comparison_TBy_)_TBy 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding_CustomComparer_T__By_TBy_(System_Func_T_TBy__System_Comparison_TBy_)_comparison'></a>
`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[TBy](CustomComparer_T__By_iYGSrtC0eXv+W3ldR5Ffjw.md#KeepCoding_CustomComparer_T__By_TBy_(System_Func_T_TBy__System_Comparison_TBy_)_TBy 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')  
Comparison to use for comparing the results of the selector function.
  
#### Returns
[KeepCoding.CustomComparer&lt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')[T](CustomComparer_T_.md#KeepCoding_CustomComparer_T__T 'KeepCoding.CustomComparer&lt;T&gt;.T')[&gt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')  
