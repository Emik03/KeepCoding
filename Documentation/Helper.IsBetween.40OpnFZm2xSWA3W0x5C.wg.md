#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsBetween(char, Tuple&lt;char,char&gt;) Method
Determines whether the number is equal or in-between a tuple's [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') (minimum) and [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') (maximum).  
```csharp
public static bool IsBetween(this char comparison, KeepCoding.Tuple<char,char> range);
```
#### Parameters
<a name='KeepCoding.Helper.IsBetween(char.KeepCoding.Tuple.char.char.).comparison'></a>
`comparison` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')  
The number to use as comparison.
  
<a name='KeepCoding.Helper.IsBetween(char.KeepCoding.Tuple.char.char.).range'></a>
`range` [KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The minimum and maximum value required to return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [comparison](Helper.IsBetween.40OpnFZm2xSWA3W0x5C.wg.md#KeepCoding.Helper.IsBetween(char.KeepCoding.Tuple.char.char.).comparison 'KeepCoding.Helper.IsBetween(char, KeepCoding.Tuple&lt;char,char&gt;).comparison') is more than or equal [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') and less than or equal [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2').
