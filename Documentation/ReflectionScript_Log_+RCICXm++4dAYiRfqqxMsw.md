#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[ReflectionScript](ReflectionScript.md 'KeepCoding.Internal.ReflectionScript')
## ReflectionScript.Log&lt;T&gt;(T, object[]) Method
Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, params object[] args);
```
#### Type parameters
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_object__)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_object__)_message'></a>
`message` [T](ReflectionScript_Log_+RCICXm++4dAYiRfqqxMsw.md#KeepCoding_Internal_ReflectionScript_Log_T_(T_object__)_T 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, object[]).T')  
The message to log.
  
<a name='KeepCoding_Internal_ReflectionScript_Log_T_(T_object__)_args'></a>
`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the arguments to embed into [message](ReflectionScript_Log_+RCICXm++4dAYiRfqqxMsw.md#KeepCoding_Internal_ReflectionScript_Log_T_(T_object__)_message 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, object[]).message').
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, object[])](ILog_Log_HWlPrcOi+ru2nlGrnQnZCg.md 'KeepCoding.ILog.Log&lt;T&gt;(T, object[])')  
