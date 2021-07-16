#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ReflectionScript](KeepCoding_ReflectionScript.md 'KeepCoding.ReflectionScript')
## ReflectionScript.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding_ReflectionScript_Log_T_(T_LogType)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_ReflectionScript_Log_T_(T_LogType)_message'></a>
`message` [T](KeepCoding_ReflectionScript_Log_T_(T_LogType).md#KeepCoding_ReflectionScript_Log_T_(T_LogType)_T 'KeepCoding.ReflectionScript.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding_ReflectionScript_Log_T_(T_LogType)_logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](KeepCoding_UnrecognizedValueException.md 'KeepCoding.UnrecognizedValueException')  

Implements [Log<T>(T, LogType)](KeepCoding_ILog_Log_T_(T_LogType).md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)')  