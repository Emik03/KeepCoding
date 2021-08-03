#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.GetNullException&lt;T&gt;(T) Method
Gets the appropriate [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') based on the data type.  
```csharp
public static System.Func<string,System.Exception> GetNullException<T>(this T item);
```
#### Type parameters
<a name='KeepCoding.Helper.GetNullException.T.(T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.GetNullException.T.(T).item'></a>
`item` [T](Helper.GetNullException.IWqZ8FQZETT5eK5hGEfebA.md#KeepCoding.Helper.GetNullException.T.(T).T 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).T')  
The item to check the type for.
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException') if [item](Helper.GetNullException.IWqZ8FQZETT5eK5hGEfebA.md#KeepCoding.Helper.GetNullException.T.(T).item 'KeepCoding.Helper.GetNullException&lt;T&gt;(T).item') is an iterator, evaluated with [IsIterator&lt;T&gt;(T)](Helper.IsIterator.xZ4Kyz9.+3sAfFhiU+7j3w.md 'KeepCoding.Helper.IsIterator&lt;T&gt;(T)'), otherwise [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')
