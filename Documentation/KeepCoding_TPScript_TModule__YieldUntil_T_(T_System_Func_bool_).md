### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, Func&lt;bool&gt;) Method
You can yield return this to repeatedly yield return an item until a condition is met.  
```csharp
protected static System.Collections.IEnumerator YieldUntil<T>(T item, System.Func<bool> condition);
```
#### Type parameters
<a name='KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_item'></a>
`item` [T](KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_).md#KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_T 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).T')  
The item to yield repeatedly.
  
<a name='KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition to repeatedly check until it returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[item](KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_).md#KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_item 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).item') continously until [condition](KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_).md#KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_)_condition 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
