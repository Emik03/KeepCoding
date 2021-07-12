### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsZen Property
```csharp
public bool IsZen { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
Determines if the timer is counting up instead of down, for special cases, such as controlling how to sort button release times, or whether there is a low timer event or not.  

Implements [IsZen](KeepCoding_ITP_IsZen.md 'KeepCoding.ITP.IsZen')  
### Remarks
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or [KMNeedyModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.OnActivate 'KMNeedyModule.OnActivate') or later.  
