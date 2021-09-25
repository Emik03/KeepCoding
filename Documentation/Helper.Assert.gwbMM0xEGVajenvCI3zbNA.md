#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Assert&lt;T,TOther&gt;(T, TOther, string) Method
Throws an [AssertionException](AssertionException.md 'KeepCoding.Internal.AssertionException') if both arguments passed in [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') on [System.Object.Equals(System.Object)](https://docs.microsoft.com/en-us/dotnet/api/System.Object.Equals#System_Object_Equals_System_Object_ 'System.Object.Equals(System.Object)').  
```csharp
public static T Assert<T,TOther>(this T item, TOther comparison, string name=null);
```
#### Type parameters
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).T'></a>
`T`  
The type of the initial comparison.
  
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).TOther'></a>
`TOther`  
The type of the item to compare.
  
#### Parameters
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).item'></a>
`item` [T](Helper.Assert.gwbMM0xEGVajenvCI3zbNA.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).T 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther, string).T')  
The item to use as comparison.
  
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).comparison'></a>
`comparison` [TOther](Helper.Assert.gwbMM0xEGVajenvCI3zbNA.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).TOther 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther, string).TOther')  
The item to compare to.
  
<a name='KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of [item](Helper.Assert.gwbMM0xEGVajenvCI3zbNA.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).item 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther, string).item').
  
#### Returns
[T](Helper.Assert.gwbMM0xEGVajenvCI3zbNA.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).T 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther, string).T')  
[item](Helper.Assert.gwbMM0xEGVajenvCI3zbNA.md#KeepCoding.Helper.Assert.T.TOther.(T.TOther.string).item 'KeepCoding.Helper.Assert&lt;T,TOther&gt;(T, TOther, string).item')
