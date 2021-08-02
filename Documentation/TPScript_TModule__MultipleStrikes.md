#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.MultipleStrikes Field
Yield return this to indicate that the issued command is going to cause more than one strike, so should disable the internal strike tracker in order to avoid flooding the chat with "VoteNay Module {id} got a strike! +1 strike to {Nickname}" for as many strikes as will be awarded. This also disables the internal solve tracker as well. This allows for sending additional messages or continue processing commands regardless of the solve/strike state.  
```csharp
protected const string MultipleStrikes = multiple strikes;
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
