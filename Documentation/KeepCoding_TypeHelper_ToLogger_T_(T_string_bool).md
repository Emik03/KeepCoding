### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToLogger&lt;T&gt;(T, string, bool) Method
Converts arguments to a new [Logger](KeepCoding_Logger.md 'KeepCoding.Logger').  
```csharp
public static KeepCoding.Logger ToLogger<T>(this T _, string name=null, bool showId=false);
```
#### Type parameters
<a name='KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)_T'></a>
`T`  
The type of the argument, which is used as the name if [name](KeepCoding_TypeHelper_ToLogger_T_(T_string_bool).md#KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)_name 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool).name') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Parameters
<a name='KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)__'></a>
`_` [T](KeepCoding_TypeHelper_ToLogger_T_(T_string_bool).md#KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)_T 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool).T')  
The discard which is only needed for the type.
  
<a name='KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the value.
  
<a name='KeepCoding_TypeHelper_ToLogger_T_(T_string_bool)_showId'></a>
`showId` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to show the unique identifier when logging.
  
#### Returns
[Logger](KeepCoding_Logger.md 'KeepCoding.Logger')  
A new [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') containing the arguments specified.
