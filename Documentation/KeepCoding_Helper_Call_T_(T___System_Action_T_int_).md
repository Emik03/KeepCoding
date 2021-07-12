### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Call&lt;T&gt;(T[], Action&lt;T,int&gt;) Method
Invokes a method of [T](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T') and then returns the argument provided.  
```csharp
public static T[] Call<T>(this T[] source, System.Action<T,int> action);
```
#### Type parameters
<a name='KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_T'></a>
`T`  
The type of [source](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source') and [action](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_action 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).action').
  
#### Parameters
<a name='KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_source'></a>
`source` [T](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to apply [source](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source') to.
  
#### Returns
[T](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item [source](KeepCoding_Helper_Call_T_(T___System_Action_T_int_).md#KeepCoding_Helper_Call_T_(T___System_Action_T_int_)_source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source').
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
