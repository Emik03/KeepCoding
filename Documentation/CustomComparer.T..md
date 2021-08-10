#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## CustomComparer&lt;T&gt; Class
Encapsulates an [System.Collections.Generic.IComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1') that uses a comparison function provided as a delegate.  
```csharp
public sealed class CustomComparer<T> :
System.Collections.Generic.IComparer<T>
```
#### Type parameters
<a name='KeepCoding.CustomComparer.T..T'></a>
`T`  
The type of elements to be compared.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomComparer&lt;T&gt;  

Implements [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](CustomComparer.T..md#KeepCoding.CustomComparer.T..T 'KeepCoding.CustomComparer&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')  

| Constructors | |
| :--- | :--- |
| [CustomComparer(Comparison&lt;T&gt;)](CustomComparer.T...ctor.tfJDCL2CExUuJsWn7O5fZA.md 'KeepCoding.CustomComparer&lt;T&gt;.CustomComparer(System.Comparison&lt;T&gt;)') | Constructor.<br/> |

| Methods | |
| :--- | :--- |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IComparer&lt;TBy&gt;)](CustomComparer.T..By.vo815v6HVi6fBWoE7Z2YxA.md 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function.<br/> |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Comparison&lt;TBy&gt;)](CustomComparer.T..By.iYGSrtC0eXv+W3ldR5Ffjw.md 'KeepCoding.CustomComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function.<br/> |
| [By(Func&lt;T,string&gt;, bool)](CustomComparer.T..By.N3wBTE1ZIAtlvL8j+8nSRg.md 'KeepCoding.CustomComparer&lt;T&gt;.By(System.Func&lt;T,string&gt;, bool)') | Creates and returns a CustomComparer which compares items by comparing the results of a selector function.<br/> |
| [Compare(T, T)](CustomComparer.T..Compare.hnpSWAOW63.3vto60fPwWw.md 'KeepCoding.CustomComparer&lt;T&gt;.Compare(T, T)') | Compares two elements.<br/> |
| [ThenBy&lt;TBy&gt;(Func&lt;T,TBy&gt;, IComparer&lt;TBy&gt;)](CustomComparer.T..ThenBy.4SG44rmDEfyH0PFg0CWdUA.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IComparer&lt;TBy&gt;)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a selector function.<br/> |
| [ThenBy&lt;TBy&gt;(Func&lt;T,TBy&gt;, Comparison&lt;TBy&gt;)](CustomComparer.T..ThenBy.G5tT5jPkuLcuJxKSQik9cA.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Comparison&lt;TBy&gt;)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a selector function.<br/> |
| [ThenBy(Func&lt;T,string&gt;, bool)](CustomComparer.T..ThenBy.Sgc8ItMBBpwsmvRm4YTXKg.md 'KeepCoding.CustomComparer&lt;T&gt;.ThenBy(System.Func&lt;T,string&gt;, bool)') | Creates and returns a CustomComparer which uses the current comparer first, and if the current comparer says the items are equal, further compares items by comparing the results of a string selector function.<br/> |
