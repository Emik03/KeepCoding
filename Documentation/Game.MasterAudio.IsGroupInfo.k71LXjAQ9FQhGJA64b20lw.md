#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game').[MasterAudio](Game.MasterAudio.md 'KeepCoding.Game.MasterAudio')
## Game.MasterAudio.IsGroupInfo(string, string) Method
Determines whether a given string has a group info.  
```csharp
public static bool IsGroupInfo(string source, string sound);
```
#### Parameters
<a name='KeepCoding.Game.MasterAudio.IsGroupInfo(string.string).source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The source of the sound, which is typically the assembly name which uses the bundle that contains the sound.
  
<a name='KeepCoding.Game.MasterAudio.IsGroupInfo(string.string).sound'></a>
`sound` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the sound.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [source](Game.MasterAudio.IsGroupInfo.k71LXjAQ9FQhGJA64b20lw.md#KeepCoding.Game.MasterAudio.IsGroupInfo(string.string).source 'KeepCoding.Game.MasterAudio.IsGroupInfo(string, string).source') with [sound](Game.MasterAudio.IsGroupInfo.k71LXjAQ9FQhGJA64b20lw.md#KeepCoding.Game.MasterAudio.IsGroupInfo(string.string).sound 'KeepCoding.Game.MasterAudio.IsGroupInfo(string, string).sound') has a group info, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
