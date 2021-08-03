#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## IDump Interface
An interface to implement dump methods. Make each method return the same method in your [Logger](Logger.md 'KeepCoding.Logger') instance.   
```csharp
public interface IDump
```

Derived  
&#8627; [Logger](Logger.md 'KeepCoding.Logger')  
&#8627; [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')  

| Methods | |
| :--- | :--- |
| [Dump&lt;T&gt;(T, bool)](IDump.Dump.XVZkFQ1vamTg6HNQMK8XrA.md 'KeepCoding.IDump.Dump&lt;T&gt;(T, bool)') | Dumps all information that it can find of the type using reflection. This should only be used to debug.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](IDump.Dump.oEw32XwclI51RGS.ki+2AA.md 'KeepCoding.IDump.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](IDump.Dump.QhCNgIQQrFEyJ0efpnPpQg.md 'KeepCoding.IDump.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
