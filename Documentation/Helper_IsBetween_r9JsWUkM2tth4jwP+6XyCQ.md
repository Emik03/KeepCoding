#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(float, Tuple&lt;float,float&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this float comparison, KeepCoding.Tuple<float,float> range);
```
#### Parameters
<a name='KeepCoding_Helper_IsBetween(float_KeepCoding_Tuple_float_float_)_comparison'></a>
`comparison` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The number to use as comparison.
  
<a name='KeepCoding_Helper_IsBetween(float_KeepCoding_Tuple_float_float_)_range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](Helper_IsBetween_r9JsWUkM2tth4jwP+6XyCQ.md#KeepCoding_Helper_IsBetween(float_KeepCoding_Tuple_float_float_)_comparison 'KeepCoding.Helper.IsBetween(float, KeepCoding.Tuple&lt;float,float&gt;).comparison') is more than or equal [Item1](Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
