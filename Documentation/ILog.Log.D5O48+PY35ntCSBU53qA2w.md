#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ILog](ILog.md 'KeepCoding.ILog')
## ILog.Log&lt;T&gt;(T, LogType) Method
Logs message, but formats it to be compliant with the Logfile Analyzer.  
```csharp
void Log<T>(T message, LogType logType=3);
```
#### Type parameters
<a name='KeepCoding.ILog.Log.T.(T.LogType).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.ILog.Log.T.(T.LogType).message'></a>
`message` [T](ILog.Log.D5O48+PY35ntCSBU53qA2w.md#KeepCoding.ILog.Log.T.(T.LogType).T 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType).T')  
The message to log.
  
<a name='KeepCoding.ILog.Log.T.(T.LogType).logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of logging. Different logging types have different icons within the editor.
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
