#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## CustomComparer&lt;T&gt; Class
Encapsulates an IComparer<T> that uses a comparison function provided as a delegate.
```csharp
public sealed class CustomComparer<T> :
System.Collections.Generic.IComparer<T>
```
#### Type parameters
<a name='KeepCoding_CustomComparer_T__T'></a>
`T`  
The type of elements to be compared.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomComparer&lt;T&gt;  

Implements [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](CustomComparer_T_.md#KeepCoding_CustomComparer_T__T 'KeepCoding.CustomComparer&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  

| Constructors | |
| :--- | :--- |
| [CustomComparer(Comparison&lt;T&gt;)](CustomComparer_T___ctor_tfJDCL2CExUuJsWn7O5fZA.md 'KeepCoding.CustomComparer&lt;T&gt;.CustomComparer(System.Comparison&lt;T&gt;)') | Constructor. |

| Methods | |
| :--- | :--- |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IComparer&lt;TBy&gt;)](CustomComparer_T__By_vo815v6HVi6fBWoE7Z2YxA.md 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function. |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Comparison&lt;TBy&gt;)](CustomComparer_T__By_iYGSrtC0eXv+W3ldR5Ffjw.md 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function. |
| [By(Func&lt;T,string&gt;, bool)](CustomComparer_T__By_N3wBTE1ZIAtlvL8j+8nSRg.md 'KeepCoding.CustomComparer&lt;T&gt;.By(System.Func&lt;T,string&gt;, bool)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function. |
| [Compare(T, T)](CustomComparer_T__Compare_hnpSWAOW63_3vto60fPwWw.md 'KeepCoding.CustomComparer&lt;T&gt;.Compare(T, T)') | Compares two elements. |
| [ThenBy&lt;TBy&gt;(Func&lt;T,TBy&gt;, IComparer&lt;TBy&gt;)](CustomComparer_T__ThenBy_4SG44rmDEfyH0PFg0CWdUA.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says<br/>the items are equal, further compares items by comparing the results of a selector function. |
| [ThenBy&lt;TBy&gt;(Func&lt;T,TBy&gt;, Comparison&lt;TBy&gt;)](CustomComparer_T__ThenBy_G5tT5jPkuLcuJxKSQik9cA.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says<br/>the items are equal, further compares items by comparing the results of a selector function. |
| [ThenBy(Func&lt;T,string&gt;, bool)](CustomComparer_T__ThenBy_Sgc8ItMBBpwsmvRm4YTXKg.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy(System.Func&lt;T,string&gt;, bool)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says<br/>the items are equal, further compares items by comparing the results of a string selector function. |
