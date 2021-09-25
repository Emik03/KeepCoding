#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Assert&lt;T&gt;(T, Predicate&lt;T&gt;, string, string) Method
Throws an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException') if the method passed in [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')s [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static T Assert<T>(this T item, System.Predicate<T> assertion, string name=null, string expect="assertion predicate to return true");
```
#### Type parameters
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).T'></a>
`T`  
The type of the initial comparison.
  
#### Parameters
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).item'></a>
`item` [T](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).T')  
The item to pass into the method.
  
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).assertion'></a>
`assertion` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The assertion, [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') indicates success and will [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[item](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).item 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).item'), [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') will throw an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException').
  
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of [item](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).item 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).item').
  
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).expect'></a>
`expect` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of what [assertion](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).assertion 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).assertion') does and expects.
  
#### Returns
[T](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).T')  
[item](Helper.Assert.oxzJ.v6OUzNnqGjLb23yIA.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T..string.string).item 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;, string, string).item')
