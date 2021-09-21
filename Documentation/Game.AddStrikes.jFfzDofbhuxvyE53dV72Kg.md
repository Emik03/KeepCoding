#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game')
## Game.AddStrikes(KMBomb, int, bool) Method
Adds an amount of strikes on the bomb, and returns the bomb object used, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static object AddStrikes(KMBomb bomb, int strikeDelta, bool allowExplosion);
```
#### Parameters
<a name='KeepCoding.Game.AddStrikes(KMBomb.int.bool).bomb'></a>
`bomb` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')  
The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') component which is attached to the inner Bomb component.
  
<a name='KeepCoding.Game.AddStrikes(KMBomb.int.bool).strikeDelta'></a>
`strikeDelta` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of strikes to add.
  
<a name='KeepCoding.Game.AddStrikes(KMBomb.int.bool).allowExplosion'></a>
`allowExplosion` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should check whether the bomb should explode from strikes.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The bomb [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') of the bomb used to assign strikes.
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: Internal Logger method call.  
