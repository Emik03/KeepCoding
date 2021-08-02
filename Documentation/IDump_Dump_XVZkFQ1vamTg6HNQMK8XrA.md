#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[IDump](IDump.md 'KeepCoding.IDump')
## IDump.Dump&lt;T&gt;(T, bool) Method
Dumps all information that it can find of the type using reflection. This should only be used to debug.  
```csharp
void Dump<T>(T obj, bool getVariables=false);
```
#### Type parameters
<a name='KeepCoding_IDump_Dump_T_(T_bool)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_IDump_Dump_T_(T_bool)_obj'></a>
`obj` [T](IDump_Dump_XVZkFQ1vamTg6HNQMK8XrA.md#KeepCoding_IDump_Dump_T_(T_bool)_T 'KeepCoding.IDump.Dump&lt;T&gt;(T, bool).T')  
The object to reflect on.
  
<a name='KeepCoding_IDump_Dump_T_(T_bool)_getVariables'></a>
`getVariables` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search recursively for the elements within the elements.
  
