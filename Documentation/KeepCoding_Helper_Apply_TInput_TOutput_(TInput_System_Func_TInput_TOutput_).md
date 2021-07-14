#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Apply&lt;TInput,TOutput&gt;(TInput, Func&lt;TInput,TOutput&gt;) Method
Invokes a method of [TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TInput') to [TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TOutput') and then returns the argument provided.  
```csharp
public static TOutput Apply<TInput,TOutput>(this TInput item, System.Func<TInput,TOutput> func);
```
#### Type parameters
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TInput'></a>
`TInput`  
The type of [item](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_item 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).item').
  
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TOutput'></a>
`TOutput`  
The type to return.
  
#### Parameters
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_item'></a>
`item` [TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TInput')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TInput')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TOutput')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to apply [item](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_item 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).item') to.
  
#### Returns
[TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).TOutput')  
The item [item](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_item 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).item') after [func](KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput_System_Func_TInput_TOutput_)_func 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput, System.Func&lt;TInput,TOutput&gt;).func').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
