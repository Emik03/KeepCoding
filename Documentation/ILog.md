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
&#8627; [ModConfig&lt;TSerialize&gt;](ModConfig.TSerialize..md 'KeepCoding.ModConfig&lt;TSerialize&gt;')  
&#8627; [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')  
&#8627; [MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')  

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](ILog.Log.D5O48+PY35ntCSBU53qA2w.md 'KeepCoding.ILog.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ILog.Log.HWlPrcOi+ru2nlGrnQnZCg.md 'KeepCoding.ILog.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ILog.LogMultiple.8hEw.NM7KbVYXvf+JfGQBw.md 'KeepCoding.ILog.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
