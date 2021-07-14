#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ILog](KeepCoding_ILog.md 'KeepCoding.ILog')
## ILog.Log&lt;T&gt;(T, object[]) Method
Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.  
```csharp
void Log<T>(T message, params object[] args);
```
#### Type parameters
<a name='KeepCoding_ILog_Log_T_(T_object__)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_ILog_Log_T_(T_object__)_message'></a>
`message` [T](KeepCoding_ILog_Log_T_(T_object__).md#KeepCoding_ILog_Log_T_(T_object__)_T 'KeepCoding.ILog.Log&lt;T&gt;(T, object[]).T')  
The message to log.
  
<a name='KeepCoding_ILog_Log_T_(T_object__)_args'></a>
`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the arguments to embed into [message](KeepCoding_ILog_Log_T_(T_object__).md#KeepCoding_ILog_Log_T_(T_object__)_message 'KeepCoding.ILog.Log&lt;T&gt;(T, object[]).message').
  
#### Exceptions
[UnrecognizedValueException](KeepCoding_UnrecognizedValueException.md 'KeepCoding.UnrecognizedValueException')  
