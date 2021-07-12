### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.IsIterator&lt;T&gt;(T) Method
Determines if the item is an iterator type.  
```csharp
public static bool IsIterator<T>(this T item);
```
#### Type parameters
<a name='KeepCoding_Helper_IsIterator_T_(T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_IsIterator_T_(T)_item'></a>
`item` [T](KeepCoding_Helper_IsIterator_T_(T).md#KeepCoding_Helper_IsIterator_T_(T)_T 'KeepCoding.Helper.IsIterator&lt;T&gt;(T).T')  
The item to check the type for.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[item](KeepCoding_Helper_IsIterator_T_(T).md#KeepCoding_Helper_IsIterator_T_(T)_item 'KeepCoding.Helper.IsIterator&lt;T&gt;(T).item') is either [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), or [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator').
