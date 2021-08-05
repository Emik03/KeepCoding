#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsAny&lt;T&gt;(T, T[]) Method
Determines whether [item](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).item 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).item') is equal to any items in [comparisons](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).comparisons 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).comparisons').  
```csharp
public static bool IsAny<T>(this T item, params T[] comparisons);
```
#### Type parameters
<a name='KeepCoding.Helper.IsAny.T.(T.T..).T'></a>
`T`  
The type of both parameters, and the type to use equality for.
  
#### Parameters
<a name='KeepCoding.Helper.IsAny.T.(T.T..).item'></a>
`item` [T](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).T 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).T')  
The type of the initial item to compare.
  
<a name='KeepCoding.Helper.IsAny.T.(T.T..).comparisons'></a>
`comparisons` [T](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).T 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of items to compare to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if any of the items in [comparisons](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).comparisons 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).comparisons') is equal to [item](Helper.IsAny.WCsrT6Y+yitTTu9AEZWEjw.md#KeepCoding.Helper.IsAny.T.(T.T..).item 'KeepCoding.Helper.IsAny&lt;T&gt;(T, T[]).item').
