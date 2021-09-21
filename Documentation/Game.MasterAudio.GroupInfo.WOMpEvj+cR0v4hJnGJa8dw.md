#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game').[MasterAudio](Game.MasterAudio.md 'KeepCoding.Game.MasterAudio')
## Game.MasterAudio.GroupInfo(string, string) Method
Gets the group info of a given string. To prevent a reference to the game, the type is boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). You can cast it to AudioGroupInfo type to restore its functionality.  
```csharp
public static object GroupInfo(string source, string sound);
```
#### Parameters
<a name='KeepCoding.Game.MasterAudio.GroupInfo(string.string).source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The source of the sound, which is typically the assembly name which uses the bundle that contains the sound.
  
<a name='KeepCoding.Game.MasterAudio.GroupInfo(string.string).sound'></a>
`sound` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the sound.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') which contains the GroupInfo of the desired [source](Game.MasterAudio.GroupInfo.WOMpEvj+cR0v4hJnGJa8dw.md#KeepCoding.Game.MasterAudio.GroupInfo(string.string).source 'KeepCoding.Game.MasterAudio.GroupInfo(string, string).source') and [sound](Game.MasterAudio.GroupInfo.WOMpEvj+cR0v4hJnGJa8dw.md#KeepCoding.Game.MasterAudio.GroupInfo(string.string).sound 'KeepCoding.Game.MasterAudio.GroupInfo(string, string).sound'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') if no such GroupInfo exists.
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: Returns the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') argument given boxed as [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object').  
