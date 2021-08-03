#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.LastValue&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Returns the last element which doesn't [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') if all of them [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static T LastValue<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters
<a name='KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T.).T'></a>
`T`  
The type of array, and method.
  
#### Parameters
<a name='KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.LastValue.QNGsLCf7+ObnxhjTtAuNcw.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array to iterate on.
  
#### Returns
[T](Helper.LastValue.QNGsLCf7+ObnxhjTtAuNcw.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')  
The last value from [source](Helper.LastValue.QNGsLCf7+ObnxhjTtAuNcw.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T.).source 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source') where it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
