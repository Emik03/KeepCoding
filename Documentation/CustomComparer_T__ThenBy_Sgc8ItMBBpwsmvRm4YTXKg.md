#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[CustomComparer&lt;T&gt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')
## CustomComparer&lt;T&gt;.ThenBy(Func&lt;T,string&gt;, bool) Method
Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says  
the items are equal, further compares items by comparing the results of a string selector function.
```csharp
public KeepCoding.CustomComparer<T> ThenBy(System.Func<T,string> selector, bool ignoreCase);
```
#### Parameters
<a name='KeepCoding_CustomComparer_T__ThenBy(System_Func_T_string__bool)_selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CustomComparer_T_.md#KeepCoding_CustomComparer_T__T 'KeepCoding.CustomComparer&lt;T&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Function selecting the actual value to be compared.
  
<a name='KeepCoding_CustomComparer_T__ThenBy(System_Func_T_string__bool)_ignoreCase'></a>
`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If false, an invariant culture string comparison is used. Otherwise, an ordinal no-case comparison (suitable  
for filenames etc).
  
#### Returns
[KeepCoding.CustomComparer&lt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')[T](CustomComparer_T_.md#KeepCoding_CustomComparer_T__T 'KeepCoding.CustomComparer&lt;T&gt;.T')[&gt;](CustomComparer_T_.md 'KeepCoding.CustomComparer&lt;T&gt;')  
