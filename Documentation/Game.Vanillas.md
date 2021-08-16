#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game')
## Game.Vanillas Property
Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). You can cast it to BombComponent type to restore its functionality.  
```csharp
public static System.Func<KMBomb,object[]> Vanillas { get; }
```
#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: An empty [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
