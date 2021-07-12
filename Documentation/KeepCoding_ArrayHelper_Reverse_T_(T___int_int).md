### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Reverse&lt;T&gt;(T[], int, int) Method
Reverses the sequence of a subset of the elements in the one-dimensional generic array.  
```csharp
internal static T[] Reverse<T>(this T[] array, int index, int length);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_T'></a>
`T`  
The type of the elements in [array](KeepCoding_ArrayHelper_Reverse_T_(T___int_int).md#KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_array 'KeepCoding.ArrayHelper.Reverse&lt;T&gt;(T[], int, int).array').
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_array'></a>
`array` [T](KeepCoding_ArrayHelper_Reverse_T_(T___int_int).md#KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_T 'KeepCoding.ArrayHelper.Reverse&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional array of elements to reverse.
  
<a name='KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting index of the section to reverse.
  
<a name='KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of elements in the section to reverse.
  
#### Returns
[T](KeepCoding_ArrayHelper_Reverse_T_(T___int_int).md#KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_T 'KeepCoding.ArrayHelper.Reverse&lt;T&gt;(T[], int, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](KeepCoding_ArrayHelper_Reverse_T_(T___int_int).md#KeepCoding_ArrayHelper_Reverse_T_(T___int_int)_array 'KeepCoding.ArrayHelper.Reverse&lt;T&gt;(T[], int, int).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse__1___0___System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse__1___0___System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse__1___0___System_Int32_System_Int32_')
