#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object) Method
Works as a ternary operator. Returns [then](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).then 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).then') if [condition](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), otherwise [otherwise](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).otherwise 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).otherwise').  
```csharp
protected static object Evaluate<T>(bool condition, T then, object otherwise=null);
```
#### Type parameters
<a name='KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).T'></a>
`T`  
The type of then condition.
  
#### Parameters
<a name='KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).condition'></a>
`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The boolean to check.
  
<a name='KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).then'></a>
`then` [T](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).T 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).T')  
The output to return if [condition](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
<a name='KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).otherwise'></a>
`otherwise` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The output to return if [condition](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is false.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
[then](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).then 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).then') or [otherwise](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).otherwise 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).otherwise'), depending on [condition](TPScript.TModule..Evaluate.DwrQLuJatSgu57qD5a7laQ.md#KeepCoding.TPScript.TModule..Evaluate.T.(bool.T.object).condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition').
### Remarks
You can [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') different types with this method, such as ambiguity between a [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') and a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
