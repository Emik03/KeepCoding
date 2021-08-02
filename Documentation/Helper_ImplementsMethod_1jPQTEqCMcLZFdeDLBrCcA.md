#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.ImplementsMethod&lt;T&gt;(T, string, BindingFlags) Method
Determines if a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') implements a given method.  
```csharp
public static bool ImplementsMethod<T>(this T _, string method, System.Reflection.BindingFlags flags=System.Reflection.BindingFlags.DeclaredOnly|System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic);
```
#### Type parameters
<a name='KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_T'></a>
`T`  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') to check all [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')s.
  
#### Parameters
<a name='KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)__'></a>
`_` [T](Helper_ImplementsMethod_1jPQTEqCMcLZFdeDLBrCcA.md#KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_T 'KeepCoding.Helper.ImplementsMethod&lt;T&gt;(T, string, System.Reflection.BindingFlags).T')  
The discard to get the [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').
  
<a name='KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_method'></a>
`method` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The method to get.
  
<a name='KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_flags'></a>
`flags` [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')  
The [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags') to use in [System.Type.GetMethod(System.String,System.Reflection.BindingFlags)](https://docs.microsoft.com/en-us/dotnet/api/System.Type.GetMethod#System_Type_GetMethod_System_String,System_Reflection_BindingFlags_ 'System.Type.GetMethod(System.String,System.Reflection.BindingFlags)').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [T](Helper_ImplementsMethod_1jPQTEqCMcLZFdeDLBrCcA.md#KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_T 'KeepCoding.Helper.ImplementsMethod&lt;T&gt;(T, string, System.Reflection.BindingFlags).T') has [method](Helper_ImplementsMethod_1jPQTEqCMcLZFdeDLBrCcA.md#KeepCoding_Helper_ImplementsMethod_T_(T_string_System_Reflection_BindingFlags)_method 'KeepCoding.Helper.ImplementsMethod&lt;T&gt;(T, string, System.Reflection.BindingFlags).method').
