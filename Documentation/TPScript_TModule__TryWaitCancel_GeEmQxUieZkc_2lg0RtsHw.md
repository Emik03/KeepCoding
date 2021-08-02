#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.TryWaitCancel(float, string) Method
Yield return this to cause Twitch Plays to wait for the given time, and any time during the entire duration, the command may cancel. Like "trycancel", you won't be able to clean up if you cancel this way. Also like "trycancel", [message](TPScript_TModule__TryWaitCancel_GeEmQxUieZkc_2lg0RtsHw.md#KeepCoding_TPScript_TModule__TryWaitCancel(float_string)_message 'KeepCoding.TPScript&lt;TModule&gt;.TryWaitCancel(float, string).message') is optional.  
```csharp
protected static string TryWaitCancel(float time, string message=null);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__TryWaitCancel(float_string)_time'></a>
`time` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The amount of time to wait.
  
<a name='KeepCoding_TPScript_TModule__TryWaitCancel(float_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to send.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
