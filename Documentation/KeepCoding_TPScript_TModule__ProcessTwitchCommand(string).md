#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.ProcessTwitchCommand(string) Method
This method gets grabbed by Twitch Plays. It grabs [Process(string)](KeepCoding_TPScript_TModule__Process(string).md 'KeepCoding.TPScript&lt;TModule&gt;.Process(string)') and flattens it using [Flatten(IEnumerator, Predicate&lt;object&gt;)](KeepCoding_Helper_Flatten(System_Collections_IEnumerator_System_Predicate_object_).md 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;object&gt;)').  
```csharp
protected System.Collections.IEnumerator ProcessTwitchCommand(string command);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__ProcessTwitchCommand(string)_command'></a>
`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The command of the user.
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A list of instructions for Twitch Plays.
