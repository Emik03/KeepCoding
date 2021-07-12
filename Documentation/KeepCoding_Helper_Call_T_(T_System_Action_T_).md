### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Call&lt;T&gt;(T, Action&lt;T&gt;) Method
Invokes a method of [T](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T') and then returns the argument provided.  
```csharp
public static T Call<T>(this T item, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding_Helper_Call_T_(T_System_Action_T_)_T'></a>
`T`  
The type of [item](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item') and [action](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_action 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).action').
  
#### Parameters
<a name='KeepCoding_Helper_Call_T_(T_System_Action_T_)_item'></a>
`item` [T](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Call_T_(T_System_Action_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to apply [item](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item') to.
  
#### Returns
[T](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item [item](KeepCoding_Helper_Call_T_(T_System_Action_T_).md#KeepCoding_Helper_Call_T_(T_System_Action_T_)_item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
