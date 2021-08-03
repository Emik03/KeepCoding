#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.LastValue&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,T&gt;) Method
Returns the last element which doesn't [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') if all of them [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')return [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static T LastValue<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,T> func);
```
#### Type parameters
<a name='KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).T'></a>
`T`  
The type of array, and method.
  
#### Parameters
<a name='KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array to iterate on.
  
<a name='KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The method which returns something or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Returns
[T](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')  
The last value from [source](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).source 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).source') where [func](Helper.LastValue.uKYEpykOwbxibb0SHKevXg.md#KeepCoding.Helper.LastValue.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.T.).func 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).func') doesn't [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
