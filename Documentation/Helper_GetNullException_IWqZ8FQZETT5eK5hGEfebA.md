#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.GetNullException&lt;T&gt;(T) Method
Gets the appropriate [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') based on the data type.  
```csharp
public static System.Func<string,System.Exception> GetNullException<T>(this T item);
```
#### Type parameters
<a name='KeepCoding_Helper_GetNullException_T_(T)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_GetNullException_T_(T)_item'></a>
`item` [T](Helper_GetNullException_IWqZ8FQZETT5eK5hGEfebA.md#KeepCoding_Helper_GetNullException_T_(T)_T 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).T')  
The item to check the type for.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException') if [item](Helper_GetNullException_IWqZ8FQZETT5eK5hGEfebA.md#KeepCoding_Helper_GetNullException_T_(T)_item 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).item') is an iterator, evaluated with [IsIterator&lt;T&gt;(T)](Helper_IsIterator_xZ4Kyz9_+3sAfFhiU+7j3w.md 'KeepCoding.Helper.IsIterator&lt;T&gt;(T)'), otherwise [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')
