#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;) Method
Converts an array of one type to an array of another type.  
```csharp
public static TOutput[] ConvertAll<TInput,TOutput>(this TInput[] array, System.Converter<TInput,TOutput> converter);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TInput'></a>
`TInput`  
The type of the elements of the source array.
  
<a name='KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TOutput'></a>
`TOutput`  
The type of the elements of the target array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_array'></a>
`array` [TInput](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md#KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TInput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TInput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to convert to a target type.
  
<a name='KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_converter'></a>
`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TInput](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md#KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TInput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TInput')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOutput](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md#KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TOutput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TOutput')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')  
A [System.Converter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2') that converts each element from one type to another type.
  
#### Returns
[TOutput](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md#KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_)_TOutput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TOutput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of the target type containing the converted elements from the source array.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0')
