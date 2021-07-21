#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ILog](KeepCoding_ILog.md 'KeepCoding.ILog')
## ILog.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
void Log<T>(T message, UnityEngine.LogType logType=UnityEngine.LogType.Log);
```
#### Type parameters
<a name='KeepCoding_ILog_Log_T_(T_UnityEngine_LogType)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_ILog_Log_T_(T_UnityEngine_LogType)_message'></a>
`message` [T](KeepCoding_ILog_Log_T_(T_UnityEngine_LogType).md#KeepCoding_ILog_Log_T_(T_UnityEngine_LogType)_T 'KeepCoding.ILog.Log&lt;T&gt;(T, UnityEngine.LogType).T')  
The message to log.
  
<a name='KeepCoding_ILog_Log_T_(T_UnityEngine_LogType)_logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](KeepCoding_UnrecognizedValueException.md 'KeepCoding.UnrecognizedValueException')  
