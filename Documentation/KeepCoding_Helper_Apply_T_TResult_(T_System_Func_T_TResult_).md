#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Apply&lt;T,TResult&gt;(T, Func&lt;T,TResult&gt;) Method
Invokes a method of [T](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T') to [TResult](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult') and then returns the argument provided.  
```csharp
public static TResult Apply<T,TResult>(this T item, System.Func<T,TResult> func);
```
#### Type parameters
<a name='KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_T'></a>
`T`  
The type of [item](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item').
  
<a name='KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_TResult'></a>
`TResult`  
The type to return.
  
#### Parameters
<a name='KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_item'></a>
`item` [T](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to apply [item](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item') to.
  
#### Returns
[TResult](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')  
The item [item](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item') after [func](KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T_System_Func_T_TResult_)_func 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).func').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
