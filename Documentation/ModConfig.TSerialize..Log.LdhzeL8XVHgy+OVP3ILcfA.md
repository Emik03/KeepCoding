#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.LogType).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.LogType).message'></a>
`message` [T](ModConfig.TSerialize..Log.LdhzeL8XVHgy+OVP3ILcfA.md#KeepCoding.ModConfig.TSerialize..Log.T.(T.LogType).T 'KeepCoding.ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.LogType).logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, LogType)](ILog.Log.D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)')  
