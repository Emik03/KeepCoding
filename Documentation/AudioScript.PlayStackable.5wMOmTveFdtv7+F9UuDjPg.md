#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[AudioScript](AudioScript.md 'KeepCoding.AudioScript')
## AudioScript.PlayStackable(string, bool, byte, float, float, float) Method
Plays a sound, with optional parameters.  
```csharp
public void PlayStackable(string name, bool loop=false, byte priority=128, float pitch=1f, float time=0f, float volume=1f);
```
#### Parameters
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the sound clip to play.
  
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).loop'></a>
`loop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If the sound should be looped.
  
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).priority'></a>
`priority` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The priority of the sound.
  
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).pitch'></a>
`pitch` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The pitch of the sound.
  
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).time'></a>
`time` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The time in the audio it should start playing at.
  
<a name='KeepCoding.AudioScript.PlayStackable(string.bool.byte.float.float.float).volume'></a>
`volume` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The volume of the sound clip relative to the game sound.
  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
### Remarks
Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.  
