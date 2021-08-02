#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ILog Interface
An interface to implement log methods. Make each method return the same method in your [Logger](Logger.md 'KeepCoding.Logger') instance.    
```csharp
public interface ILog
```

Derived  
&#8627; [ReflectionScript](ReflectionScript.md 'KeepCoding.Internal.ReflectionScript')  
&#8627; [Logger](Logger.md 'KeepCoding.Logger')  
&#8627; [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')  

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](ILog_Log_D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ILog_Log_HWlPrcOi+ru2nlGrnQnZCg.md 'KeepCoding.ILog.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ILog_LogMultiple_8hEw_NM7KbVYXvf+JfGQBw.md 'KeepCoding.ILog.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
