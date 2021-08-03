#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, int, int) Method
Generates a random set of integers.  
```csharp
public static int[] Ranges(this int length, int min, int max);
```
#### Parameters
<a name='KeepCoding.Helper.Ranges(int.int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding.Helper.Ranges(int.int.int).min'></a>
`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The minimum value for each index. (inclusive)
  
<a name='KeepCoding.Helper.Ranges(int.int.int).max'></a>
`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The maximum value for each index. (exclusive)
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](Helper.Ranges.WRP2UzRdC5ndc10CiVZFew.md#KeepCoding.Helper.Ranges(int.int.int).length 'KeepCoding.Helper.Ranges(int, int, int).length') between [min](Helper.Ranges.WRP2UzRdC5ndc10CiVZFew.md#KeepCoding.Helper.Ranges(int.int.int).min 'KeepCoding.Helper.Ranges(int, int, int).min') and [max](Helper.Ranges.WRP2UzRdC5ndc10CiVZFew.md#KeepCoding.Helper.Ranges(int.int.int).max 'KeepCoding.Helper.Ranges(int, int, int).max').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
