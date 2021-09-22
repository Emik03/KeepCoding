#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Assert&lt;T,TOther&gt;(T, TOther) Method
Throws an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException') if both arguments passed in [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') on [System.Object.Equals(System.Object)](https://docs.microsoft.com/en-us/dotnet/api/System.Object.Equals#System_Object_Equals_System_Object_ 'System.Object.Equals(System.Object)').  
```csharp
public static T Assert<T,TOther>(this T item, TOther comparison);
```
#### Type parameters
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther).T'></a>
`T`  
The type of the initial comparison.
  
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther).TOther'></a>
`TOther`  
The type of the item to compare.
  
#### Parameters
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther).item'></a>
`item` [T](Helper.Assert.6Yimuc+TEgMMtWvGr6OFNg.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther).T 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther).T')  
The item to use as comparison.
  
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther).comparison'></a>
`comparison` [TOther](Helper.Assert.6Yimuc+TEgMMtWvGr6OFNg.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther).TOther 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther).TOther')  
The item to compare to.
  
#### Returns
[T](Helper.Assert.6Yimuc+TEgMMtWvGr6OFNg.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther).T 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther).T')  
[item](Helper.Assert.6Yimuc+TEgMMtWvGr6OFNg.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther).item 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther).item')
