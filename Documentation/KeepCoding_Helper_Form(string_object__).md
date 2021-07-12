### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Form(string, object[]) Method
Formats the string. Shorthand for [System.String.Format(System.String,System.Object[])](https://docs.microsoft.com/en-us/dotnet/api/System.String.Format#System_String_Format_System_String,System_Object[]_ 'System.String.Format(System.String,System.Object[])').  
```csharp
public static string Form(this string str, params object[] args);
```
#### Parameters
<a name='KeepCoding_Helper_Form(string_object__)_str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to format. Typically with placeholders involving {0}, {1}, {2}...
  
<a name='KeepCoding_Helper_Form(string_object__)_args'></a>
`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the arguments to put into [str](KeepCoding_Helper_Form(string_object__).md#KeepCoding_Helper_Form(string_object__)_str 'KeepCoding.Helper.Form(string, object[]).str').
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The formatted [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').
