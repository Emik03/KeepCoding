#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Flatten(IEnumerator, Predicate&lt;IEnumerator&gt;) Method
Flattens an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') such that nested [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') calls get replaced with the output of those calls.  
```csharp
public static System.Collections.IEnumerator Flatten(this System.Collections.IEnumerator source, System.Predicate<System.Collections.IEnumerator> except=null);
```
#### Parameters
<a name='KeepCoding.Helper.Flatten(System.Collections.IEnumerator.System.Predicate.System.Collections.IEnumerator.).source'></a>
`source` [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
The [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to flatten.
  
<a name='KeepCoding.Helper.Flatten(System.Collections.IEnumerator.System.Predicate.System.Collections.IEnumerator.).except'></a>
`except` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
If [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), [Flatten(IEnumerator, Predicate&lt;IEnumerator&gt;)](Helper.Flatten.1fU+zZAhpugERKJvQxZvsQ.md 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;System.Collections.IEnumerator&gt;)') gets called recursively and each item from that output gets returned individually, otherwise the item is simply returned.
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[source](Helper.Flatten.1fU+zZAhpugERKJvQxZvsQ.md#KeepCoding.Helper.Flatten(System.Collections.IEnumerator.System.Predicate.System.Collections.IEnumerator.).source 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;System.Collections.IEnumerator&gt;).source') where [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')s gets replaced with the output of those calls.
