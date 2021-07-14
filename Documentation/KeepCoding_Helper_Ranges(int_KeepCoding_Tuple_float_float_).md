#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, Tuple&lt;float,float&gt;) Method
Generates a random set of integers.  
```csharp
public static float[] Ranges(this int length, KeepCoding.Tuple<float,float> range);
```
#### Parameters
<a name='KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_)_range'></a>
`range` [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum (inclusive) and maximum (exclusive) values.
  
#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_).md#KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_)_length 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;float,float&gt;).length') between [range](KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_).md#KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_float_float_)_range 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;float,float&gt;).range')'s values.
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
