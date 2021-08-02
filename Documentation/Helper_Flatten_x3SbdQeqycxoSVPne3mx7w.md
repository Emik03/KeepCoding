#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Flatten(IEnumerator, Predicate&lt;object&gt;) Method
Flattens an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') such that nested [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') calls get replaced with the output of those calls.  
```csharp
public static System.Collections.IEnumerator Flatten(this System.Collections.IEnumerator source, System.Predicate<object> except=null);
```
#### Parameters
<a name='KeepCoding_Helper_Flatten(System_Collections_IEnumerator_System_Predicate_object_)_source'></a>
`source` [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
The [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to flatten.
  
<a name='KeepCoding_Helper_Flatten(System_Collections_IEnumerator_System_Predicate_object_)_except'></a>
`except` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
Determines if it should call [Flatten(IEnumerator, Predicate&lt;object&gt;)](Helper_Flatten_x3SbdQeqycxoSVPne3mx7w.md 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;object&gt;)') for the item.
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[source](Helper_Flatten_x3SbdQeqycxoSVPne3mx7w.md#KeepCoding_Helper_Flatten(System_Collections_IEnumerator_System_Predicate_object_)_source 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;object&gt;).source') where [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')s gets replaced with the output of those calls.
