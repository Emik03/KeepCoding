#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.IsZen Property
Determines if the timer is counting up instead of down, for special cases, such as controlling how to sort button release times, or whether there is a low timer event or not.  
```csharp
public bool IsZen { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsZen](ITP.IsZen.md 'KeepCoding.ITP.IsZen')  
### Remarks
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or [KMNeedyModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.OnActivate 'KMNeedyModule.OnActivate') or later.  
