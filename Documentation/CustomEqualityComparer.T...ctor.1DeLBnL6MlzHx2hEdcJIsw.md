#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer.T..md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(Func&lt;T,T,bool&gt;, Func&lt;T,int&gt;) Constructor
Constructor.
```csharp
public CustomEqualityComparer(System.Func<T,T,bool> comparison, System.Func<T,int> getHashCode);
```
#### Parameters
<a name='KeepCoding.CustomEqualityComparer.T..CustomEqualityComparer(System.Func.T.T.bool..System.Func.T.int.).comparison'></a>
`comparison` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
Provides the comparison function for this equality comparer.
  
<a name='KeepCoding.CustomEqualityComparer.T..CustomEqualityComparer(System.Func.T.T.bool..System.Func.T.int.).getHashCode'></a>
`getHashCode` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Provides the hash function for this equality comparer.
  
