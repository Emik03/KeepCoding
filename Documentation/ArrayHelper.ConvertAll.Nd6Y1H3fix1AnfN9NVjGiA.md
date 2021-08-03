#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;) Method
Converts an array of one type to an array of another type.  
```csharp
public static TOutput[] ConvertAll<TInput,TOutput>(this TInput[] array, System.Converter<TInput,TOutput> converter);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TInput'></a>
`TInput`  
The type of the elements of the source array.
  
<a name='KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TOutput'></a>
`TOutput`  
The type of the elements of the target array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).array'></a>
`array` [TInput](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md#KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TInput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TInput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to convert to a target type.
  
<a name='KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).converter'></a>
`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TInput](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md#KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TInput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TInput')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOutput](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md#KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TOutput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TOutput')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')  
A [System.Converter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2') that converts each element from one type to another type.
  
#### Returns
[TOutput](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md#KeepCoding.ArrayHelper.ConvertAll.TInput.TOutput.(TInput...System.Converter.TInput.TOutput.).TOutput 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;).TOutput')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of the target type containing the converted elements from the source array.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0')
