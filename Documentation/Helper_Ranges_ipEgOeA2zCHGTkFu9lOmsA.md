#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Ranges(int, Tuple&lt;int,int&gt;) Method
Generates a random set of integers.  
```csharp
public static int[] Ranges(this int length, KeepCoding.Tuple<int,int> range);
```
#### Parameters
<a name='KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_int_int_)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the array.
  
<a name='KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_int_int_)_range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum (inclusive) and maximum (exclusive) values.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Random integer array of length [length](Helper_Ranges_ipEgOeA2zCHGTkFu9lOmsA.md#KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_int_int_)_length 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;int,int&gt;).length') between [range](Helper_Ranges_ipEgOeA2zCHGTkFu9lOmsA.md#KeepCoding_Helper_Ranges(int_KeepCoding_Tuple_int_int_)_range 'KeepCoding.Helper.Ranges(int, KeepCoding.Tuple&lt;int,int&gt;).range')'s values.
### Remarks
As this uses [UnityEngine.Random](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.  
