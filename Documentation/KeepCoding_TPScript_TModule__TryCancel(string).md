### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.TryCancel(string) Method
Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield. Just know that you won't be able to clean up if you do your cancel this way, and there is a pending !cancel or !stop.  
```csharp
protected static string TryCancel(string message=null);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__TryCancel(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to send.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
