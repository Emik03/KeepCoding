#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Logger](Logger.md 'KeepCoding.Logger')
## Logger.Dump&lt;T&gt;(T, bool) Method
Dumps all information that it can find of the type using reflection. This should only be used to debug.  
```csharp
public void Dump<T>(T obj, bool getVariables=false);
```
#### Type parameters
<a name='KeepCoding.Logger.Dump.T.(T.bool).T'></a>
`T`  
The type of component to reflect on.
  
#### Parameters
<a name='KeepCoding.Logger.Dump.T.(T.bool).obj'></a>
`obj` [T](Logger.Dump.sOqEkA.6mI90Sls4.uLMZg.md#KeepCoding.Logger.Dump.T.(T.bool).T 'KeepCoding.Logger.Dump&lt;T&gt;(T, bool).T')  
The object to reflect on.
  
<a name='KeepCoding.Logger.Dump.T.(T.bool).getVariables'></a>
`getVariables` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search recursively for the elements within the elements.
  

Implements [Dump<T>(T, bool)](IDump.Dump.XVZkFQ1vamTg6HNQMK8XrA.md 'KeepCoding.IDump.Dump&lt;T&gt;(T, bool)')  
