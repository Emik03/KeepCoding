#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ITP Interface
Interface for Twitch Plays support.   
```csharp
public interface ITP
```

Derived  
&#8627; [TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')  

| Properties | |
| :--- | :--- |
| [Abandons](ITP.Abandons.md 'KeepCoding.ITP.Abandons') | Declaring this field allows for Twitch Plays to inform the module that the bomb is in Time Mode, where solves change the timer. This is useful for modules that use the timer's value.<br/> |
| [Help](ITP.Help.md 'KeepCoding.ITP.Help') | The help message that gets sent when typing `!{id} help`.<br/> |
| [IsCancelCommand](ITP.IsCancelCommand.md 'KeepCoding.ITP.IsCancelCommand') | Determines if it should cancel command processing. If this returns true, then stop processing the command, clean up, then do a `yield return Cancelled;` to acknowledge the cancel.<br/> |
| [IsTime](ITP.IsTime.md 'KeepCoding.ITP.IsTime') | Determines if it is in Time Mode, where solves change the timer. This is useful for modules that use the timer's value.<br/> |
| [IsTimeSkippable](ITP.IsTimeSkippable.md 'KeepCoding.ITP.IsTimeSkippable') | Determines if it should allow for the timer to be skipped when the module it is in, as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb. <br/> |
| [IsTP](ITP.IsTP.md 'KeepCoding.ITP.IsTP') | Determines if Twitch Plays is currently active. This is for modules that need to display different items, or use different rules if Twitch Plays is active.<br/> |
| [IsZen](ITP.IsZen.md 'KeepCoding.ITP.IsZen') | Determines if the timer is counting up instead of down, for special cases, such as controlling how to sort button release times, or whether there is a low timer event or not.<br/> |
| [Manual](ITP.Manual.md 'KeepCoding.ITP.Manual') | Specifies the manual that is looked up on The Manual Repository when `!{id} manual` is entered into chat.<br/> |

| Methods | |
| :--- | :--- |
| [ForceSolve()](ITP.ForceSolve().md 'KeepCoding.ITP.ForceSolve()') | When the module runs into an exception or the module is forced to be solved, it calls this method.<br/> |
| [Process(string)](ITP.Process.kTZ0ai7Eacb8E933I6F97w.md 'KeepCoding.ITP.Process(string)') | When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.<br/> |
