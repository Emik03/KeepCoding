#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](KeepCoding_Game.md 'KeepCoding.Game')
## Game.Bomb Property
Gets the game's internal bomb component, not to be mistaken with [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb'). To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to Bomb or [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') type to restore its functionality.  
```csharp
public static System.Func<GameObject,object> Bomb { get; }
```
#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')
### Remarks
Default: [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
