#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsAll&lt;T&gt;(T, T[]) Method
Determines whether [item](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).item 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).item') is equal to all items in [comparisons](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).comparisons 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).comparisons').  
```csharp
public static bool IsAll<T>(this T item, params T[] comparisons);
```
#### Type parameters
<a name='KeepCoding.Helper.IsAll.T.(T.T..).T'></a>
`T`  
The type of both parameters, and the type to use equality for.
  
#### Parameters
<a name='KeepCoding.Helper.IsAll.T.(T.T..).item'></a>
`item` [T](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).T 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).T')  
The type of the initial item to compare.
  
<a name='KeepCoding.Helper.IsAll.T.(T.T..).comparisons'></a>
`comparisons` [T](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).T 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of items to compare to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if all items in [comparisons](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).comparisons 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).comparisons') is equal to [item](Helper.IsAll.XUVwh6StwasqknXI3aTokA.md#KeepCoding.Helper.IsAll.T.(T.T..).item 'KeepCoding.Helper.IsAll&lt;T&gt;(T, T[]).item').
