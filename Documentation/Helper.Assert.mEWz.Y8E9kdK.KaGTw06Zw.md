#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Assert&lt;T&gt;(T, Predicate&lt;T&gt;) Method
Throws an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException') if the method passed in [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')s [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static T Assert<T>(this T item, System.Predicate<T> assertion);
```
#### Type parameters
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).T'></a>
`T`  
The type of the initial comparison.
  
#### Parameters
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).item'></a>
`item` [T](Helper.Assert.mEWz.Y8E9kdK.KaGTw06Zw.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;).T')  
The item to pass into the method.
  
<a name='KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).assertion'></a>
`assertion` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](Helper.Assert.mEWz.Y8E9kdK.KaGTw06Zw.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The assertion, [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') indicates success and will [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[item](Helper.Assert.mEWz.Y8E9kdK.KaGTw06Zw.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).item 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;).item'), [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') will throw an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException').
  
#### Returns
[T](Helper.Assert.mEWz.Y8E9kdK.KaGTw06Zw.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).T 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;).T')  
[item](Helper.Assert.mEWz.Y8E9kdK.KaGTw06Zw.md#KeepCoding.Helper.Assert.T.(T.System.Predicate.T.).item 'KeepCoding.Helper.Assert&lt;T&gt;(T, System.Predicate&lt;T&gt;).item')
