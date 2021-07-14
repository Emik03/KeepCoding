#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Unwrap&lt;T&gt;(T, bool) Method
Unwraps any object, whether it be a class, list, tuple, or any other data.  
```csharp
public static object[] Unwrap<T>(this T source, bool isRecursive=false);
```
#### Type parameters
<a name='KeepCoding_Helper_Unwrap_T_(T_bool)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_Unwrap_T_(T_bool)_source'></a>
`source` [T](KeepCoding_Helper_Unwrap_T_(T_bool).md#KeepCoding_Helper_Unwrap_T_(T_bool)_T 'KeepCoding.Helper.Unwrap&lt;T&gt;(T, bool).T')  
The object to unwrap.
  
<a name='KeepCoding_Helper_Unwrap_T_(T_bool)_isRecursive'></a>
`isRecursive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search inside the variable and yield return the elements inside [source](KeepCoding_Helper_Unwrap_T_(T_bool).md#KeepCoding_Helper_Unwrap_T_(T_bool)_source 'KeepCoding.Helper.Unwrap&lt;T&gt;(T, bool).source').
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of all elements within [source](KeepCoding_Helper_Unwrap_T_(T_bool).md#KeepCoding_Helper_Unwrap_T_(T_bool)_source 'KeepCoding.Helper.Unwrap&lt;T&gt;(T, bool).source').
