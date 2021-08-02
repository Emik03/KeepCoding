#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomEqualityComparer&lt;T&gt;](CustomEqualityComparer_T_.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;')
## CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(Func&lt;T,T,bool&gt;, Func&lt;T,int&gt;) Constructor
Constructor.
```csharp
public CustomEqualityComparer(System.Func<T,T,bool> comparison, System.Func<T,int> getHashCode);
```
#### Parameters
<a name='KeepCoding_CustomEqualityComparer_T__CustomEqualityComparer(System_Func_T_T_bool__System_Func_T_int_)_comparison'></a>
`comparison` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
Provides the comparison function for this equality comparer.
  
<a name='KeepCoding_CustomEqualityComparer_T__CustomEqualityComparer(System_Func_T_T_bool__System_Func_T_int_)_getHashCode'></a>
`getHashCode` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Provides the hash function for this equality comparer.
  
