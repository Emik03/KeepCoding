### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.RandomBoolean(float) Method
Generates a random boolean.  
```csharp
public static bool RandomBoolean(float weighting=0.5f);
```
#### Parameters
<a name='KeepCoding_Helper_RandomBoolean(float)_weighting'></a>
`weighting` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The odds of the boolean being true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A random boolean, with probability based off of [weighting](KeepCoding_Helper_RandomBoolean(float).md#KeepCoding_Helper_RandomBoolean(float)_weighting 'KeepCoding.Helper.RandomBoolean(float).weighting').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
