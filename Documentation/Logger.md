#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Logger Class
A class to allow logging with a specific format.  
```csharp
public sealed class Logger :
KeepCoding.IDump,
KeepCoding.ILog
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Logger  

Implements [IDump](IDump.md 'KeepCoding.IDump'), [ILog](ILog.md 'KeepCoding.ILog')  

| Constructors | |
| :--- | :--- |
| [Logger(string, bool, bool)](Logger__ctor__NCu4SzcSfcSl7KJ5Sq0xg.md 'KeepCoding.Logger.Logger(string, bool, bool)') | The string constructor. The string determines the name.<br/> |
| [Logger(Type, bool, bool)](Logger__ctor_4L57uxTXLgNuJlmfYgDkGg.md 'KeepCoding.Logger.Logger(System.Type, bool, bool)') | The type constructor. The type's name determines the name.<br/> |

| Properties | |
| :--- | :--- |
| [Id](Logger_Id.md 'KeepCoding.Logger.Id') | The unique identifier of the current name.<br/> |
| [Name](Logger_Name.md 'KeepCoding.Logger.Name') | The name of the logger.<br/> |

| Methods | |
| :--- | :--- |
| [Dump&lt;T&gt;(T, bool)](Logger_Dump_sOqEkA_6mI90Sls4_uLMZg.md 'KeepCoding.Logger.Dump&lt;T&gt;(T, bool)') | Dumps all information that it can find of the type using reflection. This should only be used to debug.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](Logger_Dump_x+v7FKpxDQQ+5kiNy6jniw.md 'KeepCoding.Logger.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](Logger_Dump_wYXyhtR7mHSW0mWETmEoGw.md 'KeepCoding.Logger.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Equals(object)](Logger_Equals_DVZE2diCamO9YgzkrYBlUQ.md 'KeepCoding.Logger.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](Logger_GetHashCode().md 'KeepCoding.Logger.GetHashCode()') | Gets the hash code of the object.<br/> |
| [Log&lt;T&gt;(T, LogType)](Logger_Log_Wz0d+VHTw6EG8JBAiCT3cw.md 'KeepCoding.Logger.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](Logger_Log_VQRwxNpiXEL9B9w1CEt5IA.md 'KeepCoding.Logger.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](Logger_LogMultiple_0zg_BZiTCVeOMMe+ofo+QA.md 'KeepCoding.Logger.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |