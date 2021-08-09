#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(uint, Tuple&lt;uint,uint&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this uint comparison, KeepCoding.Tuple<uint,uint> range);
```
#### Parameters
<a name='KeepCoding.Helper.IsBetween(uint.KeepCoding.Tuple.uint.uint.).comparison'></a>
`comparison` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The number to use as comparison.
  
<a name='KeepCoding.Helper.IsBetween(uint.KeepCoding.Tuple.uint.uint.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](Helper.IsBetween.SfwmmFXQck+Y3dnbIEw23w.md#KeepCoding.Helper.IsBetween(uint.KeepCoding.Tuple.uint.uint.).comparison 'KeepCoding.Helper.IsBetween(uint, KeepCoding.Tuple&lt;uint,uint&gt;).comparison') is more than or equal [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
