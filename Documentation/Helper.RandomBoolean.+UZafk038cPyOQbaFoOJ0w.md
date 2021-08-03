#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.RandomBoolean(float) Method
Generates a random boolean.  
```csharp
public static bool RandomBoolean(float weighting=0.5f);
```
#### Parameters
<a name='KeepCoding.Helper.RandomBoolean(float).weighting'></a>
`weighting` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The odds of the boolean being true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A random boolean, with probability based off of [weighting](Helper.RandomBoolean.+UZafk038cPyOQbaFoOJ0w.md#KeepCoding.Helper.RandomBoolean(float).weighting 'KeepCoding.Helper.RandomBoolean(float).weighting').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
