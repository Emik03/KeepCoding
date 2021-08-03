#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.Process(string) Method
When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.  
```csharp
public abstract System.Collections.IEnumerator Process(string command);
```
#### Parameters
<a name='KeepCoding.TPScript.TModule..Process(string).command'></a>
`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The user's command.
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle as requested by the user.

Implements [Process(string)](ITP.Process.kTZ0ai7Eacb8E933I6F97w.md 'KeepCoding.ITP.Process(string)')  
### Remarks
Anything that gets yield returned will be processed by Twitch Plays. This includes other [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') methods, [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable'), an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable'), [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), `true`, or `null`.  
