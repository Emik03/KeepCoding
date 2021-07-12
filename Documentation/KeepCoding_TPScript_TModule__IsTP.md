### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsTP Property
```csharp
public bool IsTP { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
Determines if Twitch Plays is currently active. This is for modules that need to display different items, or use different rules if Twitch Plays is active.  

Implements [IsTP](KeepCoding_ITP_IsTP.md 'KeepCoding.ITP.IsTP')  
### Remarks
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or [KMNeedyModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.OnActivate 'KMNeedyModule.OnActivate') or later.  
