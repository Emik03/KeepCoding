#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsTimeSkippable Property
Determines if it should allow for the timer to be skipped when the module it is in, as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb.   
```csharp
public bool IsTimeSkippable { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsTimeSkippable](ITP_IsTimeSkippable.md 'KeepCoding.ITP.IsTimeSkippable')  
### Remarks
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or [KMNeedyModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.OnActivate 'KMNeedyModule.OnActivate') or later.  
