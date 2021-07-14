#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.AwardPointsOnSolve(int) Method
Yield return this to award the last user that sent the command points when the module is solved. The module must prevent any user from sending commands afterward in order for Twitch Plays to award points to the correct user. This is currently used by the Twin module when extra points must be given but the module is not solved immediately.  
```csharp
protected static string AwardPointsOnSolve(int points);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__AwardPointsOnSolve(int)_points'></a>
`points` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of points to award. Negatives supported.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
