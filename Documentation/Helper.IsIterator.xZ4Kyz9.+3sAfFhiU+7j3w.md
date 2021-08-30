#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsIterator&lt;T&gt;(T) Method
Determines if the item is an iterator type.  
```csharp
public static bool IsIterator<T>(this T item);
```
#### Type parameters
<a name='KeepCoding.Helper.IsIterator.T.(T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.IsIterator.T.(T).item'></a>
`item` [T](Helper.IsIterator.xZ4Kyz9.+3sAfFhiU+7j3w.md#KeepCoding.Helper.IsIterator.T.(T).T 'KeepCoding.Helper.IsIterator&lt;T&gt;(T).T')  
The item to check the type for.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[item](Helper.IsIterator.xZ4Kyz9.+3sAfFhiU+7j3w.md#KeepCoding.Helper.IsIterator.T.(T).item 'KeepCoding.Helper.IsIterator&lt;T&gt;(T).item') is either [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), or [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator').
