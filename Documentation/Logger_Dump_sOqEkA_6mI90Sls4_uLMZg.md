#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Logger](Logger.md 'KeepCoding.Logger')
## Logger.Dump&lt;T&gt;(T, bool) Method
Dumps all information that it can find of the type using reflection. This should only be used to debug.  
```csharp
public void Dump<T>(T obj, bool getVariables=false);
```
#### Type parameters
<a name='KeepCoding_Logger_Dump_T_(T_bool)_T'></a>
`T`  
The type of component to reflect on.
  
#### Parameters
<a name='KeepCoding_Logger_Dump_T_(T_bool)_obj'></a>
`obj` [T](Logger_Dump_sOqEkA_6mI90Sls4_uLMZg.md#KeepCoding_Logger_Dump_T_(T_bool)_T 'KeepCoding.Logger.Dump&lt;T&gt;(T, bool).T')  
The object to reflect on.
  
<a name='KeepCoding_Logger_Dump_T_(T_bool)_getVariables'></a>
`getVariables` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search recursively for the elements within the elements.
  

Implements [Dump<T>(T, bool)](IDump_Dump_XVZkFQ1vamTg6HNQMK8XrA.md 'KeepCoding.IDump.Dump&lt;T&gt;(T, bool)')  
