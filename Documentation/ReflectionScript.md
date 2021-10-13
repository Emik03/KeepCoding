#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## ReflectionScript Class
Editor-only behaviour that gets values from [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')s in real-time.  
```csharp
public sealed class ReflectionScript :
KeepCoding.IStart,
KeepCoding.IFixedUpdate,
KeepCoding.ILog
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; ReflectionScript  

Implements [IStart](IStart.md 'KeepCoding.IStart'), [IFixedUpdate](IFixedUpdate.md 'KeepCoding.IFixedUpdate'), [ILog](ILog.md 'KeepCoding.ILog')  

| Methods | |
| :--- | :--- |
| [FixedUpdate()](ReflectionScript.FixedUpdate().md 'KeepCoding.Internal.ReflectionScript.FixedUpdate()') | Reflects and gets the values of the specified variables.<br/> |
| [Log&lt;T&gt;(T, LogType)](ReflectionScript.Log.yFLBbN6vsoZBz7musTRZ.A.md 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ReflectionScript.Log.+RCICXm++4dAYiRfqqxMsw.md 'KeepCoding.Internal.ReflectionScript.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ReflectionScript.LogMultiple.Ok27UQ6X6Rsjnen.txz8TA.md 'KeepCoding.Internal.ReflectionScript.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [Start()](ReflectionScript.Start().md 'KeepCoding.Internal.ReflectionScript.Start()') | Deletes itself if being ran in-game.<br/> |
