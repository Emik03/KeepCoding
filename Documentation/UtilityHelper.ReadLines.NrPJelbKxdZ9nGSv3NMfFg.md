#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.ReadLines(TextReader) Method
Enumerates all (remaining) lines from this text reader, reading lines only when needed, and  
hence compatible with potentially blocking or infinite streams.
```csharp
public static System.Collections.Generic.IEnumerable<string> ReadLines(this System.IO.TextReader reader);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.ReadLines(System.IO.TextReader).reader'></a>
`reader` [System.IO.TextReader](https://docs.microsoft.com/en-us/dotnet/api/System.IO.TextReader 'System.IO.TextReader')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
