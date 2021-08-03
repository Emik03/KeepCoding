#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.AwardPoints(int) Method
Yield return this to award the user that sent the command points directly, this is currently used for mods like Souvenir to give points to users that answered the questions equally.  
```csharp
protected static string AwardPoints(int points);
```
#### Parameters
<a name='KeepCoding.TPScript.TModule..AwardPoints(int).points'></a>
`points` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of points to award. Negatives supported.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
