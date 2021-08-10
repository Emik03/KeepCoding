#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.By(Func&lt;T,string&gt;, bool) Method
Creates and returns an equality comparer that compares the equality of objects by comparing the equality of  
the result of a string selector function.  
```csharp
public static KeepCoding.CustomEqualityComparer<T> By(System.Func<T,string> selector, bool ignoreCase);
```
#### Parameters
<a name='KeepCoding.CustomEqualityComparer.T..By(System.Func.T.string..bool).selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual string value to be compared.
  
<a name='KeepCoding.CustomEqualityComparer.T..By(System.Func.T.string..bool).ignoreCase'></a>
`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If false, an invariant culture string comparison is used. Otherwise, an ordinal no-case comparison (suitable for filenames etc).
  
#### Returns
[KeepCoding.CustomEqualityComparer&lt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')  
