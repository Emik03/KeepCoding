### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.SkipTime(string) Method
Yield return this to try advancing the clock to the specified time. You must put the full time you wish to skip to, and this time either needs to be less than the current time, if in normal/time mode, or greater than the current time, if in zen mode. Example, if you wanted to set the clock to 5:24, then you do "skiptime 324" or "skiptime 5:24". You can target partway through the seconds, such as "skiptime 45.28", which would then set the clock to 45.28, provided that time has NOT gone by already. You must also set [IsTimeSkippable](KeepCoding_TPScript_TModule__IsTimeSkippable.md 'KeepCoding.TPScript&lt;TModule&gt;.IsTimeSkippable') to true, for this function to work.  
```csharp
protected static string SkipTime(string seconds=null);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__SkipTime(string)_seconds'></a>
`seconds` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The time to skip to in seconds.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
