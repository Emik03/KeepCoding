#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ILog](ILog.md 'KeepCoding.ILog')
## ILog.Log&lt;T&gt;(T, object[]) Method
Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.  
```csharp
void Log<T>(T message, params object[] args);
```
#### Type parameters
<a name='KeepCoding.ILog.Log.T.(T.object..).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.ILog.Log.T.(T.object..).message'></a>
`message` [T](ILog.Log.HWlPrcOi+ru2nlGrnQnZCg.md#KeepCoding.ILog.Log.T.(T.object..).T 'KeepCoding.ILog.Log&lt;T&gt;(T, object[]).T')  
The message to log.
  
<a name='KeepCoding.ILog.Log.T.(T.object..).args'></a>
`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the arguments to embed into [message](ILog.Log.HWlPrcOi+ru2nlGrnQnZCg.md#KeepCoding.ILog.Log.T.(T.object..).message 'KeepCoding.ILog.Log&lt;T&gt;(T, object[]).message').
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
