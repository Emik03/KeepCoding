#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, Tuple&lt;int,int&gt;) Method
Generates a random set of integers.  
```csharp
public static int[] Ranges(this int length, KeepCoding.Tuple<int,int> range);
```
#### Parameters
<a name='KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.int.int.).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.int.int.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum (inclusive) and maximum (exclusive) values.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](Helper.Ranges.ipEgOeA2zCHGTkFu9lOmsA.md#KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.int.int.).length 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;int,int&gt;).length') between [range](Helper.Ranges.ipEgOeA2zCHGTkFu9lOmsA.md#KeepCoding.Helper.Ranges(int.KeepCoding.Tuple.int.int.).range 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;int,int&gt;).range')'s values.
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
