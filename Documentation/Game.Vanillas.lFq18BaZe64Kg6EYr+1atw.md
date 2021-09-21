#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game')
## Game.Vanillas(KMBomb) Method
Gets all of the vanilla modules from the bomb supplied, including needies. To prevent a reference to the game, the type is boxed in an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). You can cast it to BombComponent type to restore its functionality.  
```csharp
public static object[] Vanillas(KMBomb bomb);
```
#### Parameters
<a name='KeepCoding.Game.Vanillas(KMBomb).bomb'></a>
`bomb` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')  
The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') instance that is the parent [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject') to all vanilla modules.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All vanilla modules on the current [bomb](Game.Vanillas.lFq18BaZe64Kg6EYr+1atw.md#KeepCoding.Game.Vanillas(KMBomb).bomb 'KeepCoding.Game.Vanillas(KMBomb).bomb').
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: An encapsulated method that takes a [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject') and always returns an empty [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
