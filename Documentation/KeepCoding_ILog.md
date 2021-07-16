#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ILog Interface
An interface to implement log methods. Make each method return the same method in your [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') instance.    
```csharp
public interface ILog
```

Derived  
&#8627; [Logger](KeepCoding_Logger.md 'KeepCoding.Logger')  
&#8627; [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')  
&#8627; [ReflectionScript](KeepCoding_ReflectionScript.md 'KeepCoding.ReflectionScript')  

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](KeepCoding_ILog_Log_T_(T_LogType).md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](KeepCoding_ILog_Log_T_(T_object__).md 'KeepCoding.ILog.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](KeepCoding_ILog_LogMultiple(string__).md 'KeepCoding.ILog.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
