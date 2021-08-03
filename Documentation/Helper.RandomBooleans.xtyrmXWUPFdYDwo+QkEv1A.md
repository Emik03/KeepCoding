#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.RandomBooleans(int, float) Method
Creates an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of random boolean values.  
```csharp
public static bool[] RandomBooleans(this int length, float weighting=0.5f);
```
#### Parameters
<a name='KeepCoding.Helper.RandomBooleans(int.float).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding.Helper.RandomBooleans(int.float).weighting'></a>
`weighting` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The odds of the boolean being true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of random booleans of length [length](Helper.RandomBooleans.xtyrmXWUPFdYDwo+QkEv1A.md#KeepCoding.Helper.RandomBooleans(int.float).length 'KeepCoding.Helper.RandomBooleans(int, float).length'), with probability based off of [weighting](Helper.RandomBooleans.xtyrmXWUPFdYDwo+QkEv1A.md#KeepCoding.Helper.RandomBooleans(int.float).weighting 'KeepCoding.Helper.RandomBooleans(int, float).weighting').
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
