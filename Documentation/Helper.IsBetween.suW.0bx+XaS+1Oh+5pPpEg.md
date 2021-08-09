#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(long, Tuple&lt;long,long&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this long comparison, KeepCoding.Tuple<long,long> range);
```
#### Parameters
<a name='KeepCoding.Helper.IsBetween(long.KeepCoding.Tuple.long.long.).comparison'></a>
`comparison` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The number to use as comparison.
  
<a name='KeepCoding.Helper.IsBetween(long.KeepCoding.Tuple.long.long.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](Helper.IsBetween.suW.0bx+XaS+1Oh+5pPpEg.md#KeepCoding.Helper.IsBetween(long.KeepCoding.Tuple.long.long.).comparison 'KeepCoding.Helper.IsBetween(long, KeepCoding.Tuple&lt;long,long&gt;).comparison') is more than or equal [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
