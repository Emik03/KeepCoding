### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
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
`item` [T](KeepCoding_Helper_GetNullException_T_(T).md#KeepCoding_Helper_GetNullException_T_(T)_T 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).T')  
The item to check the type for.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException') if [item](KeepCoding_Helper_GetNullException_T_(T).md#KeepCoding_Helper_GetNullException_T_(T)_item 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).item') is an iterator, evaluated with [IsIterator&lt;T&gt;(T)](KeepCoding_Helper_IsIterator_T_(T).md 'KeepCoding.Helper.IsIterator&lt;T&gt;(T)'), otherwise [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')
