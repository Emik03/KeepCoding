#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object) Method
Works as a ternary operator. Returns [then](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_then 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).then') if [condition](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is true, otherwise [otherwise](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_otherwise 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).otherwise').  
```csharp
protected static object Evaluate<T>(bool condition, T then, object otherwise=null);
```
#### Type parameters
<a name='KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_T'></a>
`T`  
The type of then condition.
  
#### Parameters
<a name='KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The boolean to check.
  
<a name='KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_then'></a>
`then` [T](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_T 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).T')  
The output to return if [condition](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is true.
  
<a name='KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_otherwise'></a>
`otherwise` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The output to return if [condition](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is false.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
[then](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_then 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).then') or [otherwise](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_otherwise 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).otherwise'), depending on [condition](TPScript_TModule__Evaluate_DwrQLuJatSgu57qD5a7laQ.md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition').
### Remarks
You can [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') different types with this method, such as ambiguity between a [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') and a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
