#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')
## ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, object[]) Method
Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.  
```csharp
public void Log<T>(T message, params object[] args);
```
#### Type parameters
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.object..).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.object..).message'></a>
`message` [T](ModConfig.TSerialize..Log.qagpji8kgTA293N2TKDo5g.md#KeepCoding.ModConfig.TSerialize..Log.T.(T.object..).T 'KeepCoding.ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, object[]).T')  
The message to log.
  
<a name='KeepCoding.ModConfig.TSerialize..Log.T.(T.object..).args'></a>
`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the arguments to embed into [message](ModConfig.TSerialize..Log.qagpji8kgTA293N2TKDo5g.md#KeepCoding.ModConfig.TSerialize..Log.T.(T.object..).message 'KeepCoding.ModConfig&lt;TSerialize&gt;.Log&lt;T&gt;(T, object[]).message').
  
#### Exceptions
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  

Implements [Log<T>(T, object[])](ILog.Log.HWlPrcOi+ru2nlGrnQnZCg.md 'KeepCoding.ILog.Log&lt;T&gt;(T, object[])')  
