#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, Func&lt;bool&gt;) Method
You can [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') this to repeatedly [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') an item until a condition is met.  
```csharp
protected static System.Collections.Generic.IEnumerable<T> YieldUntil<T>(T item, System.Func<bool> condition);
```
#### Type parameters
<a name='KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).item'></a>
`item` [T](TPScript.TModule..YieldUntil..nUK6ELh9qhTbrWr9m2Iiw.md#KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).T 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).T')  
The item to yield repeatedly.
  
<a name='KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition to repeatedly check until it returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](TPScript.TModule..YieldUntil..nUK6ELh9qhTbrWr9m2Iiw.md#KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).T 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[item](TPScript.TModule..YieldUntil..nUK6ELh9qhTbrWr9m2Iiw.md#KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).item 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).item') continously until [condition](TPScript.TModule..YieldUntil..nUK6ELh9qhTbrWr9m2Iiw.md#KeepCoding.TPScript.TModule..YieldUntil.T.(T.System.Func.bool.).condition 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;).condition') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
