#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game').[MasterAudio](Game.MasterAudio.md 'KeepCoding.Game.MasterAudio')
## Game.MasterAudio.GroupInfo Property
Gets the group info of a given string. To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to AudioGroupInfo type to restore its functionality.  
```csharp
public static System.Func<string,string,object> GroupInfo { get; }
```
#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: Returns the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') argument given boxed as [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object').  
