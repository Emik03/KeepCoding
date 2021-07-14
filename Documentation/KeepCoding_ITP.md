#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ITP Interface
Interface for Twitch Plays support.   
```csharp
public interface ITP
```

Derived  
&#8627; [TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')  

| Properties | |
| :--- | :--- |
| [Abandons](KeepCoding_ITP_Abandons.md 'KeepCoding.ITP.Abandons') |  |
| [Help](KeepCoding_ITP_Help.md 'KeepCoding.ITP.Help') |  |
| [IsCancelCommand](KeepCoding_ITP_IsCancelCommand.md 'KeepCoding.ITP.IsCancelCommand') |  |
| [IsTime](KeepCoding_ITP_IsTime.md 'KeepCoding.ITP.IsTime') |  |
| [IsTimeSkippable](KeepCoding_ITP_IsTimeSkippable.md 'KeepCoding.ITP.IsTimeSkippable') |  |
| [IsTP](KeepCoding_ITP_IsTP.md 'KeepCoding.ITP.IsTP') |  |
| [IsZen](KeepCoding_ITP_IsZen.md 'KeepCoding.ITP.IsZen') |  |
| [Manual](KeepCoding_ITP_Manual.md 'KeepCoding.ITP.Manual') |  |

| Methods | |
| :--- | :--- |
| [ForceSolve()](KeepCoding_ITP_ForceSolve().md 'KeepCoding.ITP.ForceSolve()') | When the module runs into an exception or the module is forced to be solved, it calls this method.<br/> |
| [Process(string)](KeepCoding_ITP_Process(string).md 'KeepCoding.ITP.Process(string)') | When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.<br/> |
