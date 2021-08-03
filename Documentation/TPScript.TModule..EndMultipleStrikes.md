#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.EndMultipleStrikes Field
Yield return this to indicate that the strike tracker should be enabled. If any strikes were issued during the time it was disabled, they will be awarded and the routine stopped at that point, otherwise, it will just cancel the "VoteNay Module {id} got 0 strikes! +0 strike to {Nickname}" message that would otherwise be posted. Likewise, if the module was solved at the time this command is issued, the processing will be stopped as of that point as well.  
```csharp
protected const string EndMultipleStrikes = end multiple strikes;
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
