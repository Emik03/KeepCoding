#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Split(string, int) Method
Splits a string into chunks of equal size. The last chunk may be smaller than [chunkSize](UtilityHelper.Split.g1ZyjS5ZBYVtb1hgBp7nRg.md#KeepCoding.UtilityHelper.Split(string.int).chunkSize 'KeepCoding.UtilityHelper.Split(string, int).chunkSize'),  
but all chunks, if any, will contain at least 1 character.
```csharp
public static System.Collections.Generic.IEnumerable<string> Split(this string str, int chunkSize);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.Split(string.int).str'></a>
`str` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String to split into chunks.
  
<a name='KeepCoding.UtilityHelper.Split(string.int).chunkSize'></a>
`chunkSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Size of each chunk. Must be greater than zero.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A lazy-evaluated collection containing the chunks from the string.
