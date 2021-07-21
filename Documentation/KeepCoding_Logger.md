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

Implements [IDump](KeepCoding_IDump.md 'KeepCoding.IDump'), [ILog](KeepCoding_ILog.md 'KeepCoding.ILog')  

| Constructors | |
| :--- | :--- |
| [Logger(string, bool, bool)](KeepCoding_Logger_Logger(string_bool_bool).md 'KeepCoding.Logger.Logger(string, bool, bool)') | The string constructor. The string determines the name.<br/> |
| [Logger(Type, bool, bool)](KeepCoding_Logger_Logger(System_Type_bool_bool).md 'KeepCoding.Logger.Logger(System.Type, bool, bool)') | The type constructor. The type's name determines the name.<br/> |

| Properties | |
| :--- | :--- |
| [Id](KeepCoding_Logger_Id.md 'KeepCoding.Logger.Id') | The unique identifier of the current name.<br/> |
| [Name](KeepCoding_Logger_Name.md 'KeepCoding.Logger.Name') | The name of the logger.<br/> |

| Methods | |
| :--- | :--- |
| [Dump&lt;T&gt;(T, bool)](KeepCoding_Logger_Dump_T_(T_bool).md 'KeepCoding.Logger.Dump&lt;T&gt;(T, bool)') | Dumps all information that it can find of the type using reflection. This should only be used to debug.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_Logger_Dump(bool_System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.Logger.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_Logger_Dump(System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.Logger.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Equals(object)](KeepCoding_Logger_Equals(object).md 'KeepCoding.Logger.Equals(object)') | Determines if both objects are equal.<br/> |
| [GetHashCode()](KeepCoding_Logger_GetHashCode().md 'KeepCoding.Logger.GetHashCode()') | Gets the hash code of the object.<br/> |
| [Log&lt;T&gt;(T, LogType)](KeepCoding_Logger_Log_T_(T_LogType).md 'KeepCoding.Logger.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](KeepCoding_Logger_Log_T_(T_object__).md 'KeepCoding.Logger.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](KeepCoding_Logger_LogMultiple(string__).md 'KeepCoding.Logger.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
