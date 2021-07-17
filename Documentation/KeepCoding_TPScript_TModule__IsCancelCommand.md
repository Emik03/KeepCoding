#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsCancelCommand Property
Determines if it should cancel command processing. If this returns true, then stop processing the command, clean up, then do a `yield return Cancelled;` to acknowledge the cancel.  
```csharp
public bool IsCancelCommand { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsCancelCommand](KeepCoding_ITP_IsCancelCommand.md 'KeepCoding.ITP.IsCancelCommand')  
### Remarks
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or [KMNeedyModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.OnActivate 'KMNeedyModule.OnActivate') or later.  
