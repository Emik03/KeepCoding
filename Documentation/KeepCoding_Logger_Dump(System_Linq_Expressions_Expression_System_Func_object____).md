#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Logger](KeepCoding_Logger.md 'KeepCoding.Logger')
## Logger.Dump(Expression&lt;Func&lt;object&gt;&gt;[]) Method
Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.  
```csharp
public void Dump(params System.Linq.Expressions.Expression<System.Func<object>>[] logs);
```
#### Parameters
<a name='KeepCoding_Logger_Dump(System_Linq_Expressions_Expression_System_Func_object____)_logs'></a>
`logs` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the variables to throughly log.
  

Implements [Dump(Expression<Func<object>>[])](KeepCoding_IDump_Dump(System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.IDump.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])')  
