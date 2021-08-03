#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.ProcessTwitchCommand(string) Method
This method gets grabbed by Twitch Plays. It grabs [Process(string)](TPScript_TModule__Process_KVA0HcMKHcn6ZE3rntOuvA.md 'KeepCoding.TPScript&lt;TModule&gt;.Process(string)') and flattens it using [Flatten(IEnumerator, Predicate&lt;IEnumerator&gt;)](Helper_Flatten_1fU+zZAhpugERKJvQxZvsQ.md 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator, System.Predicate&lt;System.Collections.IEnumerator&gt;)').  
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
