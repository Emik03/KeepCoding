#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Func&lt;TBy,TBy,bool&gt;, Func&lt;TBy,int&gt;) Method
Creates and returns an equality comparer that compares the equality of objects by comparing the equality of  
the result of a selector function.
```csharp
public static KeepCoding.CustomEqualityComparer<T> By<TBy>(System.Func<T,TBy> selector, System.Func<TBy,TBy,bool> comparison=null, System.Func<TBy,int> getHashCode=null);
```
#### Type parameters
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).TBy'></a>
`TBy`  
  
#### Parameters
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomEqualityComparer.T..By.NaY.MTgBmizkuXKs0A0duQ.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;).TBy')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).comparison'></a>
`comparison` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TBy](CustomEqualityComparer.T..By.NaY.MTgBmizkuXKs0A0duQ.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;).TBy')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TBy](CustomEqualityComparer.T..By.NaY.MTgBmizkuXKs0A0duQ.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;).TBy')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
Function used to compare values for equality. If null, will use IEquatable if implemented, or the object's  
Equals override.
  
<a name='KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).getHashCode'></a>
`getHashCode` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TBy](CustomEqualityComparer.T..By.NaY.MTgBmizkuXKs0A0duQ.md#KeepCoding.CustomEqualityComparer.T..By.TBy.(System.Func.T.TBy..System.Func.TBy.TBy.bool..System.Func.TBy.int.).TBy 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;).TBy')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function used to compute hash codes. If null, will use IEquatable if implemented, or the object's GetHashCode  
override.
  
#### Returns
[KeepCoding.CustomEqualityComparer&lt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')  
