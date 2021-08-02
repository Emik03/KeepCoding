#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[ReflectionScript](ReflectionScript.md 'KeepCoding.Internal.ReflectionScript')
## ReflectionScript.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_LogType)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_LogType)_message'></a>
`message` [T](ReflectionScript_Log_yFLBbN6vsoZBz7musTRZ_A.md#KeepCoding_Internal_ReflectionScript_Log_T_(T_LogType)_T 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_LogType)_logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, LogType)](ILog_Log_D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)')  
