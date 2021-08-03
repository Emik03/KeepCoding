#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[]) Method
Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.  
```csharp
public void Dump(bool getVariables, params System.Linq.Expressions.Expression<System.Func<object>>[] logs);
```
#### Parameters
<a name='KeepCoding.ModuleScript.Dump(bool.System.Linq.Expressions.Expression.System.Func.object....).getVariables'></a>
`getVariables` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search recursively for the elements within the elements.
  
<a name='KeepCoding.ModuleScript.Dump(bool.System.Linq.Expressions.Expression.System.Func.object....).logs'></a>
`logs` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
All of the variables to throughly log.
  

Implements [Dump(bool, Expression<Func<object>>[])](IDump.Dump.oEw32XwclI51RGS.ki+2AA.md 'KeepCoding.IDump.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])')  
