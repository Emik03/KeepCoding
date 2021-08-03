#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[ReflectionScript](ReflectionScript.md 'KeepCoding.Internal.ReflectionScript')
## ReflectionScript.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding.Internal.ReflectionScript.Log.T.(T.LogType).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Internal.ReflectionScript.Log.T.(T.LogType).message'></a>
`message` [T](ReflectionScript.Log.yFLBbN6vsoZBz7musTRZ.A.md#KeepCoding.Internal.ReflectionScript.Log.T.(T.LogType).T 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding.Internal.ReflectionScript.Log.T.(T.LogType).logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, LogType)](ILog.Log.D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)')  
