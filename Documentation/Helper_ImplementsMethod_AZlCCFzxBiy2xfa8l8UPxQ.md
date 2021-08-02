#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.ImplementsMethod(Type, string, BindingFlags) Method
Determines if a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') implements a given method.  
```csharp
public static bool ImplementsMethod(this System.Type type, string method, System.Reflection.BindingFlags flags=System.Reflection.BindingFlags.DeclaredOnly|System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic);
```
#### Parameters
<a name='KeepCoding_Helper_ImplementsMethod(System_Type_string_System_Reflection_BindingFlags)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type to check all [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')s.
  
<a name='KeepCoding_Helper_ImplementsMethod(System_Type_string_System_Reflection_BindingFlags)_method'></a>
`method` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The method to get.
  
<a name='KeepCoding_Helper_ImplementsMethod(System_Type_string_System_Reflection_BindingFlags)_flags'></a>
`flags` [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')  
The [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags') to use in [System.Type.GetMethod(System.String,System.Reflection.BindingFlags)](https://docs.microsoft.com/en-us/dotnet/api/System.Type.GetMethod#System_Type_GetMethod_System_String,System_Reflection_BindingFlags_ 'System.Type.GetMethod(System.String,System.Reflection.BindingFlags)').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [type](Helper_ImplementsMethod_AZlCCFzxBiy2xfa8l8UPxQ.md#KeepCoding_Helper_ImplementsMethod(System_Type_string_System_Reflection_BindingFlags)_type 'KeepCoding.Helper.ImplementsMethod(System.Type, string, System.Reflection.BindingFlags).type') has [method](Helper_ImplementsMethod_AZlCCFzxBiy2xfa8l8UPxQ.md#KeepCoding_Helper_ImplementsMethod(System_Type_string_System_Reflection_BindingFlags)_method 'KeepCoding.Helper.ImplementsMethod(System.Type, string, System.Reflection.BindingFlags).method').
