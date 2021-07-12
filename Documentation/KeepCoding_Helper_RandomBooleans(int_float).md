### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.RandomBooleans(int, float) Method
Creates an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of random boolean values.  
```csharp
public static bool[] RandomBooleans(this int length, float weighting=0.5f);
```
#### Parameters
<a name='KeepCoding_Helper_RandomBooleans(int_float)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding_Helper_RandomBooleans(int_float)_weighting'></a>
`weighting` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The odds of the boolean being true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of random booleans of length [length](KeepCoding_Helper_RandomBooleans(int_float).md#KeepCoding_Helper_RandomBooleans(int_float)_length 'KeepCoding.Helper.RandomBooleans(int, float).length'), with probability based off of [weighting](KeepCoding_Helper_RandomBooleans(int_float).md#KeepCoding_Helper_RandomBooleans(int_float)_weighting 'KeepCoding.Helper.RandomBooleans(int, float).weighting').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
