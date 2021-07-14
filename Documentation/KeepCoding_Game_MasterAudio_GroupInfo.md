#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](KeepCoding_Game.md 'KeepCoding.Game').[MasterAudio](KeepCoding_Game_MasterAudio.md 'KeepCoding.Game.MasterAudio')
## Game.MasterAudio.GroupInfo Property
```csharp
public static System.Func<string,object> GroupInfo { get; }
```
#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')
Gets the group info of a given string. To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to AudioGroupInfo type to restore its functionality.  
### Remarks
Default: [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
