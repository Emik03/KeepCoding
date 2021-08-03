#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IEqualityComparer&lt;TBy&gt;) Method
Creates and returns an equality comparer that compares the equality of objects by comparing the equality of  
the result of a selector function.
```csharp
public static KeepCoding.CustomEqualityComparer<T> By<TBy>(System.Func<T,TBy> selector, System.Collections.Generic.IEqualityComparer<TBy> comparer);
```
#### Type parameters
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Collections.Generic.IEqualityComparer.TBy.).TBy'></a>
`TBy`  
  
#### Parameters
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Collections.Generic.IEqualityComparer.TBy.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomEqualityComparer.T..By.BvAhc9LvZ8DD6tupa.e.1w.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Collections.Generic.IEqualityComparer.TBy.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Collections.Generic.IEqualityComparer.TBy.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TBy](CustomEqualityComparer.T..By.BvAhc9LvZ8DD6tupa.e.1w.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Collections.Generic.IEqualityComparer.TBy.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
Comparer to use for comparing the results of the selector function.
  
#### Returns
[KeepCoding.CustomEqualityComparer&lt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')  
