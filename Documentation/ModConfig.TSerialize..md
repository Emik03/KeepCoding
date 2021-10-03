#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModConfig&lt;TSerialize&gt; Class
Meant for information that needs to be deserialized within the mod settings folder, by samfundev.  
```csharp
public class ModConfig<TSerialize> :
KeepCoding.ILog
    where TSerialize : new()
```
#### Type parameters
<a name='KeepCoding.ModConfig.TSerialize..TSerialize'></a>
`TSerialize`  
The type to serialize and deserialize the file.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModConfig&lt;TSerialize&gt;  

Derived  
&#8627; [ColorblindInfo](ColorblindInfo.md 'KeepCoding.ColorblindInfo')  

Implements [ILog](ILog.md 'KeepCoding.ILog')  
### Remarks
[https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs](https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs 'https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs')

| Constructors | |
| :--- | :--- |
| [ModConfig()](ModConfig.TSerialize..ModConfig().md 'KeepCoding.ModConfig&lt;TSerialize&gt;.ModConfig()') | Creates a new [ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;') with the target file name and an optional event of when the file is read. A file will automatically be made if it doesn't exist. A JSON property defined in the type [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize') that isn't in the file will automatically write to the file with said property.<br/> |
| [ModConfig(string)](ModConfig.TSerialize...ctor.ZKsea+H43MefB36oOBiG5g.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.ModConfig(string)') | Creates a new [ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;') with the target file name and an optional event of when the file is read. A file will automatically be made if it doesn't exist. A JSON property defined in the type [TSerialize](ModConfig.TSerialize..md#KeepCoding.ModConfig.TSerialize..TSerialize 'KeepCoding.ModConfig&lt;TSerialize&gt;.TSerialize') that isn't in the file will automatically write to the file with said property.<br/> |

| Properties | |
| :--- | :--- |
| [HasReadSucceeded](ModConfig.TSerialize..HasReadSucceeded.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.HasReadSucceeded') | Whether or not there has been a successful read of the settings file. This value will always be false in the editor.<br/> |

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](ModConfig.TSerialize..Log.LdhzeL8XVHgy+OVP3ILcfA.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ModConfig.TSerialize..Log.qagpji8kgTA293N2TKDo5g.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ModConfig.TSerialize..LogMultiple.FD6FNWcJ7Ha1ldIrxqn7Kg.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [Merge(TSerialize, bool)](ModConfig.TSerialize..Merge.ztIxpEjvzLjYtgSKoVEuHQ.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Merge(TSerialize, bool)') | Reads, merges, and writes the settings to the settings file. To protect the user settings, this does nothing if the read isn't successful.<br/> |
| [Read()](ModConfig.TSerialize..Read().md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Read()') | Reads the settings from the settings file. If the settings couldn't be read, the default settings will be returned.<br/> |
| [SerializeSettings(TSerialize)](ModConfig.TSerialize..SerializeSettings.ues7ww2sclx4j.wnw7ThUQ.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.SerializeSettings(TSerialize)') | Serializes settings the same way it's written to the file. Supports settings that use enums.<br/> |
| [ToString()](ModConfig.TSerialize..ToString().md 'KeepCoding.ModConfig&lt;TSerialize&gt;.ToString()') | Deserializes, then reserializes the file according to [SerializeSettings(TSerialize)](ModConfig.TSerialize..SerializeSettings.ues7ww2sclx4j.wnw7ThUQ.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.SerializeSettings(TSerialize)').<br/> |
| [Write(string)](ModConfig.TSerialize..Write.JCanpm.fnSPX3sNGJXtQxg.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Write(string)') | Writes the string to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.<br/> |
| [Write(TSerialize)](ModConfig.TSerialize..Write.BW1ArfhzLuv73fcInRzVFA.md 'KeepCoding.ModConfig&lt;TSerialize&gt;.Write(TSerialize)') | Writes the settings to the settings file. To protect the user settings, this does nothing if the last read wasn't successful.<br/> |
