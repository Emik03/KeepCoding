#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.WordWrap(string, int, int) Method
Word-wraps the current string to a specified width. Supports UNIX-style newlines and indented paragraphs.
```csharp
public static System.Collections.Generic.IEnumerable<string> WordWrap(this string text, int maxWidth, int hangingIndent=0);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_WordWrap(string_int_int)_text'></a>
`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Text to be word-wrapped.
  
<a name='KeepCoding_UtilityExtensions_WordWrap(string_int_int)_maxWidth'></a>
`maxWidth` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The maximum number of characters permitted on a single line, not counting the end-of-line terminator.
  
<a name='KeepCoding_UtilityExtensions_WordWrap(string_int_int)_hangingIndent'></a>
`hangingIndent` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of spaces to add to each line except the first of each paragraph, thus creating a hanging  
indentation.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
### Remarks
The supplied text will be split into "paragraphs" at the newline characters. Every paragraph will begin on  
a new line in the word-wrapped output, indented by the same number of spaces as in the input. All  
subsequent lines belonging to that paragraph will also be indented by the same amount.



  
All multiple contiguous spaces will be replaced with a single space (except for the indentation).
