#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(ulong, Tuple&lt;ulong,ulong&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this ulong comparison, KeepCoding.Tuple<ulong,ulong> range);
```
#### Parameters
<a name='KeepCoding.Helper.IsBetween(ulong.KeepCoding.Tuple.ulong.ulong.).comparison'></a>
`comparison` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
The number to use as comparison.
  
<a name='KeepCoding.Helper.IsBetween(ulong.KeepCoding.Tuple.ulong.ulong.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](Helper.IsBetween.nqX71jvS+makO4EsBkid8A.md#KeepCoding.Helper.IsBetween(ulong.KeepCoding.Tuple.ulong.ulong.).comparison 'KeepCoding.Helper.IsBetween(ulong, KeepCoding.Tuple&lt;ulong,ulong&gt;).comparison') is more than or equal [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
