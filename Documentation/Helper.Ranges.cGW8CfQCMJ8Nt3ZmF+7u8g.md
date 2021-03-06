#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, float, float) Method
Generates a random set of floats.  
```csharp
public static float[] Ranges(this int length, float min, float max);
```
#### Parameters
<a name='KeepCoding.Helper.Ranges(int.float.float).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding.Helper.Ranges(int.float.float).min'></a>
`min` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The minimum value for each index. (inclusive)
  
<a name='KeepCoding.Helper.Ranges(int.float.float).max'></a>
`max` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The maximum value for each index. (inclusive)
  
#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random float array of length [length](Helper.Ranges.cGW8CfQCMJ8Nt3ZmF+7u8g.md#KeepCoding.Helper.Ranges(int.float.float).length 'KeepCoding.Helper.Ranges(int, float, float).length') between [min](Helper.Ranges.cGW8CfQCMJ8Nt3ZmF+7u8g.md#KeepCoding.Helper.Ranges(int.float.float).min 'KeepCoding.Helper.Ranges(int, float, float).min') and [max](Helper.Ranges.cGW8CfQCMJ8Nt3ZmF+7u8g.md#KeepCoding.Helper.Ranges(int.float.float).max 'KeepCoding.Helper.Ranges(int, float, float).max').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
