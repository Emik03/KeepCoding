#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsMatch(string, string, bool, RegexOptions) Method
Determines whether the input string matches the regex of the pattern.  
```csharp
protected static bool IsMatch(string input, string pattern, bool lenient=true, System.Text.RegularExpressions.RegexOptions options=System.Text.RegularExpressions.RegexOptions.IgnoreCase|System.Text.RegularExpressions.RegexOptions.CultureInvariant);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_input'></a>
`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The test string.
  
<a name='KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_pattern'></a>
`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The regular expression.
  
<a name='KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_lenient'></a>
`lenient` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should add the default `^\s* PATTERN \s*$` embeded into most regex usages for Twitch Plays.
  
<a name='KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_options'></a>
`options` [System.Text.RegularExpressions.RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions')  
Any additional options for regular expressions.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [input](KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions).md#KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_input 'KeepCoding.TPScript&lt;TModule&gt;.IsMatch(string, string, bool, System.Text.RegularExpressions.RegexOptions).input') passes the test of the [pattern](KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions).md#KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions)_pattern 'KeepCoding.TPScript&lt;TModule&gt;.IsMatch(string, string, bool, System.Text.RegularExpressions.RegexOptions).pattern').
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
