#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Apply&lt;T,TResult&gt;(T[], Func&lt;T,int,TResult&gt;) Method
Invokes a method of [T](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).T') to [TResult](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).TResult') and then returns the argument provided.  
```csharp
public static TResult[] Apply<T,TResult>(this T[] items, System.Func<T,int,TResult> func);
```
#### Type parameters
<a name='KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_T'></a>
`T`  
The type of [items](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_items 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).items').
  
<a name='KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_TResult'></a>
`TResult`  
The type to return.
  
#### Parameters
<a name='KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_items'></a>
`items` [T](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The function to apply [items](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_items 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).items') to.
  
#### Returns
[TResult](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).TResult')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item [items](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_items 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).items') after [func](KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_).md#KeepCoding_Helper_Apply_T_TResult_(T___System_Func_T_int_TResult_)_func 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T[], System.Func&lt;T,int,TResult&gt;).func').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
