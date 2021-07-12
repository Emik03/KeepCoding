### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.UnwrapToString&lt;T&gt;(T, bool, string) Method
Unwraps any object, whether it be a class, list, tuple, or any other data and concatenates it into a string.  
```csharp
public static string UnwrapToString<T>(this T item, bool getVariables=false, string delimiter=", ");
```
#### Type parameters
<a name='KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_item'></a>
`item` [T](KeepCoding_Helper_UnwrapToString_T_(T_bool_string).md#KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_T 'KeepCoding.Helper.UnwrapToString&lt;T&gt;(T, bool, string).T')  
The object to unwrap.
  
<a name='KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_getVariables'></a>
`getVariables` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search recursively inside the variable and yield return the elements inside [item](KeepCoding_Helper_UnwrapToString_T_(T_bool_string).md#KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_item 'KeepCoding.Helper.UnwrapToString&lt;T&gt;(T, bool, string).item').
  
<a name='KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_delimiter'></a>
`delimiter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The characters in-between each element.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string consisting of all values from [item](KeepCoding_Helper_UnwrapToString_T_(T_bool_string).md#KeepCoding_Helper_UnwrapToString_T_(T_bool_string)_item 'KeepCoding.Helper.UnwrapToString&lt;T&gt;(T, bool, string).item').
