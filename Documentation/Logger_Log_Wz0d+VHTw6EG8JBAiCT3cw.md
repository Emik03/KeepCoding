#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Logger](Logger.md 'KeepCoding.Logger')
## Logger.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding_Logger_Log_T_(T_LogType)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Logger_Log_T_(T_LogType)_message'></a>
`message` [T](Logger_Log_Wz0d+VHTw6EG8JBAiCT3cw.md#KeepCoding_Logger_Log_T_(T_LogType)_T 'KeepCoding.Logger.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding_Logger_Log_T_(T_LogType)_logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, LogType)](ILog_Log_D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)')  
