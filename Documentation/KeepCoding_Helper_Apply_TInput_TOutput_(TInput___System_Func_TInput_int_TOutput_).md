### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Apply&lt;TInput,TOutput&gt;(TInput[], Func&lt;TInput,int,TOutput&gt;) Method
Invokes a method of [TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TInput') to [TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TOutput') and then returns the argument provided.  
```csharp
public static TOutput[] Apply<TInput,TOutput>(this TInput[] items, System.Func<TInput,int,TOutput> func);
```
#### Type parameters
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TInput'></a>
`TInput`  
The type of [items](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_items 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).items').
  
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TOutput'></a>
`TOutput`  
The type to return.
  
#### Parameters
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_items'></a>
`items` [TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TInput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item to use as reference and modify.
  
<a name='KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TInput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TInput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TInput')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TOutput')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The function to apply [items](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_items 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).items') to.
  
#### Returns
[TOutput](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_TOutput 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).TOutput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item [items](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_items 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).items') after [func](KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_).md#KeepCoding_Helper_Apply_TInput_TOutput_(TInput___System_Func_TInput_int_TOutput_)_func 'KeepCoding.Helper.Apply&lt;TInput,TOutput&gt;(TInput[], System.Func&lt;TInput,int,TOutput&gt;).func').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
