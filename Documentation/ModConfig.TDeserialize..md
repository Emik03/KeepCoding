#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModConfig&lt;TDeserialize&gt; Class
Meant for information that needs to be deserialized within the mod settings folder by samfundev.  
```csharp
public class ModConfig<TDeserialize> :
KeepCoding.ILog
    where TDeserialize : new()
```
#### Type parameters
<a name='KeepCoding.ModConfig.TDeserialize..TDeserialize'></a>
`TDeserialize`  
The type to deserialize the file.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModConfig&lt;TDeserialize&gt;  

Derived  
&#8627; [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo')  

Implements [ILog](ILog.md 'KeepCoding.ILog')  
### Remarks
[https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs](https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs 'https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs')

| Constructors | |
| :--- | :--- |
| [ModConfig(string)](ModConfig.TDeserialize...ctor.ymLFP7VhjlyqPwd7a+Kdhg.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.ModConfig(string)') | Creates a new [ModConfig&lt;TDeserialize&gt;](ModConfig.TDeserialize..md 'KeepCoding.ModConfig&lt;TDeserialize&gt;') with the target file name and an optional event of when the file is read.<br/> |

| Properties | |
| :--- | :--- |
| [HasReadSucceeded](ModConfig.TDeserialize..HasReadSucceeded.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.HasReadSucceeded') | Whether or not there has been a successful read of the settings file.<br/> |

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](ModConfig.TDeserialize..Log.d3dvmzlayQlaC6rfPrunOw.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ModConfig.TDeserialize..Log.O8ILTuyyeOxq9SD2Yhyv+Q.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ModConfig.TDeserialize..LogMultiple.oXnHLxsKoE1oXHw.bW4.vQ.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [Read(JsonSerializerSettings)](ModConfig.TDeserialize..Read.QEL3k.29cVz6oNkgqzWrww.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.Read(JsonSerializerSettings)') | Reads the settings from the settings file.<br/>If the settings couldn't be read, the default settings will be returned.<br/> |
| [SerializeSettings(TDeserialize)](ModConfig.TDeserialize..SerializeSettings.WJWm5HxCxmgq3r6Dh65L2g.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.SerializeSettings(TDeserialize)') | Serializes settings the same way it's written to the file. Supports settings that use enums.<br/> |
| [ToString()](ModConfig.TDeserialize..ToString().md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.ToString()') | Deserializes, then reserializes the file according to [SerializeSettings(TDeserialize)](ModConfig.TDeserialize..SerializeSettings.WJWm5HxCxmgq3r6Dh65L2g.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.SerializeSettings(TDeserialize)').<br/> |
| [Write(TDeserialize)](ModConfig.TDeserialize..Write.5NxgpqfX.dUC0fgJoiyw9w.md 'KeepCoding.ModConfig&lt;TDeserialize&gt;.Write(TDeserialize)') | Writes the settings to the settings file.<br/>To protect the user settings, this does nothing if the last read wasn't successful.<br/> |
