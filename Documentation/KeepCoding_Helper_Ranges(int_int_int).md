### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, int, int) Method
Generates a random set of integers.  
```csharp
public static int[] Ranges(this int length, int min, int max);
```
#### Parameters
<a name='KeepCoding_Helper_Ranges(int_int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding_Helper_Ranges(int_int_int)_min'></a>
`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The minimum value for each index. (inclusive)
  
<a name='KeepCoding_Helper_Ranges(int_int_int)_max'></a>
`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The maximum value for each index. (exclusive)
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](KeepCoding_Helper_Ranges(int_int_int).md#KeepCoding_Helper_Ranges(int_int_int)_length 'KeepCoding.Helper.Ranges(int, int, int).length') between [min](KeepCoding_Helper_Ranges(int_int_int).md#KeepCoding_Helper_Ranges(int_int_int)_min 'KeepCoding.Helper.Ranges(int, int, int).min') and [max](KeepCoding_Helper_Ranges(int_int_int).md#KeepCoding_Helper_Ranges(int_int_int)_max 'KeepCoding.Helper.Ranges(int, int, int).max').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
