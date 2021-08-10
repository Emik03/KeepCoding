#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomComparer&lt;T&gt;](CustomComparer.T..md 'KeepCoding.CustomComparer&lt;T&gt;')
## CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(Func&lt;T,TBy&gt;, IComparer&lt;TBy&gt;) Method
Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a selector function.  
```csharp
public KeepCoding.CustomComparer<T> ThenBy<TBy>(System.Func<T,TBy> selector, System.Collections.Generic.IComparer<TBy> comparer=null);
```
#### Type parameters
<a name='KeepCoding.CustomComparer.T..ThenBy.TBy.(System.Func.T.TBy..System.Collections.Generic.IComparer.TBy.).TBy'></a>
`TBy`  
  
#### Parameters
<a name='KeepCoding.CustomComparer.T..ThenBy.TBy.(System.Func.T.TBy..System.Collections.Generic.IComparer.TBy.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomComparer.T..md#KeepCoding.CustomComparer.T..T 'KeepCoding.CustomComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomComparer.T..ThenBy.4SG44rmDEfyH0PFg0CWdUA.md#KeepCoding.CustomComparer.T..ThenBy.TBy.(System.Func.T.TBy..System.Collections.Generic.IComparer.TBy.).TBy 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding.CustomComparer.T..ThenBy.TBy.(System.Func.T.TBy..System.Collections.Generic.IComparer.TBy.).comparer'></a>
`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[TBy](CustomComparer.T..ThenBy.4SG44rmDEfyH0PFg0CWdUA.md#KeepCoding.CustomComparer.T..ThenBy.TBy.(System.Func.T.TBy..System.Collections.Generic.IComparer.TBy.).TBy 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  
Comparer to use for comparing the results of the selector function. If null, the default comparer is used; this comparer will use the IComparable interface if implemented.
  
#### Returns
[KeepCoding.CustomComparer&lt;](CustomComparer.T..md 'KeepCoding.CustomComparer&lt;T&gt;')[T](CustomComparer.T..md#KeepCoding.CustomComparer.T..T 'KeepCoding.CustomComparer&lt;T&gt;.T')[&gt;](CustomComparer.T..md 'KeepCoding.CustomComparer&lt;T&gt;')  
