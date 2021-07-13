### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(int, Tuple&lt;int,int&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](KeepCoding_Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](KeepCoding_Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this int comparison, KeepCoding.Tuple<int,int> range);
```
#### Parameters
<a name='KeepCoding_Helper_IsBetween(int_KeepCoding_Tuple_int_int_)_comparison'></a>
`comparison` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number to use as comparison.
  
<a name='KeepCoding_Helper_IsBetween(int_KeepCoding_Tuple_int_int_)_range'></a>
`range` [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](KeepCoding_Helper_IsBetween(int_KeepCoding_Tuple_int_int_).md#KeepCoding_Helper_IsBetween(int_KeepCoding_Tuple_int_int_)_comparison 'KeepCoding.Helper.IsBetween(int, KeepCoding.Tuple&lt;int,int&gt;).comparison') is more than or equal [Item1](KeepCoding_Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](KeepCoding_Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
