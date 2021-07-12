### [KeepCoding](KeepCoding.md 'KeepCoding')
## IDump Interface
An interface to implement dump methods. Make each method return the same method in your [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') instance.   
```csharp
public interface IDump
```

Derived  
&#8627; [Logger](KeepCoding_Logger.md 'KeepCoding.Logger')  
&#8627; [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript')  

| Methods | |
| :--- | :--- |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_IDump_Dump(bool_System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.IDump.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_IDump_Dump(System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.IDump.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
