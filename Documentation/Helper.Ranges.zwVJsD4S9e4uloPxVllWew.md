#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, Tuple&lt;float,float&gt;) Method
Generates a random set of integers.  
```csharp
public static float[] Ranges(this int length, KeepCoding.Tuple<float,float> range);
```
#### Parameters
<a name='KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.float.float.).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.float.float.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum (inclusive) and maximum (exclusive) values.
  
#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](Helper.Ranges.zwVJsD4S9e4uloPxVllWew.md#KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.float.float.).length 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;float,float&gt;).length') between [range](Helper.Ranges.zwVJsD4S9e4uloPxVllWew.md#KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.float.float.).range 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;float,float&gt;).range')'s values.
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
