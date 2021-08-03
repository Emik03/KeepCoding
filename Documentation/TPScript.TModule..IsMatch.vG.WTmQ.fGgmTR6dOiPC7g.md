#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsMatch(string, string, bool, RegexOptions) Method
Determines whether the input string matches the regex of the pattern.  
```csharp
protected static bool IsMatch(string input, string pattern, bool lenient=true, System.Text.RegularExpressions.RegexOptions options=System.Text.RegularExpressions.RegexOptions.IgnoreCase|System.Text.RegularExpressions.RegexOptions.CultureInvariant);
```
#### Parameters
<a name='KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The test string.
  
<a name='KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).pattern'></a>
`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The regular expression.
  
<a name='KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).lenient'></a>
`lenient` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should add the default `^\s* PATTERN \s*$` embeded into most regex usages for Twitch Plays.
  
<a name='KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).options'></a>
`options` [System.Text.RegularExpressions.RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions')  
Any additional options for regular expressions.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [input](TPScript.TModule..IsMatch.vG.WTmQ.fGgmTR6dOiPC7g.md#KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).input 'KeepCoding.TPScript&lt;TModule&gt;.IsMatch(string, string, bool, System.Text.RegularExpressions.RegexOptions).input') passes the test of the [pattern](TPScript.TModule..IsMatch.vG.WTmQ.fGgmTR6dOiPC7g.md#KeepCoding.TPScript.TModule..IsMatch(string.string.bool.System.Text.RegularExpressions.RegexOptions).pattern 'KeepCoding.TPScript&lt;TModule&gt;.IsMatch(string, string, bool, System.Text.RegularExpressions.RegexOptions).pattern').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
