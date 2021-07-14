#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, float, float) Method
Generates a random set of floats.  
```csharp
public static float[] Ranges(this int length, float min, float max);
```
#### Parameters
<a name='KeepCoding_Helper_Ranges(int_float_float)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding_Helper_Ranges(int_float_float)_min'></a>
`min` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The minimum value for each index. (inclusive)
  
<a name='KeepCoding_Helper_Ranges(int_float_float)_max'></a>
`max` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The maximum value for each index. (inclusive)
  
#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random float array of length [length](KeepCoding_Helper_Ranges(int_float_float).md#KeepCoding_Helper_Ranges(int_float_float)_length 'KeepCoding.Helper.Ranges(int, float, float).length') between [min](KeepCoding_Helper_Ranges(int_float_float).md#KeepCoding_Helper_Ranges(int_float_float)_min 'KeepCoding.Helper.Ranges(int, float, float).min') and [max](KeepCoding_Helper_Ranges(int_float_float).md#KeepCoding_Helper_Ranges(int_float_float)_max 'KeepCoding.Helper.Ranges(int, float, float).max').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
