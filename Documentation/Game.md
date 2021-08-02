#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Game Class
Allows access into the game's internal code.   
```csharp
public static class Game
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Game  
### Remarks
On the Editor, these properties will return default values. Check the XML documentation to see the value it returns.  

| Properties | |
| :--- | :--- |
| [AddStrikes](Game_AddStrikes.md 'KeepCoding.Game.AddStrikes') | Adds an amount of strikes on the bomb.<br/> |
| [Bomb](Game_Bomb.md 'KeepCoding.Game.Bomb') | Gets the game's internal bomb component, not to be mistaken with [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb'). To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to Bomb or [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') type to restore its functionality.<br/> |
| [SetStrikes](Game_SetStrikes.md 'KeepCoding.Game.SetStrikes') | Sets an amount of strikes on the bomb.<br/> |
| [Timer](Game_Timer.md 'KeepCoding.Game.Timer') | Gets the game's internal timer component. To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to TimerComponent or [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') type to restore its functionality.<br/> |
| [Vanillas](Game_Vanillas.md 'KeepCoding.Game.Vanillas') | Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). You can cast it to BombComponent type to restore its functionality.<br/> |
