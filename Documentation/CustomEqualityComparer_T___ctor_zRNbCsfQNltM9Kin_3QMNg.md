#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer_T_.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(Func&lt;T,T,bool&gt;) Constructor
Constructor which re-uses the default hash function. Use this overload only if using the objects’ original  
hash function is appropriate for this equality comparison.
```csharp
public CustomEqualityComparer(System.Func<T,T,bool> comparison);
```
#### Parameters
<a name='KeepCoding_CustomEqualityComparer_T__CustomEqualityComparer(System_Func_T_T_bool_)_comparison'></a>
`comparison` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
Provides the comparison function for this equality comparer.
  
